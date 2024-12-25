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
    public partial class AgentNew : Form
    {
        private Label label3;
        private TextBox NameTb;
        private Label label1;
        private TextBox PassTb;
        private Label label2;
        private TextBox PhoneTb;
        private Label label4;
        private TextBox PosTb;
        private Label label5;
        private TextBox SurnameTb;
        private Label label6;
        private TextBox AddressTb;
        private Label label7;
        private PictureBox pictureBox2;
        private PictureBox pictureBox6;
        private Button Submit;
        private Button Edit;
        private Button Delete;
        private Button Search;
        private Panel panel1;
        private DataGridView dataGridView1;
        private BankDbDataSet bankDbDataSet;
        private BindingSource agentTblBindingSource;
        private System.ComponentModel.IContainer components;
        private BankDbDataSetTableAdapters.AgentTblTableAdapter agentTblTableAdapter;
        private DataGridViewTextBoxColumn aIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn aNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn aSurnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn aPhoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn aaddressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn aPositionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn aIdNoDataGridViewTextBoxColumn;
        private PictureBox pictureBox1;
        private TextBox TCTb;

        public AgentNew()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgentNew));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.NameTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PassTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PhoneTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PosTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SurnameTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TCTb = new System.Windows.Forms.TextBox();
            this.AddressTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.Submit = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.aIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aaddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aIdNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agentTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankDbDataSet = new BankTuto.BankDbDataSet();
            this.agentTblTableAdapter = new BankTuto.BankDbDataSetTableAdapters.AgentTblTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(69, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 29);
            this.label3.TabIndex = 36;
            this.label3.Text = "Name";
            // 
            // NameTb
            // 
            this.NameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTb.Location = new System.Drawing.Point(180, 64);
            this.NameTb.Margin = new System.Windows.Forms.Padding(4);
            this.NameTb.Name = "NameTb";
            this.NameTb.Size = new System.Drawing.Size(219, 34);
            this.NameTb.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(777, 141);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 29);
            this.label1.TabIndex = 38;
            this.label1.Text = "Position";
            // 
            // PassTb
            // 
            this.PassTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassTb.Location = new System.Drawing.Point(896, 67);
            this.PassTb.Margin = new System.Windows.Forms.Padding(4);
            this.PassTb.Name = "PassTb";
            this.PassTb.PasswordChar = '*';
            this.PassTb.Size = new System.Drawing.Size(219, 34);
            this.PassTb.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(416, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 29);
            this.label2.TabIndex = 40;
            this.label2.Text = "Phone";
            // 
            // PhoneTb
            // 
            this.PhoneTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneTb.Location = new System.Drawing.Point(538, 136);
            this.PhoneTb.Margin = new System.Windows.Forms.Padding(4);
            this.PhoneTb.Name = "PhoneTb";
            this.PhoneTb.Size = new System.Drawing.Size(219, 34);
            this.PhoneTb.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(69, 137);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 29);
            this.label4.TabIndex = 42;
            this.label4.Text = "TC Num";
            // 
            // PosTb
            // 
            this.PosTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PosTb.Location = new System.Drawing.Point(896, 136);
            this.PosTb.Margin = new System.Windows.Forms.Padding(4);
            this.PosTb.Name = "PosTb";
            this.PosTb.Size = new System.Drawing.Size(219, 34);
            this.PosTb.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(768, 70);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 29);
            this.label5.TabIndex = 44;
            this.label5.Text = "Password";
            // 
            // SurnameTb
            // 
            this.SurnameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurnameTb.Location = new System.Drawing.Point(538, 64);
            this.SurnameTb.Margin = new System.Windows.Forms.Padding(4);
            this.SurnameTb.Name = "SurnameTb";
            this.SurnameTb.Size = new System.Drawing.Size(219, 34);
            this.SurnameTb.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(416, 67);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 29);
            this.label6.TabIndex = 46;
            this.label6.Text = "Surname";
            // 
            // TCTb
            // 
            this.TCTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TCTb.Location = new System.Drawing.Point(180, 134);
            this.TCTb.Margin = new System.Windows.Forms.Padding(4);
            this.TCTb.Name = "TCTb";
            this.TCTb.Size = new System.Drawing.Size(219, 34);
            this.TCTb.TabIndex = 45;
            // 
            // AddressTb
            // 
            this.AddressTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressTb.Location = new System.Drawing.Point(180, 215);
            this.AddressTb.Margin = new System.Windows.Forms.Padding(4);
            this.AddressTb.Multiline = true;
            this.AddressTb.Name = "AddressTb";
            this.AddressTb.Size = new System.Drawing.Size(219, 116);
            this.AddressTb.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(69, 218);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 29);
            this.label7.TabIndex = 48;
            this.label7.Text = "Address";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1218, 13);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 49;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(1190, 259);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(56, 41);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 54;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.Color.Green;
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Submit.ForeColor = System.Drawing.Color.White;
            this.Submit.Location = new System.Drawing.Point(538, 259);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(131, 50);
            this.Submit.TabIndex = 55;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.Color.Navy;
            this.Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Edit.ForeColor = System.Drawing.Color.White;
            this.Edit.Location = new System.Drawing.Point(695, 259);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(131, 50);
            this.Edit.TabIndex = 56;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = false;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.DarkRed;
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Delete.ForeColor = System.Drawing.Color.White;
            this.Delete.Location = new System.Drawing.Point(856, 259);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(131, 50);
            this.Delete.TabIndex = 57;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.Purple;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Search.ForeColor = System.Drawing.Color.White;
            this.Search.Location = new System.Drawing.Point(1009, 259);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(131, 50);
            this.Search.TabIndex = 58;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-35, -17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(97, 673);
            this.panel1.TabIndex = 59;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(48, 30);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 64;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 25;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aIdDataGridViewTextBoxColumn,
            this.aNameDataGridViewTextBoxColumn,
            this.aSurnameDataGridViewTextBoxColumn,
            this.aPhoneDataGridViewTextBoxColumn,
            this.aaddressDataGridViewTextBoxColumn,
            this.aPositionDataGridViewTextBoxColumn,
            this.aIdNoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.agentTblBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(68, 338);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1191, 318);
            this.dataGridView1.TabIndex = 60;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // aIdDataGridViewTextBoxColumn
            // 
            this.aIdDataGridViewTextBoxColumn.DataPropertyName = "AId";
            this.aIdDataGridViewTextBoxColumn.HeaderText = "AId";
            this.aIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aIdDataGridViewTextBoxColumn.Name = "aIdDataGridViewTextBoxColumn";
            this.aIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aNameDataGridViewTextBoxColumn
            // 
            this.aNameDataGridViewTextBoxColumn.DataPropertyName = "AName";
            this.aNameDataGridViewTextBoxColumn.HeaderText = "AName";
            this.aNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aNameDataGridViewTextBoxColumn.Name = "aNameDataGridViewTextBoxColumn";
            // 
            // aSurnameDataGridViewTextBoxColumn
            // 
            this.aSurnameDataGridViewTextBoxColumn.DataPropertyName = "ASurname";
            this.aSurnameDataGridViewTextBoxColumn.HeaderText = "ASurname";
            this.aSurnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aSurnameDataGridViewTextBoxColumn.Name = "aSurnameDataGridViewTextBoxColumn";
            // 
            // aPhoneDataGridViewTextBoxColumn
            // 
            this.aPhoneDataGridViewTextBoxColumn.DataPropertyName = "APhone";
            this.aPhoneDataGridViewTextBoxColumn.HeaderText = "APhone";
            this.aPhoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aPhoneDataGridViewTextBoxColumn.Name = "aPhoneDataGridViewTextBoxColumn";
            // 
            // aaddressDataGridViewTextBoxColumn
            // 
            this.aaddressDataGridViewTextBoxColumn.DataPropertyName = "Aaddress";
            this.aaddressDataGridViewTextBoxColumn.HeaderText = "Aaddress";
            this.aaddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aaddressDataGridViewTextBoxColumn.Name = "aaddressDataGridViewTextBoxColumn";
            // 
            // aPositionDataGridViewTextBoxColumn
            // 
            this.aPositionDataGridViewTextBoxColumn.DataPropertyName = "APosition";
            this.aPositionDataGridViewTextBoxColumn.HeaderText = "APosition";
            this.aPositionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aPositionDataGridViewTextBoxColumn.Name = "aPositionDataGridViewTextBoxColumn";
            // 
            // aIdNoDataGridViewTextBoxColumn
            // 
            this.aIdNoDataGridViewTextBoxColumn.DataPropertyName = "AIdNo";
            this.aIdNoDataGridViewTextBoxColumn.HeaderText = "AIdNo";
            this.aIdNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aIdNoDataGridViewTextBoxColumn.Name = "aIdNoDataGridViewTextBoxColumn";
            // 
            // agentTblBindingSource
            // 
            this.agentTblBindingSource.DataMember = "AgentTbl";
            this.agentTblBindingSource.DataSource = this.bankDbDataSet;
            // 
            // bankDbDataSet
            // 
            this.bankDbDataSet.DataSetName = "BankDbDataSet";
            this.bankDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // agentTblTableAdapter
            // 
            this.agentTblTableAdapter.ClearBeforeFill = true;
            // 
            // AgentNew
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1259, 652);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AddressTb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TCTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SurnameTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PosTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PhoneTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PassTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NameTb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgentNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AgentNew_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void AgentNew_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankDbDataSet.AgentTbl' table. You can move, or remove it, as needed.
            this.agentTblTableAdapter.Fill(this.bankDbDataSet.AgentTbl);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MUHARREM\Desktop\BankTuto\BankTuto\BankDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void showData(string Data)
        {
            SqlDataAdapter da = new SqlDataAdapter(Data, Con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void Reset()
        {
            NameTb.Clear();
            SurnameTb.Clear();
            PhoneTb.Clear();
            PassTb.Clear();
            TCTb.Clear();
            AddressTb.Clear();
            PosTb.Clear();
            NameTb.Focus();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("insert into AgentTbl (AName, ASurname, APhone, APass, Aaddress, APosition, AIdNo) values (@Name, @Surname, @Phone,  @Pass, @address, @pos, @id)", Con);
            cmd.Parameters.AddWithValue("@Name", NameTb.Text);
            cmd.Parameters.AddWithValue("@Surname", SurnameTb.Text);
            cmd.Parameters.AddWithValue("@Phone", PhoneTb.Text);
            cmd.Parameters.AddWithValue("@Pass", PassTb.Text);
            cmd.Parameters.AddWithValue("@address", AddressTb.Text);
            cmd.Parameters.AddWithValue("@pos", PosTb.Text);
            cmd.Parameters.AddWithValue("@id", TCTb.Text);
            cmd.ExecuteNonQuery();
            showData("select * from AgentTbl");
            Con.Close();
            Reset();
            MessageBox.Show("Successfu11y Saved");

        }

        private void Search_Click(object sender, EventArgs e)
        {

            showData("select * from AgentTbl where AName like '%" + NameTb.Text + "%'");
            


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;
            string name = dataGridView1.Rows[selected].Cells[1].Value.ToString();
            string surname = dataGridView1.Rows[selected].Cells[2].Value.ToString();
            string phone = dataGridView1.Rows[selected].Cells[3].Value.ToString();
            string adres = dataGridView1.Rows[selected].Cells[4].Value.ToString();
            string position = dataGridView1.Rows[selected].Cells[5].Value.ToString();
            string tc = dataGridView1.Rows[selected].Cells[6].Value.ToString();

            NameTb.Text = name;
            SurnameTb.Text = surname;
            PhoneTb.Text = phone;
            AddressTb.Text = adres;
            PosTb.Text = position;
            TCTb.Text = tc;

            PassTb.Text = "****";
            
        }

        private void Edit_Click(object sender, EventArgs e)
        {

            Con.Open();
            SqlCommand cmd = new SqlCommand("update AgentTbl set AName ='" + NameTb.Text + "', ASurname ='" + SurnameTb.Text + "',APhone='" + PhoneTb.Text + "',Aaddress='" + AddressTb.Text + "',APosition='" + PosTb.Text + "',AIdNo='" + TCTb.Text + "',APass='" + PassTb.Text + "' where AIdNo =@id", Con);
            
            cmd.Parameters.AddWithValue("@id", TCTb.Text);
            cmd.ExecuteNonQuery();              
            
            
            showData("select * from AgentTbl");
            Con.Close();
            Reset();
            MessageBox.Show("Successfu11y Updated");
            
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Delete from AgentTbl where AIdNo = @id", Con);
            cmd.Parameters.AddWithValue("@id", TCTb.Text);
            cmd.ExecuteNonQuery();
            showData("select * from AgentTbl");

            Con.Close();
            Reset();

            MessageBox.Show("Successfu11y Deleted");


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Settings Obj = new Settings();
            Obj.Show();
            this.Hide();
        }
    }
}
