using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api2Amp
{
    public class RootObject
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string body { get; set; }
        public string pub_date { get { return DateTime.Now.ToShortDateString(); } }
    }
}
