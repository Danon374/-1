using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnevnik
{
    class Notes
    {
        public Notes(string named, string description, DateTime date)
        {
            this.named = named;
            this.description = description;
            this.date = date;
        }

        public string named { get; set; }
        public string description { get; set; }
        public DateTime date { get; set; }
    }
}
