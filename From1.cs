using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Xsl;
using System.Xml.Linq;

namespace PhonesSelect
{
    public partial class Phones : Form
    {
        #region File paths
        public static string dataPath = @"C:\Users\dinaf\OneDrive\Рабочий стол\Phones select\Data.xml";
        private const string _transformerPath = @"C:\Users\dinaf\OneDrive\Рабочий стол\Phones select\transformer.xsl";
        private const string _htmlPath = @"C:\Users\dinaf\OneDrive\Рабочий стол\Phones select\output.html";
        #endregion

        #region XML atrributes
        public const string phoneTag = "Phone";
        public const string color = "Color";
        public const string year = "Year";
        public const string brand = "Brand";
        public const string size = "Size";
        public const string memory = "Memory";
        public const string price = "Price";
        string[] priceCriterias = { "1. 0-650$", "2. 650-1000$", "3. From 1000$" };
        #endregion

        public Phones()
        {
            InitializeComponent();
        }

        private void XML_Load(object sender, EventArgs e)
        {
            CreateCriteriaLists();
        }

        private void From1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
                "Are you sure you want to exit the program?",
                "End of the program",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);


            if (dialog == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        #region Subfunctions
        /// <summary>
        /// Adds criteria to from from the xml 
        /// </summary>
        private void CreateCriteriaLists()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(dataPath);

            XmlElement root = doc.DocumentElement;
            XmlNodeList phones = root.SelectNodes(phoneTag);

            for (int i = 0; i < phones.Count; i++)
            {
                XmlNode phone = phones.Item(i);
                SearchCriteria criteria = new SearchCriteria(phone);
                AddCriteria(criteria);
            }

            foreach (string _criteria in priceCriterias)
            {
                dlPrice.Items.Add(_criteria);
            }
        }

        /// <summary>
        /// // Add search criteria to the form's lists
        /// </summary>
        private void AddCriteria(SearchCriteria criteria)
        {
            if (!dlBrand.Items.Contains(criteria.Brand))
            {
                dlBrand.Items.Add(criteria.Brand);
            }
            if (!dlYear.Items.Contains(criteria.Year))
            {
                dlYear.Items.Add(criteria.Year);
            }
            if (!dlSize.Items.Contains(criteria.Size))
            {
                dlSize.Items.Add(criteria.Size);
            }
            if (!dlMemory.Items.Contains(criteria.Memory))
            {
                dlMemory.Items.Add(criteria.Memory);
            }
            if (!dlColor.Items.Contains(criteria.Color))
            {
                dlColor.Items.Add(criteria.Color);
            }
        }

        private void Search()
        {
            ISearch search = new LinqToXmlSearch();

            if (rbtnSax.Checked)
            {
                search = new SaxSearch();
            }
            if (rbtnDom.Checked)
            {
                search = new DomSearch();
            }

            List<Phone> phones = search.Search(GetSearchCriteria());
            OutputSearchResults(phones);
        }

        private SearchCriteria GetSearchCriteria()
        {
            string brand = cbBrand.Checked ? dlBrand.Text : "";
            string year = cbYear.Checked ? dlYear.Text : "";
            string size = cbSize.Checked ? dlSize.Text : "";
            string memory = cbMemory.Checked ? dlMemory.Text : "";
            string price = cbPrice.Checked ? dlPrice.Text : "";
            string color = cbColor.Checked ? dlColor.Text : "";

            return new SearchCriteria(brand, year, size, memory, price, color);
        }

        /// <summary>
        /// Outputs search resutls in the rich text box
        /// </summary>
        private void OutputSearchResults(List<Phone> phones)
        {
            rtbSearchResults.Clear();

            for (int i = 0, cntResult = 0; i < phones.Count; ++i)
            {
                if (phones[i] != null)
                {
                    ++cntResult;
                    rtbSearchResults.Text += $"-----------Result {cntResult}----------\n";
                    rtbSearchResults.Text += $"{brand} : {phones[i].Brand}\n";
                    rtbSearchResults.Text += $"{year} : {phones[i].Year}\n";
                    rtbSearchResults.Text += $"{price} : {phones[i].Price}\n";
                    rtbSearchResults.Text += $"{size} : {phones[i].Size}\n";
                    rtbSearchResults.Text += $"{memory} : {phones[i].Memory}\n";
                    rtbSearchResults.Text += $"{color} : {phones[i].Color}\n";
                }
            }
        }

        /// <summary>
        /// Transform xml file to html file in the root folder
        /// </summary>
        private void TransformToHtml()
        {
            XslCompiledTransform xct = new XslCompiledTransform();
            xct.Load(_transformerPath);
            xct.Transform(dataPath, _htmlPath);
        }
        #endregion

        #region Header items
        private void tsmiLoadXMLFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "xml files (*.xml)|*.xml|All|*.*";
                openFileDialog.ShowDialog();
                dataPath = openFileDialog.FileName;

                var _ = XDocument.Load(Phones.dataPath);
            }
            catch
            {
                MessageBox.Show("Please choose another file", "ERROR: opening of the file is failed");
            }
        }

        private void tsmiTransformToHTML_Click(object sender, EventArgs e)
        {
            TransformToHtml();
        }

        private void tsmiHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Some Explanations:
                Brand - The brand of phone 
                Year - Release year
                Price - The price ranges of phones 
                Size - The phone screen size in inches
                Memory - Inner memory of phone
                Color - Color of the phone

                Select one or couple of items and start your search!

                If you want to save in HTML: menu -> 'File' -> 'Transform to HTML'", "Help");
        }

        private void tsmiAboutUs_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The program is created by The Grassman's\n\nOur Email: thegrassmans.inc@gmail.com", "About us");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion 

        #region CheckBoxes
        private void cbBrand_CheckedChanged(object sender, EventArgs e)
        {
            dlBrand.Enabled = !dlBrand.Enabled;
            if (cbBrand.Checked)
            {
                dlBrand.Text = dlBrand.Items[0].ToString();
            }
        }

        private void cbYear_CheckedChanged(object sender, EventArgs e)
        {
            dlYear.Enabled = !dlYear.Enabled;
            if (cbYear.Checked)
            {
                dlYear.Text = dlYear.Items[0].ToString();
            }
        }

        private void cbSize_CheckedChanged(object sender, EventArgs e)
        {
            dlSize.Enabled = !dlSize.Enabled;
            if (cbSize.Checked)
            {
                dlSize.Text = dlSize.Items[0].ToString();
            }
        }

        private void cbMemory_CheckedChanged(object sender, EventArgs e)
        {
            dlMemory.Enabled = !dlMemory.Enabled;
            if (cbMemory.Checked)
            {
                dlMemory.Text = dlMemory.Items[0].ToString();
            }
        }

        private void cbPrice_CheckedChanged(object sender, EventArgs e)
        {
            dlPrice.Enabled = !dlPrice.Enabled;
            if (cbPrice.Checked)
            {
                dlPrice.Text = dlPrice.Items[0].ToString();
            }
        }
        private void cbColor_CheckedChanged(object sender, EventArgs e)
        {
            dlColor.Enabled = !dlColor.Enabled;
            if (cbColor.Checked)
            {
                dlColor.Text = dlColor.Items[0].ToString();
            }
        }
        #endregion

        #region Buttons
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Search();
            }
            catch
            {
                MessageBox.Show("Problem with XML file\nPlease choose another XML file", "ERROR: search failed");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rtbSearchResults.Clear();
        }
        #endregion
    }
}