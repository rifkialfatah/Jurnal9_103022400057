//using System;
//using System.Collections.Generic;
//using System.Security.Cryptography.X509Certificates;
//using System.Text;
//using System.Text.Json;

//namespace Jurnal9_103022400057
//{
//    public class Transfer
//    {
//        public double threshold { get; set; }
//        public double low_fee { get; set; }
//        public double high_fee { get; set; }

//        public Transfer(double threshold, double low_fee, double high_fee)
//        {
//            this.threshold = threshold;
//            this.low_fee = low_fee;
//            this.high_fee = high_fee;
//        }

//        public Transfer()
//        {
//        }
//    }

//    public class Confirmation
//    {
//        public string en { get; set; }
//        public string id { get; set; }

//        public Confirmation(string en, string id)
//        {
//            this.en = en;
//            this.id = id;
//        }

//        public Confirmation()
//        {
//        }
//    }
//    internal class Config
//    {
//        public string lang { get; set; }
//        public Transfer transfer { get; set; }
//        public List<string> methods { get; set; }

//        public Confirmation confirmation { get; set; }
//        public Config(string lang, Transfer transfer, List<string> methods, Confirmation confirmation)
//        {
//            this.lang = lang;
//            this.transfer = transfer;
//            this.methods = methods;
//            this.confirmation = confirmation;
//        }
//        public Config()
//        {
//        }
//    }

//    public class BankTransferConfig
//    {
//        public Config config;
//        private const string filePath = "bank_transfer_config.json";

//        public BankTransferConfig()
//        {
//            try
//            {
//                ReadConfig();
//            }
//            catch
//            {
//                WriteConfig();
//                setDefault();
//            }
//        }
//        public void ReadConfig()
//        {
//            string json = System.IO.File.ReadAllText(filePath);
//            config = System.Text.Json.JsonSerializer.Deserialize<Config>(json);
//        }

//        public void WriteConfig()
//        {
//            string json = System.Text.Json.JsonSerializer.Serialize(config);
//            System.IO.File.WriteAllText(filePath, json);

//        }

//        public void setDefault()
//        {
//            config = new Config
//            {
//                lang = "en",
//                transfer = new Transfer
//                {
//                    threshold = 25000000,
//                    low_fee = 6500,
//                    high_fee = 15000
//                },
//                methods = new List<string> { "RTO (real-time)", "SKN", "RTGS", "BI FAST" },
//                confirmation = new Confirmation
//                {
//                    en = "yes",
//                    id = "ya"
//                }
//            };
//        }
//    }
//}
