using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonesSelect
{
    public class Phone
    {
        public string Brand { get; set; }
        public string Year { get; set; }
        public string Price { get; set; }
        public string Size { get; set; }
        public string Memory { get; set; }
        public string Color { get; set; }

        public bool HasEmptyAttribute()
        {
            return Brand.Equals("") || Year.Equals("") || Price.Equals("")
                   || Size.Equals("") || Memory.Equals("") || Color.Equals("");
        }
    }
}
