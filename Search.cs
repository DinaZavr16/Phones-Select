using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Xml;
using System.Xml.Linq;
using System.Linq;

namespace PhonesSelect
{
    public interface ISearch
    {
        List<Phone> Search(SearchCriteria criteria);
    }

    #region Dom 
    public class DomSearch : ISearch
    {
        public List<Phone> Search(SearchCriteria criteria)
        {
            List<Phone> phones = new List<Phone>();
            XmlDocument doc = new XmlDocument();
            doc.Load(Phones.dataPath);

            XmlNodeList phoneNode;

            string xPathCriteria = "";
            string phoneSearchTag = "//" + Phones.phoneTag;

            List<string> attributes = new List<string>();
            attributes.Add(Phones.brand);
            attributes.Add(Phones.year);
            attributes.Add(Phones.size);
            attributes.Add(Phones.memory);
            attributes.Add(Phones.color);

            List<string> criteriaList = new List<string>();
            criteriaList.Add(criteria.Brand);
            criteriaList.Add(criteria.Year);
            criteriaList.Add(criteria.Size);
            criteriaList.Add(criteria.Memory);
            criteriaList.Add(criteria.Color);

            bool criteriaListEmpty = true;
            for (int i = 0; i < criteriaList.Count; i++)
            {
                if (!criteriaList[i].Equals(""))
                {
                    criteriaListEmpty = false;
                    xPathCriteria += "@" + attributes[i] + "='" + criteriaList[i] + "'and";
                }
            }
            if (criteria.AllCriteriaAreEmpty() || criteriaListEmpty)
            {
                phoneNode = doc.SelectNodes(phoneSearchTag);
            }
            else
            {
                int andLength = 3;
                xPathCriteria = xPathCriteria.Substring(0, xPathCriteria.Length - andLength);

                string xPathQuery = phoneSearchTag + "[" + xPathCriteria + "]";
                phoneNode = doc.SelectNodes(xPathQuery);
            }

            foreach (XmlNode phNode in phoneNode)
            {
                Phone phone = new Phone();
                AddCreterias(phone, phNode, criteria);
                if (!phone.HasEmptyAttribute())
                {
                    phones.Add(phone);
                }
            }

            return phones;
        }

        /// <summary>
        /// Set attributes
        /// </summary>
        private void AddCreterias(Phone phone, XmlNode phoneNode, SearchCriteria criteria)
        {
            phone.Brand = phoneNode.Attributes[Phones.brand].Value;
            phone.Size = phoneNode.Attributes[Phones.size].Value;
            phone.Year = phoneNode.Attributes[Phones.year].Value;
            phone.Memory = phoneNode.Attributes[Phones.memory].Value;
            phone.Color = phoneNode.Attributes[Phones.color].Value;

            if (!criteria.Price.Equals(""))
            {
                phone.Price = criteria.IsPriceInCriteria(
                phoneNode.Attributes[Phones.price].Value, criteria.Price) ?
                phoneNode.Attributes[Phones.price].Value : "";
            }
            else
            {
                phone.Price = phoneNode.Attributes[Phones.price].Value;
            }
        }
    }
    #endregion

    #region Sax
    public class SaxSearch : ISearch
    {
        public List<Phone> Search(SearchCriteria criteria)
        {
            List<Phone> phones = new List<Phone>();
            var xmlReader = new XmlTextReader(Phones.dataPath);

            while (xmlReader.Read())
            {
                if (xmlReader.HasAttributes && xmlReader.NodeType == XmlNodeType.Element)
                {
                    Phone phone = new Phone();

                    while (xmlReader.MoveToNextAttribute())
                    {
                        AddCriterias(phone, xmlReader, criteria);
                    }

                    phones.Add(phone.HasEmptyAttribute() ? null : phone);
                }
            }

            return phones;
        }
        /// <summary>
        /// Sets the the game's attributes
        /// </summary>
        private void AddCriterias(Phone phone, XmlReader xmlReader, SearchCriteria criteria)
        {
            string attrName = xmlReader.Name;
            string attrValue = xmlReader.Value;

            if (attrName.Equals(Phones.color))
            {
                phone.Color = attrValue;
            }
            if (attrName.Equals(Phones.brand))
            {
                phone.Brand = CheckCriteria(criteria.Brand, attrValue);
            }
            if (attrName.Equals(Phones.year))
            {
                phone.Year = CheckCriteria(criteria.Year, attrValue);
            }
            if (attrName.Equals(Phones.size))
            {
                phone.Size = CheckCriteria(criteria.Size, attrValue);
            }
            if (attrName.Equals(Phones.memory))
            {
                phone.Memory = CheckCriteria(criteria.Memory, attrValue);
            }
            if (attrName.Equals(Phones.price))
            {
                phone.Price = criteria.IsPriceInCriteria(attrValue, criteria.Price) ? attrValue : "";
            }
        }

        private string CheckCriteria(string criteria, string attrValue)
        {
            if (criteria.Equals(""))
            {
                return attrValue;
            }

            return attrValue.Equals(criteria) ? attrValue : "";
        }
    }
    #endregion

    #region LINQ 
    public class LinqToXmlSearch : ISearch
    {
        public List<Phone> Search(SearchCriteria criteria)
        {
            List<Phone> phones = new List<Phone>();
            var doc = XDocument.Load(Phones.dataPath);

            var phonesInList = from obj in doc.Descendants(Phones.phoneTag)
                              select new
                              {
                                  color = criteria.Color.Equals("") ?
                                  obj.Attribute(Phones.color).Value :
                                  criteria.Color.Equals(obj.Attribute(Phones.color).Value) ?
                                  obj.Attribute(Phones.color).Value : "",

                                  year = criteria.Year.Equals("") ?
                                  obj.Attribute(Phones.year).Value :
                                  criteria.Year.Equals(obj.Attribute(Phones.year).Value) ?
                                  obj.Attribute(Phones.year).Value : "",

                                  brand = criteria.Brand.Equals("") ?
                                  obj.Attribute(Phones.brand).Value :
                                  criteria.Brand.Equals(obj.Attribute(Phones.brand).Value) ?
                                  obj.Attribute(Phones.brand).Value : "",

                                  size = criteria.Size.Equals("") ?
                                  obj.Attribute(Phones.size).Value :
                                  criteria.Size.Equals(obj.Attribute(Phones.size).Value) ?
                                  obj.Attribute(Phones.size).Value : "",

                                  memory = criteria.Memory.Equals("") ?
                                  obj.Attribute(Phones.memory).Value :
                                  criteria.Memory.Equals(obj.Attribute(Phones.memory).Value) ?
                                  obj.Attribute(Phones.memory).Value : "",

                                  price = criteria.Price.Equals("") ?
                                  obj.Attribute(Phones.price).Value :
                                  criteria.IsPriceInCriteria(obj.Attribute(Phones.price).Value, criteria.Price) ?
                                  obj.Attribute(Phones.price).Value : "",
                              };

            foreach (var phoneElem in phonesInList)
            {
                Phone phone = new Phone();
                phone.Brand = phoneElem.brand;
                phone.Year = phoneElem.year;
                phone.Price = phoneElem.price;
                phone.Size = phoneElem.size;
                phone.Memory = phoneElem.memory;
                phone.Color = phoneElem.color;

                phones.Add(phone.HasEmptyAttribute() ? null : phone);
            }
            return phones;
        }
    }
    #endregion
}