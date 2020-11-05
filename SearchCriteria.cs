using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PhonesSelect
{
    public struct SearchCriteria
    {
        #region Propeties
        public string Brand { get; }
        public string Year { get; }
        public string Size { get; }
        public string Memory { get; }
        public string Price { get; }
        public string Color { get; }
        #endregion

        public SearchCriteria(XmlNode phone)
        {
            Brand = phone.Attributes[Phones.brand].Value;
            Year = phone.Attributes[Phones.year].Value;
            Size = phone.Attributes[Phones.size].Value;
            Memory = phone.Attributes[Phones.memory].Value;
            Price = phone.Attributes[Phones.price].Value;
            Color = phone.Attributes[Phones.color].Value;
        }

        public SearchCriteria(string brand, string year, string size, string memory, string price, string color)
        {
            Brand = brand;
            Year = year;
            Size = size;
            Memory = memory;
            Price = price;
            Color = color;
        }

        public bool AllCriteriaAreEmpty()
        {
            return Brand.Equals("") && Year.Equals("") &&
                   Size.Equals("") && Memory.Equals("") && Price.Equals("") && Color.Equals("");
        }

        public List<string> GetCriteriaList()
        {
            List<string> result = new List<string>();

            result.Add(Brand);
            result.Add(Year);
            result.Add(Size);
            result.Add(Memory);
            result.Add(Price);
            result.Add(Color);

            return result;
        }

        #region Price Criteria
        public bool IsPriceInCriteria(string price, string priceCriteria)
        {
            if (priceCriteria.Equals(""))
            {
                return true;
            }

            double priceParsed = double.Parse(price.Split('$')[0], System.Globalization.NumberStyles.AllowDecimalPoint, System.Globalization.NumberFormatInfo.InvariantInfo); ;

            int criteria = int.Parse(priceCriteria[0].ToString());
            switch (criteria)
            {
                case 1:
                    return priceParsed <= 650;
                case 2:
                    return 650 < priceParsed && priceParsed <= 1000;
                case 3:
                    return priceParsed > 1000;
            }
            return false;
        }
        #endregion
    }
}
