
namespace CanerProjeOdev
{
    partial class emanet_ara
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(emanet_ara));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.emanetnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uyenoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapteslimtarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapalınacaktarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emanetkitaplarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kutuphaneodevDataSet11 = new CanerProjeOdev.KutuphaneodevDataSet11();
            this.emanet_kitaplarTableAdapter = new CanerProjeOdev.KutuphaneodevDataSet11TableAdapters.emanet_kitaplarTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kitapNoİleAraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üyeNoİleAraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapTeslimTarihiİleAraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapAlıncakTarihİleAraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.gecikenEmanetleriListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emanetkitaplarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneodevDataSet11)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSlateGray;
            this.button2.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(274, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(226, 55);
            this.button2.TabIndex = 35;
            this.button2.Text = "EMANET KİTAPLARIN HEPSİNİ GETİR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSlateGray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(529, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 65);
            this.button1.TabIndex = 34;
            this.button1.Text = "ÇIKIŞ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.emanetnoDataGridViewTextBoxColumn,
            this.kitapnoDataGridViewTextBoxColumn,
            this.uyenoDataGridViewTextBoxColumn,
            this.kitapteslimtarihiDataGridViewTextBoxColumn,
            this.kitapalınacaktarihDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.emanetkitaplarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(569, 260);
            this.dataGridView1.TabIndex = 33;
            // 
            // emanetnoDataGridViewTextBoxColumn
            // 
            this.emanetnoDataGridViewTextBoxColumn.DataPropertyName = "emanetno";
            this.emanetnoDataGridViewTextBoxColumn.HeaderText = "Emanet No";
            this.emanetnoDataGridViewTextBoxColumn.Name = "emanetnoDataGridViewTextBoxColumn";
            this.emanetnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kitapnoDataGridViewTextBoxColumn
            // 
            this.kitapnoDataGridViewTextBoxColumn.DataPropertyName = "kitapno";
            this.kitapnoDataGridViewTextBoxColumn.HeaderText = "Kitap No";
            this.kitapnoDataGridViewTextBoxColumn.Name = "kitapnoDataGridViewTextBoxColumn";
            this.kitapnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uyenoDataGridViewTextBoxColumn
            // 
            this.uyenoDataGridViewTextBoxColumn.DataPropertyName = "uye_no";
            this.uyenoDataGridViewTextBoxColumn.HeaderText = "Üye No";
            this.uyenoDataGridViewTextBoxColumn.Name = "uyenoDataGridViewTextBoxColumn";
            this.uyenoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kitapteslimtarihiDataGridViewTextBoxColumn
            // 
            this.kitapteslimtarihiDataGridViewTextBoxColumn.DataPropertyName = "kitap_teslim_tarihi";
            this.kitapteslimtarihiDataGridViewTextBoxColumn.HeaderText = "Kitap Teslim Tarihi";
            this.kitapteslimtarihiDataGridViewTextBoxColumn.Name = "kitapteslimtarihiDataGridViewTextBoxColumn";
            this.kitapteslimtarihiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kitapalınacaktarihDataGridViewTextBoxColumn
            // 
            this.kitapalınacaktarihDataGridViewTextBoxColumn.DataPropertyName = "kitap_alınacak_tarih";
            this.kitapalınacaktarihDataGridViewTextBoxColumn.HeaderText = "Kitap Alınacak Tarih";
            this.kitapalınacaktarihDataGridViewTextBoxColumn.Name = "kitapalınacaktarihDataGridViewTextBoxColumn";
            this.kitapalınacaktarihDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emanetkitaplarBindingSource
            // 
            this.emanetkitaplarBindingSource.DataMember = "emanet_kitaplar";
            this.emanetkitaplarBindingSource.DataSource = this.kutuphaneodevDataSet11;
            // 
            // kutuphaneodevDataSet11
            // 
            this.kutuphaneodevDataSet11.DataSetName = "KutuphaneodevDataSet11";
            this.kutuphaneodevDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // emanet_kitaplarTableAdapter
            // 
            this.emanet_kitaplarTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(44, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Kitap No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(54, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Üye No :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(137, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 38;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(137, 65);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 39;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gray;
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitapNoİleAraToolStripMenuItem,
            this.üyeNoİleAraToolStripMenuItem,
            this.kitapTeslimTarihiİleAraToolStripMenuItem,
            this.kitapAlıncakTarihİleAraToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(650, 25);
            this.menuStrip1.TabIndex = 40;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kitapNoİleAraToolStripMenuItem
            // 
            this.kitapNoİleAraToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kitapNoİleAraToolStripMenuItem.Name = "kitapNoİleAraToolStripMenuItem";
            this.kitapNoİleAraToolStripMenuItem.Size = new System.Drawing.Size(125, 21);
            this.kitapNoİleAraToolStripMenuItem.Text = "Kitap No İle Ara";
            this.kitapNoİleAraToolStripMenuItem.Click += new System.EventHandler(this.kitapNoİleAraToolStripMenuItem_Click);
            // 
            // üyeNoİleAraToolStripMenuItem
            // 
            this.üyeNoİleAraToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.üyeNoİleAraToolStripMenuItem.Name = "üyeNoİleAraToolStripMenuItem";
            this.üyeNoİleAraToolStripMenuItem.Size = new System.Drawing.Size(115, 21);
            this.üyeNoİleAraToolStripMenuItem.Text = "Üye No İle Ara";
            this.üyeNoİleAraToolStripMenuItem.Click += new System.EventHandler(this.üyeNoİleAraToolStripMenuItem_Click);
            // 
            // kitapTeslimTarihiİleAraToolStripMenuItem
            // 
            this.kitapTeslimTarihiİleAraToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kitapTeslimTarihiİleAraToolStripMenuItem.Name = "kitapTeslimTarihiİleAraToolStripMenuItem";
            this.kitapTeslimTarihiİleAraToolStripMenuItem.Size = new System.Drawing.Size(187, 21);
            this.kitapTeslimTarihiİleAraToolStripMenuItem.Text = "Kitap Teslim Tarihi İle Ara";
            this.kitapTeslimTarihiİleAraToolStripMenuItem.Click += new System.EventHandler(this.kitapTeslimTarihiİleAraToolStripMenuItem_Click);
            // 
            // kitapAlıncakTarihİleAraToolStripMenuItem
            // 
            this.kitapAlıncakTarihİleAraToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kitapAlıncakTarihİleAraToolStripMenuItem.Name = "kitapAlıncakTarihİleAraToolStripMenuItem";
            this.kitapAlıncakTarihİleAraToolStripMenuItem.Size = new System.Drawing.Size(191, 21);
            this.kitapAlıncakTarihİleAraToolStripMenuItem.Text = "Kitap Alıncak Tarih İle Ara";
            this.kitapAlıncakTarihİleAraToolStripMenuItem.Click += new System.EventHandler(this.kitapAlıncakTarihİleAraToolStripMenuItem_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(137, 65);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 44;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(137, 65);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 43;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 42;
            this.label3.Text = "Teslim Tarihi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(9, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 41;
            this.label4.Text = "Alıncak Tarih :";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.menuStrip2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip2.BackgroundImage")));
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gecikenEmanetleriListeleToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 25);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(194, 25);
            this.menuStrip2.TabIndex = 45;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // gecikenEmanetleriListeleToolStripMenuItem
            // 
            this.gecikenEmanetleriListeleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.gecikenEmanetleriListeleToolStripMenuItem.Name = "gecikenEmanetleriListeleToolStripMenuItem";
            this.gecikenEmanetleriListeleToolStripMenuItem.Size = new System.Drawing.Size(186, 21);
            this.gecikenEmanetleriListeleToolStripMenuItem.Text = "Geciken Emanetleri Listele";
            this.gecikenEmanetleriListeleToolStripMenuItem.Click += new System.EventHandler(this.gecikenEmanetleriListeleToolStripMenuItem_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(575, 175);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 46;
            this.dateTimePicker1.Visible = false;
            // 
            // emanet_ara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(650, 378);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "emanet_ara";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "emanet_ara";
            this.Load += new System.EventHandler(this.emanet_ara_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emanetkitaplarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneodevDataSet11)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private KutuphaneodevDataSet11 kutuphaneodevDataSet11;
        private System.Windows.Forms.BindingSource emanetkitaplarBindingSource;
        private KutuphaneodevDataSet11TableAdapters.emanet_kitaplarTableAdapter emanet_kitaplarTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kitapNoİleAraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem üyeNoİleAraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapTeslimTarihiİleAraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapAlıncakTarihİleAraToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn emanetnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uyenoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapteslimtarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapalınacaktarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem gecikenEmanetleriListeleToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}