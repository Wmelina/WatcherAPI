using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WatcherAPI
{
    public class Event
    {
        [Key]
        public string id { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int type { get; set; }
    }
}
