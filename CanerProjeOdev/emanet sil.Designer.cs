
namespace CanerProjeOdev
{
    partial class emanet_sil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(emanet_sil));
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.emanetnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uyenoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapteslimtarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapalınacaktarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emanetkitaplarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kutuphaneodevDataSet8 = new CanerProjeOdev.KutuphaneodevDataSet8();
            this.emanet_kitaplarTableAdapter = new CanerProjeOdev.KutuphaneodevDataSet8TableAdapters.emanet_kitaplarTableAdapter();
            this.uyelerTableAdapter1 = new CanerProjeOdev.KutuphaneodevDataSet1TableAdapters.UyelerTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kİTAPADIİLEARAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kİTAPTÜRÜİLEARAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emanetkitaplarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneodevDataSet8)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSlateGray;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(441, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 59);
            this.button2.TabIndex = 9;
            this.button2.Text = "ÇIKIŞ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(98, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Üye No :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSlateGray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(219, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 59);
            this.button1.TabIndex = 6;
            this.button1.Text = "Sil";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
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
            this.dataGridView1.Location = new System.Drawing.Point(4, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(553, 273);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // 
            // uyenoDataGridViewTextBoxColumn
            // 
            this.uyenoDataGridViewTextBoxColumn.DataPropertyName = "uye_no";
            this.uyenoDataGridViewTextBoxColumn.HeaderText = "Üye No";
            this.uyenoDataGridViewTextBoxColumn.Name = "uyenoDataGridViewTextBoxColumn";
            // 
            // kitapteslimtarihiDataGridViewTextBoxColumn
            // 
            this.kitapteslimtarihiDataGridViewTextBoxColumn.DataPropertyName = "kitap_teslim_tarihi";
            this.kitapteslimtarihiDataGridViewTextBoxColumn.HeaderText = "Kitap Teslim Tarihi";
            this.kitapteslimtarihiDataGridViewTextBoxColumn.Name = "kitapteslimtarihiDataGridViewTextBoxColumn";
            // 
            // kitapalınacaktarihDataGridViewTextBoxColumn
            // 
            this.kitapalınacaktarihDataGridViewTextBoxColumn.DataPropertyName = "kitap_alınacak_tarih";
            this.kitapalınacaktarihDataGridViewTextBoxColumn.HeaderText = "Kitap Alıncak Tarih";
            this.kitapalınacaktarihDataGridViewTextBoxColumn.Name = "kitapalınacaktarihDataGridViewTextBoxColumn";
            // 
            // emanetkitaplarBindingSource
            // 
            this.emanetkitaplarBindingSource.DataMember = "emanet_kitaplar";
            this.emanetkitaplarBindingSource.DataSource = this.kutuphaneodevDataSet8;
            // 
            // kutuphaneodevDataSet8
            // 
            this.kutuphaneodevDataSet8.DataSetName = "KutuphaneodevDataSet8";
            this.kutuphaneodevDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // emanet_kitaplarTableAdapter
            // 
            this.emanet_kitaplarTableAdapter.ClearBeforeFill = true;
            // 
            // uyelerTableAdapter1
            // 
            this.uyelerTableAdapter1.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gray;
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kİTAPADIİLEARAToolStripMenuItem,
            this.kİTAPTÜRÜİLEARAToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(557, 25);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kİTAPADIİLEARAToolStripMenuItem
            // 
            this.kİTAPADIİLEARAToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kİTAPADIİLEARAToolStripMenuItem.Name = "kİTAPADIİLEARAToolStripMenuItem";
            this.kİTAPADIİLEARAToolStripMenuItem.Size = new System.Drawing.Size(142, 21);
            this.kİTAPADIİLEARAToolStripMenuItem.Text = "KİTAP NO İLE ARA";
            this.kİTAPADIİLEARAToolStripMenuItem.Click += new System.EventHandler(this.kİTAPADIİLEARAToolStripMenuItem_Click);
            // 
            // kİTAPTÜRÜİLEARAToolStripMenuItem
            // 
            this.kİTAPTÜRÜİLEARAToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kİTAPTÜRÜİLEARAToolStripMenuItem.Name = "kİTAPTÜRÜİLEARAToolStripMenuItem";
            this.kİTAPTÜRÜİLEARAToolStripMenuItem.Size = new System.Drawing.Size(126, 21);
            this.kİTAPTÜRÜİLEARAToolStripMenuItem.Text = "ÜYE NO İLE ARA";
            this.kİTAPTÜRÜİLEARAToolStripMenuItem.Click += new System.EventHandler(this.kİTAPTÜRÜİLEARAToolStripMenuItem_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(98, 72);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 13;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(5, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Kitap No :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(345, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(290, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "label4";
            // 
            // emanet_sil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(557, 408);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "emanet_sil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "emanet_sil";
            this.Load += new System.EventHandler(this.emanet_sil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emanetkitaplarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneodevDataSet8)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private KutuphaneodevDataSet8 kutuphaneodevDataSet8;
        private System.Windows.Forms.BindingSource emanetkitaplarBindingSource;
        private KutuphaneodevDataSet8TableAdapters.emanet_kitaplarTableAdapter emanet_kitaplarTableAdapter;
        private KutuphaneodevDataSet1TableAdapters.UyelerTableAdapter uyelerTableAdapter1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kİTAPADIİLEARAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kİTAPTÜRÜİLEARAToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn emanetnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uyenoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapteslimtarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapalınacaktarihDataGridViewTextBoxColumn;
    }
}