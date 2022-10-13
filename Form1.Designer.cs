namespace tovar
{
    partial class List
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(List));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.NewBookButton = new System.Windows.Forms.ToolStripButton();
            this.NewFoodButton = new System.Windows.Forms.ToolStripButton();
            this.RemoveProductButton = new System.Windows.Forms.ToolStripButton();
            this.textboxRow = new System.Windows.Forms.TextBox();
            this.textboxName = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.textBoxCountry = new System.Windows.Forms.TextBox();
            this.txtboxDateEnd_Pages = new System.Windows.Forms.TextBox();
            this.txtboxAuthor_Amount = new System.Windows.Forms.TextBox();
            this.txtboxMeasure_House = new System.Windows.Forms.TextBox();
            this.textBoxDescryption = new System.Windows.Forms.TextBox();
            this.lableRow = new System.Windows.Forms.Label();
            this.buttonAddConfirm = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelCountry = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelAuthor_Amount = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelHouse_Measure = new System.Windows.Forms.Label();
            this.labelPages_Date = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.buttonRemoveConfirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(943, 291);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Goods name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Type";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "date";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "price";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "country";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "description";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 400;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewBookButton,
            this.NewFoodButton,
            this.RemoveProductButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(955, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // NewBookButton
            // 
            this.NewBookButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.NewBookButton.Image = ((System.Drawing.Image)(resources.GetObject("NewBookButton.Image")));
            this.NewBookButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewBookButton.Name = "NewBookButton";
            this.NewBookButton.Size = new System.Drawing.Size(88, 22);
            this.NewBookButton.Text = "Add new book";
            // 
            // NewFoodButton
            // 
            this.NewFoodButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.NewFoodButton.Image = ((System.Drawing.Image)(resources.GetObject("NewFoodButton.Image")));
            this.NewFoodButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewFoodButton.Name = "NewFoodButton";
            this.NewFoodButton.Size = new System.Drawing.Size(131, 22);
            this.NewFoodButton.Text = "Add new food product";
            // 
            // RemoveProductButton
            // 
            this.RemoveProductButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.RemoveProductButton.Image = ((System.Drawing.Image)(resources.GetObject("RemoveProductButton.Image")));
            this.RemoveProductButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RemoveProductButton.Name = "RemoveProductButton";
            this.RemoveProductButton.Size = new System.Drawing.Size(99, 22);
            this.RemoveProductButton.Text = "Remove product";
            // 
            // textboxRow
            // 
            this.textboxRow.Location = new System.Drawing.Point(0, 367);
            this.textboxRow.Name = "textboxRow";
            this.textboxRow.Size = new System.Drawing.Size(69, 23);
            this.textboxRow.TabIndex = 2;
            // 
            // textboxName
            // 
            this.textboxName.Location = new System.Drawing.Point(348, 349);
            this.textboxName.Name = "textboxName";
            this.textboxName.Size = new System.Drawing.Size(67, 23);
            this.textboxName.TabIndex = 3;
            this.textboxName.Visible = false;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(478, 349);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(67, 23);
            this.textBoxPrice.TabIndex = 4;
            this.textBoxPrice.Visible = false;
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(636, 349);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(67, 23);
            this.textBoxDate.TabIndex = 5;
            this.textBoxDate.Visible = false;
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.Location = new System.Drawing.Point(781, 349);
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.Size = new System.Drawing.Size(67, 23);
            this.textBoxCountry.TabIndex = 6;
            this.textBoxCountry.Visible = false;
            // 
            // txtboxDateEnd_Pages
            // 
            this.txtboxDateEnd_Pages.Location = new System.Drawing.Point(348, 435);
            this.txtboxDateEnd_Pages.Name = "txtboxDateEnd_Pages";
            this.txtboxDateEnd_Pages.Size = new System.Drawing.Size(67, 23);
            this.txtboxDateEnd_Pages.TabIndex = 7;
            this.txtboxDateEnd_Pages.Visible = false;
            // 
            // txtboxAuthor_Amount
            // 
            this.txtboxAuthor_Amount.Location = new System.Drawing.Point(621, 435);
            this.txtboxAuthor_Amount.Name = "txtboxAuthor_Amount";
            this.txtboxAuthor_Amount.Size = new System.Drawing.Size(67, 23);
            this.txtboxAuthor_Amount.TabIndex = 8;
            this.txtboxAuthor_Amount.Visible = false;
            // 
            // txtboxMeasure_House
            // 
            this.txtboxMeasure_House.Location = new System.Drawing.Point(479, 435);
            this.txtboxMeasure_House.Name = "txtboxMeasure_House";
            this.txtboxMeasure_House.Size = new System.Drawing.Size(67, 23);
            this.txtboxMeasure_House.TabIndex = 9;
            this.txtboxMeasure_House.Visible = false;
            // 
            // textBoxDescryption
            // 
            this.textBoxDescryption.Location = new System.Drawing.Point(775, 435);
            this.textBoxDescryption.Name = "textBoxDescryption";
            this.textBoxDescryption.Size = new System.Drawing.Size(67, 23);
            this.textBoxDescryption.TabIndex = 10;
            this.textBoxDescryption.Visible = false;
            // 
            // lableRow
            // 
            this.lableRow.AutoSize = true;
            this.lableRow.Location = new System.Drawing.Point(0, 349);
            this.lableRow.Name = "lableRow";
            this.lableRow.Size = new System.Drawing.Size(78, 15);
            this.lableRow.TabIndex = 11;
            this.lableRow.Text = "Row number:";
            // 
            // buttonAddConfirm
            // 
            this.buttonAddConfirm.Location = new System.Drawing.Point(864, 385);
            this.buttonAddConfirm.Name = "buttonAddConfirm";
            this.buttonAddConfirm.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonAddConfirm.Size = new System.Drawing.Size(79, 45);
            this.buttonAddConfirm.TabIndex = 12;
            this.buttonAddConfirm.Text = "Confirm";
            this.buttonAddConfirm.UseVisualStyleBackColor = true;
            this.buttonAddConfirm.Visible = false;
            this.buttonAddConfirm.Click += new System.EventHandler(this.buttonAddConfirm_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(303, 352);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(42, 15);
            this.labelName.TabIndex = 13;
            this.labelName.Text = "Name:";
            this.labelName.Visible = false;
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Location = new System.Drawing.Point(722, 352);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(53, 15);
            this.labelCountry.TabIndex = 14;
            this.labelCountry.Text = "Country:";
            this.labelCountry.Visible = false;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(551, 352);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(79, 15);
            this.labelDate.TabIndex = 15;
            this.labelDate.Text = "Packing Date:";
            this.labelDate.Visible = false;
            // 
            // labelAuthor_Amount
            // 
            this.labelAuthor_Amount.AutoSize = true;
            this.labelAuthor_Amount.Location = new System.Drawing.Point(551, 438);
            this.labelAuthor_Amount.Name = "labelAuthor_Amount";
            this.labelAuthor_Amount.Size = new System.Drawing.Size(89, 15);
            this.labelAuthor_Amount.TabIndex = 16;
            this.labelAuthor_Amount.Text = "Author amount";
            this.labelAuthor_Amount.Visible = false;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(430, 352);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(36, 15);
            this.labelPrice.TabIndex = 17;
            this.labelPrice.Text = "Price:";
            this.labelPrice.Visible = false;
            // 
            // labelHouse_Measure
            // 
            this.labelHouse_Measure.AutoSize = true;
            this.labelHouse_Measure.Location = new System.Drawing.Point(415, 438);
            this.labelHouse_Measure.Name = "labelHouse_Measure";
            this.labelHouse_Measure.Size = new System.Drawing.Size(89, 15);
            this.labelHouse_Measure.TabIndex = 18;
            this.labelHouse_Measure.Text = "House measure";
            this.labelHouse_Measure.Visible = false;
            // 
            // labelPages_Date
            // 
            this.labelPages_Date.AutoSize = true;
            this.labelPages_Date.Location = new System.Drawing.Point(264, 438);
            this.labelPages_Date.Name = "labelPages_Date";
            this.labelPages_Date.Size = new System.Drawing.Size(64, 15);
            this.labelPages_Date.TabIndex = 19;
            this.labelPages_Date.Text = "pages date";
            this.labelPages_Date.Visible = false;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(694, 438);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(67, 15);
            this.labelDescription.TabIndex = 20;
            this.labelDescription.Text = "Description";
            this.labelDescription.Visible = false;
            // 
            // buttonRemoveConfirm
            // 
            this.buttonRemoveConfirm.Location = new System.Drawing.Point(99, 367);
            this.buttonRemoveConfirm.Name = "buttonRemoveConfirm";
            this.buttonRemoveConfirm.Size = new System.Drawing.Size(71, 23);
            this.buttonRemoveConfirm.TabIndex = 21;
            this.buttonRemoveConfirm.Text = "Confirm";
            this.buttonRemoveConfirm.UseVisualStyleBackColor = true;
            this.buttonRemoveConfirm.Click += new System.EventHandler(this.buttonRemoveConfirm_Click);
            // 
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 489);
            this.Controls.Add(this.buttonRemoveConfirm);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelPages_Date);
            this.Controls.Add(this.labelHouse_Measure);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelAuthor_Amount);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelCountry);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonAddConfirm);
            this.Controls.Add(this.lableRow);
            this.Controls.Add(this.textBoxDescryption);
            this.Controls.Add(this.txtboxMeasure_House);
            this.Controls.Add(this.txtboxAuthor_Amount);
            this.Controls.Add(this.txtboxDateEnd_Pages);
            this.Controls.Add(this.textBoxCountry);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textboxName);
            this.Controls.Add(this.textboxRow);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "List";
            this.Text = "List of products";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private ToolStrip toolStrip1;
        private ToolStripButton NewBookButton;
        private ToolStripButton NewFoodButton;
        private ToolStripButton RemoveProductButton;
        private TextBox textboxRow;
        private TextBox textboxName;
        private TextBox textBoxPrice;
        private TextBox textBoxDate;
        private TextBox textBoxCountry;
        private TextBox txtboxDateEnd_Pages;
        private TextBox txtboxAuthor_Amount;
        private TextBox txtboxMeasure_House;
        private TextBox textBoxDescryption;
        private Label lableRow;
        private Button buttonAddConfirm;
        private Label labelName;
        private Label labelCountry;
        private Label labelDate;
        private Label labelAuthor_Amount;
        private Label labelPrice;
        private Label labelHouse_Measure;
        private Label labelPages_Date;
        private Label labelDescription;
        private Button buttonRemoveConfirm;
    }
}