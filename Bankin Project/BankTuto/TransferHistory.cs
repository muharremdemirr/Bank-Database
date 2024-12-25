using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankTuto
{
    class TransferHistory : Form
    {
        public TransferHistory()
        {
            InitializeComponent();
            showData("select * from TransferTbl ");
        }

        private PictureBox pictureBox6;
        private DataGridView dataGridView1;
        private Panel panel1;
        private BankDbDataSet3 bankDbDataSet3;
        private BindingSource transferTblBindingSource;
        private System.ComponentModel.IContainer components;
        private BankDbDataSet3TableAdapters.TransferTblTableAdapter transferTblTableAdapter;
        private DataGridViewTextBoxColumn trIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn trSrcDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn trDestDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn trAmtDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn trDateDataGridViewTextBoxColumn;
        private PictureBox pictureBox1;
        private TextBox SourceTb;
        private TextBox DestinationTb;
        private Label label3;
        private Label label1;
        private Button Search;
        private PictureBox pictureBox2;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransferHistory));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.trIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trSrcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trDestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trAmtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transferTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankDbDataSet3 = new BankTuto.BankDbDataSet3();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.transferTblTableAdapter = new BankTuto.BankDbDataSet3TableAdapters.TransferTblTableAdapter();
            this.SourceTb = new System.Windows.Forms.TextBox();
            this.DestinationTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transferTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDbDataSet3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(779, 13);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(763, 90);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(41, 32);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 31;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.trIdDataGridViewTextBoxColumn,
            this.trSrcDataGridViewTextBoxColumn,
            this.trDestDataGridViewTextBoxColumn,
            this.trAmtDataGridViewTextBoxColumn,
            this.trDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.transferTblBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(50, 129);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(765, 397);
            this.dataGridView1.TabIndex = 32;
            // 
            // trIdDataGridViewTextBoxColumn
            // 
            this.trIdDataGridViewTextBoxColumn.DataPropertyName = "TrId";
            this.trIdDataGridViewTextBoxColumn.HeaderText = "TrId";
            this.trIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.trIdDataGridViewTextBoxColumn.Name = "trIdDataGridViewTextBoxColumn";
            this.trIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.trIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // trSrcDataGridViewTextBoxColumn
            // 
            this.trSrcDataGridViewTextBoxColumn.DataPropertyName = "TrSrc";
            this.trSrcDataGridViewTextBoxColumn.HeaderText = "TrSrc";
            this.trSrcDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.trSrcDataGridViewTextBoxColumn.Name = "trSrcDataGridViewTextBoxColumn";
            this.trSrcDataGridViewTextBoxColumn.Width = 125;
            // 
            // trDestDataGridViewTextBoxColumn
            // 
            this.trDestDataGridViewTextBoxColumn.DataPropertyName = "TrDest";
            this.trDestDataGridViewTextBoxColumn.HeaderText = "TrDest";
            this.trDestDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.trDestDataGridViewTextBoxColumn.Name = "trDestDataGridViewTextBoxColumn";
            this.trDestDataGridViewTextBoxColumn.Width = 125;
            // 
            // trAmtDataGridViewTextBoxColumn
            // 
            this.trAmtDataGridViewTextBoxColumn.DataPropertyName = "TrAmt";
            this.trAmtDataGridViewTextBoxColumn.HeaderText = "TrAmt";
            this.trAmtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.trAmtDataGridViewTextBoxColumn.Name = "trAmtDataGridViewTextBoxColumn";
            this.trAmtDataGridViewTextBoxColumn.Width = 125;
            // 
            // trDateDataGridViewTextBoxColumn
            // 
            this.trDateDataGridViewTextBoxColumn.DataPropertyName = "TrDate";
            this.trDateDataGridViewTextBoxColumn.HeaderText = "TrDate";
            this.trDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.trDateDataGridViewTextBoxColumn.Name = "trDateDataGridViewTextBoxColumn";
            this.trDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // transferTblBindingSource
            // 
            this.transferTblBindingSource.DataMember = "TransferTbl";
            this.transferTblBindingSource.DataSource = this.bankDbDataSet3;
            // 
            // bankDbDataSet3
            // 
            this.bankDbDataSet3.DataSetName = "BankDbDataSet3";
            this.bankDbDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-7, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(51, 542);
            this.panel1.TabIndex = 33;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 64;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // transferTblTableAdapter
            // 
            this.transferTblTableAdapter.ClearBeforeFill = true;
            // 
            // SourceTb
            // 
            this.SourceTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SourceTb.Location = new System.Drawing.Point(249, 13);
            this.SourceTb.Margin = new System.Windows.Forms.Padding(4);
            this.SourceTb.Name = "SourceTb";
            this.SourceTb.Size = new System.Drawing.Size(219, 34);
            this.SourceTb.TabIndex = 65;
            // 
            // DestinationTb
            // 
            this.DestinationTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DestinationTb.Location = new System.Drawing.Point(249, 55);
            this.DestinationTb.Margin = new System.Windows.Forms.Padding(4);
            this.DestinationTb.Name = "DestinationTb";
            this.DestinationTb.Size = new System.Drawing.Size(219, 34);
            this.DestinationTb.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(100, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 29);
            this.label3.TabIndex = 67;
            this.label3.Text = "Source";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(100, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 29);
            this.label1.TabIndex = 68;
            this.label1.Text = "Destination";
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.Purple;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Search.ForeColor = System.Drawing.Color.White;
            this.Search.Location = new System.Drawing.Point(534, 35);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(119, 39);
            this.Search.TabIndex = 69;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // TransferHistory
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(817, 529);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SourceTb);
            this.Controls.Add(this.DestinationTb);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TransferHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Class1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transferTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDbDataSet3)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Class1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankDbDataSet3.TransferTbl' table. You can move, or remove it, as needed.
            this.transferTblTableAdapter.Fill(this.bankDbDataSet3.TransferTbl);

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
            AccountNew Obj = new AccountNew();
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

        private void Search_Click(object sender, EventArgs e)
        {
            if(SourceTb.Text != "")
                showData("select * from TransferTbl where TrSrc=" + SourceTb.Text);
            else if(DestinationTb.Text != "")
                showData("select * from TransferTbl where TrDest=" + DestinationTb.Text);
            DestinationTb.Clear();
            SourceTb.Clear();

        }
    }
}
