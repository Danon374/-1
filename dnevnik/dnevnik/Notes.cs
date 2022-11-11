using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnevnik
{
    class Notes
    {
        public Notes(string name, string description, DateTime date)
        {
            this.name = name;
            this.description = description;
            this.date = date;
        }

        public string name { get; set; }
        public string description { get; set; }
        public DateTime date { get; set; }
    }
}
