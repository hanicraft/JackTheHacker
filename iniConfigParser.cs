using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jth
{
    public class IniConfigParser
    {
        private Dictionary<string, Dictionary<string, string>> _config;

        public IniConfigParser(string filePath)
        {
            _config = new Dictionary<string, Dictionary<string, string>>();
            ParseFile(filePath);
        }

        private void ParseFile(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);

            string currentSection = null;

            foreach (string line in lines)
            {
                string trimmedLine = line.Trim();

                if (string.IsNullOrEmpty(trimmedLine) || trimmedLine.StartsWith(";") || trimmedLine.StartsWith("#"))
                {
                    continue;
                }

                if (trimmedLine.StartsWith("[") && trimmedLine.EndsWith("]"))
                {
                    currentSection = trimmedLine.Substring(1, trimmedLine.Length - 2);
                    _config[currentSection] = new Dictionary<string, string>();
                }
                else
                {
                    string[] parts = trimmedLine.Split('=');

                    if (parts.Length == 2)
                    {
                        string key = parts[0].Trim();
                        string value = parts[1].Trim();

                        if (currentSection != null)
                        {
                            _config[currentSection][key] = value;
                        }
                    }
                }
            }
        }

        public string GetConfigValue(string section, string key)
        {
            if (_config.TryGetValue(section, out Dictionary<string, string> sectionConfig))
            {
                return sectionConfig.TryGetValue(key, out string value) ? value : null;
            }

            return null;
        }

        public Dictionary<string, string> GetSectionConfig(string section)
        {
            return _config.TryGetValue(section, out Dictionary<string, string> sectionConfig) ? sectionConfig : null;
        }
    }
}
