using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace jurnal8
{
    public class BankTransferConfig
    {
        public String L { set; get; }
       

        public string[] methods { set; get; }
   

        public BankTransferConfig(string l, int threshold, int low_free, int high_free, string[] methods, String en, String id)
        {
            L = l;
            Transfer trans = new Transfer();
            trans.threshold = threshold;
            trans.low_free = low_free;
            trans.high_free = high_free;
            methods = methods;
            Confirmation conf = new Confirmation();
            conf.en = en;
            conf.id = id;

        }

    }
}

    
