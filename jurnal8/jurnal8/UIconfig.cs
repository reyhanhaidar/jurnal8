using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace jurnal8
{
   public class UIconfig
    {

        public BankTransferConfig con;
        public const string filePath = "D:\\jurnal8\\jurnal8\\jurnal8\\bank_transfer_config.js";

        private BankTransferConfig ReadConfigFile()
        {
            string configJsonData = File.ReadAllText("D:\\jurnal8\\jurnal8\\jurnal8\\bank_transfer_config.js");
            BankTransferConfig config = JsonSerializer.Deserialize<BankTransferConfig>(configJsonData);
            return config;
        }
        private void SetDefault() { Console.WriteLine("belum ada"); }
        private void WriteNewConfigFile()
        {
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };
            string jsonString = JsonSerializer.Serialize(con, options);
            File.WriteAllText(filePath, jsonString);
        }
        public UIconfig()
        {
            try
            {
                ReadConfigFile();
            }
            catch (Exception)
            {
                SetDefault();
                WriteNewConfigFile();
            }

        }
    }
}
