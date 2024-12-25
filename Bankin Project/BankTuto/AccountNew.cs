using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace BankTuto
{
    public partial class AccountNew : Form
    {
        private TextBox IncomeTb;
        private Label label9;
        private TextBox PhoneTb;
        private ComboBox EducationCb;
        private Label label8;
        private Label label7;
        private ComboBox GenCb;
        private Label label6;
        private Label label5;
        private TextBox AddressTb;
        private Label label4;
        private TextBox SurnameTb;
        private Label label3;
        private TextBox NameTb;
        private Label label1;
        private Label label2;
        private TextBox TcTb;
        private Panel panel1;
        private Button Search;
        private Button Delete;
        private Button Edit;
        private Button Submit;
        private PictureBox pictureBox1;
        private PictureBox pictureBox6;
        private PictureBox pictureBox2;
        private BankDbDataSet1 bankDbDataSet1;
        private BindingSource accountTblBindingSource;
        private IContainer components;
        private BankDbDataSet1TableAdapters.AccountTblTableAdapter accountTblTableAdapter;
        private BankDbDataSet2 bankDbDataSet2;
        private BindingSource accountTblBindingSource1;
        private BankDbDataSet2TableAdapters.AccountTblTableAdapter accountTblTableAdapter1;
        private DataGridViewTextBoxColumn acTcDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn acBalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn aCIncDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn aCEducDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn aCOccupDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn aCGenDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn aCAddressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn aCPhoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn aCSurnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn aCNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn aCNumDataGridViewTextBoxColumn;
        private DataGridView dataGridView1;
        private TextBox OccupTb;

        public AccountNew()
        {
            InitializeComponent();
            showData("select * from AccountTbl");
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountNew));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.IncomeTb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.PhoneTb = new System.Windows.Forms.TextBox();
            this.EducationCb = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.GenCb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AddressTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SurnameTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NameTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OccupTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TcTb = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Search = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Submit = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bankDbDataSet1 = new BankTuto.BankDbDataSet1();
            this.accountTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountTblTableAdapter = new BankTuto.BankDbDataSet1TableAdapters.AccountTblTableAdapter();
            this.bankDbDataSet2 = new BankTuto.BankDbDataSet2();
            this.accountTblBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.accountTblTableAdapter1 = new BankTuto.BankDbDataSet2TableAdapters.AccountTblTableAdapter();
            this.acTcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acBalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCIncDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCEducDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCOccupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCGenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDbDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountTblBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // IncomeTb
            // 
            this.IncomeTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncomeTb.Location = new System.Drawing.Point(648, 234);
            this.IncomeTb.Margin = new System.Windows.Forms.Padding(4);
            this.IncomeTb.Name = "IncomeTb";
            this.IncomeTb.Size = new System.Drawing.Size(219, 34);
            this.IncomeTb.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(499, 239);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 29);
            this.label9.TabIndex = 41;
            this.label9.Text = "Income";
            // 
            // PhoneTb
            // 
            this.PhoneTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneTb.Location = new System.Drawing.Point(226, 134);
            this.PhoneTb.Margin = new System.Windows.Forms.Padding(4);
            this.PhoneTb.Name = "PhoneTb";
            this.PhoneTb.Size = new System.Drawing.Size(219, 34);
            this.PhoneTb.TabIndex = 40;
            // 
            // EducationCb
            // 
            this.EducationCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.EducationCb.FormattingEnabled = true;
            this.EducationCb.Items.AddRange(new object[] {
            "Uneducated",
            "Diploma",
            "UG ",
            "PG",
            "PHD"});
            this.EducationCb.Location = new System.Drawing.Point(1076, 134);
            this.EducationCb.Margin = new System.Windows.Forms.Padding(4);
            this.EducationCb.Name = "EducationCb";
            this.EducationCb.Size = new System.Drawing.Size(219, 37);
            this.EducationCb.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(934, 140);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 29);
            this.label8.TabIndex = 38;
            this.label8.Text = "Education";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(933, 239);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 29);
            this.label7.TabIndex = 37;
            this.label7.Text = "Occupation";
            // 
            // GenCb
            // 
            this.GenCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.GenCb.FormattingEnabled = true;
            this.GenCb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GenCb.Location = new System.Drawing.Point(648, 126);
            this.GenCb.Margin = new System.Windows.Forms.Padding(4);
            this.GenCb.Name = "GenCb";
            this.GenCb.Size = new System.Drawing.Size(219, 37);
            this.GenCb.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(497, 137);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 29);
            this.label6.TabIndex = 35;
            this.label6.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(116, 239);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 29);
            this.label5.TabIndex = 34;
            this.label5.Text = "Address";
            // 
            // AddressTb
            // 
            this.AddressTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressTb.Location = new System.Drawing.Point(226, 202);
            this.AddressTb.Margin = new System.Windows.Forms.Padding(4);
            this.AddressTb.Multiline = true;
            this.AddressTb.Name = "AddressTb";
            this.AddressTb.Size = new System.Drawing.Size(219, 116);
            this.AddressTb.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(115, 134);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 29);
            this.label4.TabIndex = 32;
            this.label4.Text = "Phone";
            // 
            // SurnameTb
            // 
            this.SurnameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurnameTb.Location = new System.Drawing.Point(648, 54);
            this.SurnameTb.Margin = new System.Windows.Forms.Padding(4);
            this.SurnameTb.Name = "SurnameTb";
            this.SurnameTb.Size = new System.Drawing.Size(219, 34);
            this.SurnameTb.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(115, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 29);
            this.label3.TabIndex = 30;
            this.label3.Text = "Name";
            // 
            // NameTb
            // 
            this.NameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTb.Location = new System.Drawing.Point(226, 54);
            this.NameTb.Margin = new System.Windows.Forms.Padding(4);
            this.NameTb.Name = "NameTb";
            this.NameTb.Size = new System.Drawing.Size(219, 34);
            this.NameTb.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(497, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 29);
            this.label1.TabIndex = 46;
            this.label1.Text = "Surname";
            // 
            // OccupTb
            // 
            this.OccupTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OccupTb.Location = new System.Drawing.Point(1076, 236);
            this.OccupTb.Margin = new System.Windows.Forms.Padding(4);
            this.OccupTb.Name = "OccupTb";
            this.OccupTb.Size = new System.Drawing.Size(219, 34);
            this.OccupTb.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(934, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 29);
            this.label2.TabIndex = 48;
            this.label2.Text = "TC Num";
            // 
            // TcTb
            // 
            this.TcTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TcTb.Location = new System.Drawing.Point(1076, 51);
            this.TcTb.Margin = new System.Windows.Forms.Padding(4);
            this.TcTb.Name = "TcTb";
            this.TcTb.Size = new System.Drawing.Size(219, 34);
            this.TcTb.TabIndex = 49;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-3, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(68, 711);
            this.panel1.TabIndex = 50;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.Purple;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Search.ForeColor = System.Drawing.Color.White;
            this.Search.Location = new System.Drawing.Point(1108, 338);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(131, 50);
            this.Search.TabIndex = 62;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.DarkRed;
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Delete.ForeColor = System.Drawing.Color.White;
            this.Delete.Location = new System.Drawing.Point(906, 338);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(131, 50);
            this.Delete.TabIndex = 61;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.Color.Navy;
            this.Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Edit.ForeColor = System.Drawing.Color.White;
            this.Edit.Location = new System.Drawing.Point(699, 338);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(131, 50);
            this.Edit.TabIndex = 60;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = false;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.Color.Green;
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Submit.ForeColor = System.Drawing.Color.White;
            this.Submit.Location = new System.Drawing.Point(485, 338);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(131, 50);
            this.Submit.TabIndex = 59;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(1344, 338);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(56, 41);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 63;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1375, 13);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 64;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // bankDbDataSet1
            // 
            this.bankDbDataSet1.DataSetName = "BankDbDataSet1";
            this.bankDbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountTblBindingSource
            // 
            this.accountTblBindingSource.DataMember = "AccountTbl";
            this.accountTblBindingSource.DataSource = this.bankDbDataSet1;
            // 
            // accountTblTableAdapter
            // 
            this.accountTblTableAdapter.ClearBeforeFill = true;
            // 
            // bankDbDataSet2
            // 
            this.bankDbDataSet2.DataSetName = "BankDbDataSet2";
            this.bankDbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountTblBindingSource1
            // 
            this.accountTblBindingSource1.DataMember = "AccountTbl";
            this.accountTblBindingSource1.DataSource = this.bankDbDataSet2;
            // 
            // accountTblTableAdapter1
            // 
            this.accountTblTableAdapter1.ClearBeforeFill = true;
            // 
            // acTcDataGridViewTextBoxColumn
            // 
            this.acTcDataGridViewTextBoxColumn.DataPropertyName = "AcTc";
            this.acTcDataGridViewTextBoxColumn.HeaderText = "AcTc";
            this.acTcDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.acTcDataGridViewTextBoxColumn.Name = "acTcDataGridViewTextBoxColumn";
            // 
            // acBalDataGridViewTextBoxColumn
            // 
            this.acBalDataGridViewTextBoxColumn.DataPropertyName = "AcBal";
            this.acBalDataGridViewTextBoxColumn.HeaderText = "AcBal";
            this.acBalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.acBalDataGridViewTextBoxColumn.Name = "acBalDataGridViewTextBoxColumn";
            // 
            // aCIncDataGridViewTextBoxColumn
            // 
            this.aCIncDataGridViewTextBoxColumn.DataPropertyName = "ACInc";
            this.aCIncDataGridViewTextBoxColumn.HeaderText = "ACInc";
            this.aCIncDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aCIncDataGridViewTextBoxColumn.Name = "aCIncDataGridViewTextBoxColumn";
            // 
            // aCEducDataGridViewTextBoxColumn
            // 
            this.aCEducDataGridViewTextBoxColumn.DataPropertyName = "ACEduc";
            this.aCEducDataGridViewTextBoxColumn.HeaderText = "ACEduc";
            this.aCEducDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aCEducDataGridViewTextBoxColumn.Name = "aCEducDataGridViewTextBoxColumn";
            // 
            // aCOccupDataGridViewTextBoxColumn
            // 
            this.aCOccupDataGridViewTextBoxColumn.DataPropertyName = "ACOccup";
            this.aCOccupDataGridViewTextBoxColumn.HeaderText = "ACOccup";
            this.aCOccupDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aCOccupDataGridViewTextBoxColumn.Name = "aCOccupDataGridViewTextBoxColumn";
            // 
            // aCGenDataGridViewTextBoxColumn
            // 
            this.aCGenDataGridViewTextBoxColumn.DataPropertyName = "ACGen";
            this.aCGenDataGridViewTextBoxColumn.HeaderText = "ACGen";
            this.aCGenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aCGenDataGridViewTextBoxColumn.Name = "aCGenDataGridViewTextBoxColumn";
            // 
            // aCAddressDataGridViewTextBoxColumn
            // 
            this.aCAddressDataGridViewTextBoxColumn.DataPropertyName = "ACAddress";
            this.aCAddressDataGridViewTextBoxColumn.HeaderText = "ACAddress";
            this.aCAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aCAddressDataGridViewTextBoxColumn.Name = "aCAddressDataGridViewTextBoxColumn";
            // 
            // aCPhoneDataGridViewTextBoxColumn
            // 
            this.aCPhoneDataGridViewTextBoxColumn.DataPropertyName = "ACPhone";
            this.aCPhoneDataGridViewTextBoxColumn.HeaderText = "ACPhone";
            this.aCPhoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aCPhoneDataGridViewTextBoxColumn.Name = "aCPhoneDataGridViewTextBoxColumn";
            // 
            // aCSurnameDataGridViewTextBoxColumn
            // 
            this.aCSurnameDataGridViewTextBoxColumn.DataPropertyName = "ACSurname";
            this.aCSurnameDataGridViewTextBoxColumn.HeaderText = "ACSurname";
            this.aCSurnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aCSurnameDataGridViewTextBoxColumn.Name = "aCSurnameDataGridViewTextBoxColumn";
            // 
            // aCNameDataGridViewTextBoxColumn
            // 
            this.aCNameDataGridViewTextBoxColumn.DataPropertyName = "ACName";
            this.aCNameDataGridViewTextBoxColumn.HeaderText = "ACName";
            this.aCNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aCNameDataGridViewTextBoxColumn.Name = "aCNameDataGridViewTextBoxColumn";
            // 
            // aCNumDataGridViewTextBoxColumn
            // 
            this.aCNumDataGridViewTextBoxColumn.DataPropertyName = "ACNum";
            this.aCNumDataGridViewTextBoxColumn.HeaderText = "ACNum";
            this.aCNumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aCNumDataGridViewTextBoxColumn.Name = "aCNumDataGridViewTextBoxColumn";
            this.aCNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aCNumDataGridViewTextBoxColumn,
            this.aCNameDataGridViewTextBoxColumn,
            this.aCSurnameDataGridViewTextBoxColumn,
            this.aCPhoneDataGridViewTextBoxColumn,
            this.aCAddressDataGridViewTextBoxColumn,
            this.aCGenDataGridViewTextBoxColumn,
            this.aCOccupDataGridViewTextBoxColumn,
            this.aCEducDataGridViewTextBoxColumn,
            this.aCIncDataGridViewTextBoxColumn,
            this.acBalDataGridViewTextBoxColumn,
            this.acTcDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.accountTblBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(71, 396);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1346, 294);
            this.dataGridView1.TabIndex = 65;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // AccountNew
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1413, 686);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TcTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OccupTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IncomeTb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.PhoneTb);
            this.Controls.Add(this.EducationCb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.GenCb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AddressTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SurnameTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NameTb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccountNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Class1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDbDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountTblBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            MainMenu Obj = new MainMenu();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Transactions Obj = new Transactions();
            Obj.Show();
            this.Hide();

        }

        private void Reset()
        {
            NameTb.Clear();
            SurnameTb.Clear();
            PhoneTb.Clear();
            IncomeTb.Clear();
            TcTb.Clear();
            AddressTb.Clear();
            OccupTb.Clear();
            GenCb.SelectedIndex = -1;
            EducationCb.SelectedIndex = -1;

            NameTb.Focus();
        }


        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MUHARREM\Desktop\BankTuto\BankTuto\BankDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void showData(string Data)
        {
            SqlDataAdapter da = new SqlDataAdapter(Data, Con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("insert into AccountTbl (ACName, ACSurname, ACPhone, ACaddress, ACOccup, ACTc, ACInc,  ACGen, ACEduc, ACBal) values (@Name, @Surname, @Phone,  @address, @occup, @id, @Inc, @Gen, @Educ, @Balance)", Con);
            cmd.Parameters.AddWithValue("@Name", NameTb.Text);
            cmd.Parameters.AddWithValue("@Surname", SurnameTb.Text);
            cmd.Parameters.AddWithValue("@Phone", PhoneTb.Text);
            cmd.Parameters.AddWithValue("@Inc", IncomeTb.Text);
            cmd.Parameters.AddWithValue("@address", AddressTb.Text);
            cmd.Parameters.AddWithValue("@occup", OccupTb.Text);
            cmd.Parameters.AddWithValue("@id", TcTb.Text);
            cmd.Parameters.AddWithValue("Gen", GenCb.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("Educ", EducationCb.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("Balance", 0);
            cmd.ExecuteNonQuery();
            showData("select * from AccountTbl");
            Con.Close();
            Reset();
            MessageBox.Show("Successfu11y Saved");
        }

        private void Class1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankDbDataSet2.AccountTbl' table. You can move, or remove it, as needed.
            this.accountTblTableAdapter1.Fill(this.bankDbDataSet2.AccountTbl);
            // TODO: This line of code loads data into the 'bankDbDataSet1.AccountTbl' table. You can move, or remove it, as needed.
            this.accountTblTableAdapter.Fill(this.bankDbDataSet1.AccountTbl);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;
            string name = dataGridView1.Rows[selected].Cells[1].Value.ToString();
            string surname = dataGridView1.Rows[selected].Cells[2].Value.ToString();
            string phone = dataGridView1.Rows[selected].Cells[3].Value.ToString();
            string adres = dataGridView1.Rows[selected].Cells[4].Value.ToString();
            string gender = dataGridView1.Rows[selected].Cells[5].Value.ToString(); 
            string occup = dataGridView1.Rows[selected].Cells[6].Value.ToString();
            string educ = dataGridView1.Rows[selected].Cells[7].Value.ToString();
            string income = dataGridView1.Rows[selected].Cells[8].Value.ToString();
            string tc = dataGridView1.Rows[selected].Cells[10].Value.ToString();

            NameTb.Text = name;
            SurnameTb.Text = surname;
            PhoneTb.Text = phone;
            AddressTb.Text = adres;
            GenCb.SelectedItem = gender;
            OccupTb.Text = occup;
            EducationCb.SelectedItem = educ;
            IncomeTb.Text = income;
            TcTb.Text = tc;
            
        }

        private void Edit_Click(object sender, EventArgs e)
        {


            Con.Open();
            SqlCommand cmd = new SqlCommand("update AccountTbl set ACName ='" + NameTb.Text + "', ACSurname ='" + SurnameTb.Text + "',ACPhone='" + PhoneTb.Text + "',ACaddress='" + AddressTb.Text + "',ACOccup='" + OccupTb.Text + "',ACTc='" + TcTb.Text + "',ACInc='" + IncomeTb.Text + "',ACGen='" + GenCb.SelectedItem + "',ACEduc='" +EducationCb.SelectedItem + "' where ACTc =@id", Con);

            cmd.Parameters.AddWithValue("@id", TcTb.Text);
            cmd.ExecuteNonQuery();


            showData("select * from AccountTbl");
            Con.Close();
            Reset();
            MessageBox.Show("Successfu11y Updated");

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Delete from AccountTbl where ACTc = @id", Con);
            cmd.Parameters.AddWithValue("@id", TcTb.Text);
            cmd.ExecuteNonQuery();
            showData("select * from AccountTbl");

            Con.Close();
            Reset();

            MessageBox.Show("Successfu11y Deleted");
        }

        private void Search_Click(object sender, EventArgs e)
        {
            showData("select * from AccountTbl where ACName like '%" + NameTb.Text + "%'");
        }
    }
}
