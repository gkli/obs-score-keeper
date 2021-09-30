using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreKeeper
{
    internal class Config
    {
        private string configFileName;

        private Config()
        {
            this.Periods = new List<TimePeriod>();
            this.ScoreChangedImageSrcPath = null;
            this.ScoreChangedImageDstPath = null;
        }

        private void SetConfigFileName(string fileName) { configFileName = fileName; }

        public List<TimePeriod> Periods { get; private set; }

        public string ScoreFilePath { get; set; }
        public string TimeFilePath { get; set; }
        //public bool GenerateScoreChangedImage { get; set; }
        public string ScoreChangedImageSrcPath { get; set; }
        public string ScoreChangedImageDstPath { get; set; }

        public void Save()
        {
            if (string.IsNullOrWhiteSpace(configFileName)) throw new InvalidOperationException("Invalid configuration file path");

            string json = Newtonsoft.Json.JsonConvert.SerializeObject(this);

            System.IO.File.WriteAllText(configFileName, json);
        }

        public static Config Load(string configFile)
        {
            if (string.IsNullOrWhiteSpace(configFile))
            {
                throw new ArgumentException("file name cannot be emopty", nameof(configFile));
            }

            if (System.IO.File.Exists(configFile))
            {
                string json = System.IO.File.ReadAllText(configFile);
                if (false == string.IsNullOrWhiteSpace(json))
                {
                    try
                    {
                        Config cfg = Newtonsoft.Json.JsonConvert.DeserializeObject<Config>(json);
                        if (null != cfg)
                        {
                            cfg.SetConfigFileName(configFile);
                            return cfg;
                        }
                    }
                    catch
                    {
                    }
                }
            }

            Config c = new Config(); //if we got this far, we couldn't read config, spin up default
            c.SetConfigFileName(configFile);
            c.SetDefaultValues();
            return c;
        }

        private void SetDefaultValues()
        {
            string root = System.Environment.CurrentDirectory;

            if (string.IsNullOrWhiteSpace(this.ScoreFilePath))
            {
                this.ScoreFilePath = System.IO.Path.Combine(root, "score.txt");
            }

            if (string.IsNullOrWhiteSpace(this.TimeFilePath))
            {
                this.TimeFilePath = System.IO.Path.Combine(root, "clock.txt");
            }

            if (string.IsNullOrEmpty(this.ScoreChangedImageDstPath))
            {
                this.TimeFilePath = System.IO.Path.Combine(root, "goal.gif");
            }

            if (this.Periods.Count == 0)
            {
                //should be game specific
                this.Periods.Add(new TimePeriod() { DurationInMinutes = 40, IncludeInTotalDurationCount = true, Name = "1st Half" });
                this.Periods.Add(new TimePeriod() { DurationInMinutes = 10, IncludeInTotalDurationCount = false, Name = "break" });
                this.Periods.Add(new TimePeriod() { DurationInMinutes = 40, IncludeInTotalDurationCount = true, Name = "2nd Half" });
            }
        }
    }
}
