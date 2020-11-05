namespace PhonesSelect
{
    partial class Phones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Phones));
            this.rtbSearchResults = new System.Windows.Forms.RichTextBox();
            this.rbtnLinq = new System.Windows.Forms.RadioButton();
            this.rbtnSax = new System.Windows.Forms.RadioButton();
            this.rbtnDom = new System.Windows.Forms.RadioButton();
            this.dlSize = new System.Windows.Forms.ComboBox();
            this.cbSize = new System.Windows.Forms.CheckBox();
            this.dlYear = new System.Windows.Forms.ComboBox();
            this.cbYear = new System.Windows.Forms.CheckBox();
            this.dlBrand = new System.Windows.Forms.ComboBox();
            this.cbBrand = new System.Windows.Forms.CheckBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dlMemory = new System.Windows.Forms.ComboBox();
            this.cbMemory = new System.Windows.Forms.CheckBox();
            this.dlPrice = new System.Windows.Forms.ComboBox();
            this.cbPrice = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiProgramXML = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAboutUs = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLoadXMLFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTransformToHTML = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.cbColor = new System.Windows.Forms.CheckBox();
            this.dlColor = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbSearchResults
            // 
            resources.ApplyResources(this.rtbSearchResults, "rtbSearchResults");
            this.rtbSearchResults.BackColor = System.Drawing.Color.LavenderBlush;
            this.rtbSearchResults.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.rtbSearchResults.Name = "rtbSearchResults";
            this.rtbSearchResults.ReadOnly = true;
            // 
            // rbtnLinq
            // 
            resources.ApplyResources(this.rbtnLinq, "rbtnLinq");
            this.rbtnLinq.Checked = true;
            this.rbtnLinq.Name = "rbtnLinq";
            this.rbtnLinq.TabStop = true;
            this.rbtnLinq.UseVisualStyleBackColor = true;
            // 
            // rbtnSax
            // 
            resources.ApplyResources(this.rbtnSax, "rbtnSax");
            this.rbtnSax.Name = "rbtnSax";
            this.rbtnSax.UseVisualStyleBackColor = true;
            // 
            // rbtnDom
            // 
            resources.ApplyResources(this.rbtnDom, "rbtnDom");
            this.rbtnDom.Name = "rbtnDom";
            this.rbtnDom.UseVisualStyleBackColor = true;
            // 
            // dlSize
            // 
            this.dlSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.dlSize, "dlSize");
            this.dlSize.FormattingEnabled = true;
            this.dlSize.Name = "dlSize";
            this.dlSize.Sorted = true;
            // 
            // cbSize
            // 
            resources.ApplyResources(this.cbSize, "cbSize");
            this.cbSize.Name = "cbSize";
            this.cbSize.UseVisualStyleBackColor = true;
            this.cbSize.CheckedChanged += new System.EventHandler(this.cbSize_CheckedChanged);
            // 
            // dlYear
            // 
            this.dlYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.dlYear, "dlYear");
            this.dlYear.FormattingEnabled = true;
            this.dlYear.Name = "dlYear";
            this.dlYear.Sorted = true;
            // 
            // cbYear
            // 
            resources.ApplyResources(this.cbYear, "cbYear");
            this.cbYear.Name = "cbYear";
            this.cbYear.UseVisualStyleBackColor = true;
            this.cbYear.CheckedChanged += new System.EventHandler(this.cbYear_CheckedChanged);
            // 
            // dlBrand
            // 
            this.dlBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.dlBrand, "dlBrand");
            this.dlBrand.FormattingEnabled = true;
            this.dlBrand.Name = "dlBrand";
            this.dlBrand.Sorted = true;
            // 
            // cbBrand
            // 
            resources.ApplyResources(this.cbBrand, "cbBrand");
            this.cbBrand.Name = "cbBrand";
            this.cbBrand.UseVisualStyleBackColor = true;
            this.cbBrand.CheckedChanged += new System.EventHandler(this.cbBrand_CheckedChanged);
            // 
            // btnSearch
            // 
            resources.ApplyResources(this.btnSearch, "btnSearch");
            this.btnSearch.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            resources.ApplyResources(this.btnClear, "btnClear");
            this.btnClear.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.btnClear.Name = "btnClear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dlMemory
            // 
            this.dlMemory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.dlMemory, "dlMemory");
            this.dlMemory.FormattingEnabled = true;
            this.dlMemory.Name = "dlMemory";
            this.dlMemory.Sorted = true;
            // 
            // cbMemory
            // 
            resources.ApplyResources(this.cbMemory, "cbMemory");
            this.cbMemory.Name = "cbMemory";
            this.cbMemory.UseVisualStyleBackColor = true;
            this.cbMemory.CheckedChanged += new System.EventHandler(this.cbMemory_CheckedChanged);
            // 
            // dlPrice
            // 
            this.dlPrice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.dlPrice, "dlPrice");
            this.dlPrice.FormattingEnabled = true;
            this.dlPrice.Name = "dlPrice";
            this.dlPrice.Sorted = true;
            // 
            // cbPrice
            // 
            resources.ApplyResources(this.cbPrice, "cbPrice");
            this.cbPrice.Name = "cbPrice";
            this.cbPrice.UseVisualStyleBackColor = true;
            this.cbPrice.CheckedChanged += new System.EventHandler(this.cbPrice_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiProgramXML,
            this.tsmiProgram,
            this.tsmiHelp});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // tsmiProgramXML
            // 
            this.tsmiProgramXML.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAboutUs,
            this.exitToolStripMenuItem});
            this.tsmiProgramXML.Name = "tsmiProgramXML";
            resources.ApplyResources(this.tsmiProgramXML, "tsmiProgramXML");
            // 
            // tsmiAboutUs
            // 
            this.tsmiAboutUs.Name = "tsmiAboutUs";
            resources.ApplyResources(this.tsmiAboutUs, "tsmiAboutUs");
            this.tsmiAboutUs.Click += new System.EventHandler(this.tsmiAboutUs_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tsmiProgram
            // 
            this.tsmiProgram.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLoadXMLFile,
            this.tsmiTransformToHTML});
            this.tsmiProgram.Name = "tsmiProgram";
            resources.ApplyResources(this.tsmiProgram, "tsmiProgram");
            // 
            // tsmiLoadXMLFile
            // 
            this.tsmiLoadXMLFile.Name = "tsmiLoadXMLFile";
            resources.ApplyResources(this.tsmiLoadXMLFile, "tsmiLoadXMLFile");
            this.tsmiLoadXMLFile.Click += new System.EventHandler(this.tsmiLoadXMLFile_Click);
            // 
            // tsmiTransformToHTML
            // 
            this.tsmiTransformToHTML.Name = "tsmiTransformToHTML";
            resources.ApplyResources(this.tsmiTransformToHTML, "tsmiTransformToHTML");
            this.tsmiTransformToHTML.Click += new System.EventHandler(this.tsmiTransformToHTML_Click);
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.Name = "tsmiHelp";
            resources.ApplyResources(this.tsmiHelp, "tsmiHelp");
            this.tsmiHelp.Click += new System.EventHandler(this.tsmiHelp_Click);
            // 
            // cbColor
            // 
            resources.ApplyResources(this.cbColor, "cbColor");
            this.cbColor.Name = "cbColor";
            this.cbColor.UseVisualStyleBackColor = true;
            this.cbColor.CheckedChanged += new System.EventHandler(this.cbColor_CheckedChanged);
            // 
            // dlColor
            // 
            this.dlColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.dlColor, "dlColor");
            this.dlColor.FormattingEnabled = true;
            this.dlColor.Name = "dlColor";
            this.dlColor.Sorted = true;
            // 
            // Phones
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Controls.Add(this.dlColor);
            this.Controls.Add(this.cbColor);
            this.Controls.Add(this.dlPrice);
            this.Controls.Add(this.cbPrice);
            this.Controls.Add(this.dlMemory);
            this.Controls.Add(this.cbMemory);
            this.Controls.Add(this.dlSize);
            this.Controls.Add(this.rbtnLinq);
            this.Controls.Add(this.cbSize);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dlYear);
            this.Controls.Add(this.rbtnSax);
            this.Controls.Add(this.cbYear);
            this.Controls.Add(this.dlBrand);
            this.Controls.Add(this.cbBrand);
            this.Controls.Add(this.rbtnDom);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.rtbSearchResults);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Phones";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.From1_FormClosing);
            this.Load += new System.EventHandler(this.XML_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbSearchResults;
        private System.Windows.Forms.RadioButton rbtnLinq;
        private System.Windows.Forms.RadioButton rbtnSax;
        private System.Windows.Forms.RadioButton rbtnDom;
        private System.Windows.Forms.ComboBox dlSize;
        private System.Windows.Forms.CheckBox cbSize;
        private System.Windows.Forms.ComboBox dlYear;
        private System.Windows.Forms.CheckBox cbYear;
        private System.Windows.Forms.ComboBox dlBrand;
        private System.Windows.Forms.CheckBox cbBrand;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox dlMemory;
        private System.Windows.Forms.CheckBox cbMemory;
        private System.Windows.Forms.ComboBox dlPrice;
        private System.Windows.Forms.CheckBox cbPrice;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiProgram;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiProgramXML;
        private System.Windows.Forms.ToolStripMenuItem tsmiAboutUs;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiLoadXMLFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiTransformToHTML;
        private System.Windows.Forms.CheckBox cbColor;
        private System.Windows.Forms.ComboBox dlColor;
    }
}

