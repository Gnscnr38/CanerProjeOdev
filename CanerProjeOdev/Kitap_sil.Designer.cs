
namespace CanerProjeOdev
{
    partial class Kitap_sil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kitap_sil));
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kitaplarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kutuphaneodevDataSet3 = new CanerProjeOdev.KutuphaneodevDataSet3();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kİTAPADIİLEARAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kİTAPTÜRÜİLEARAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kİTAPTÜRÜİLEARAToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.yAYİNEVİİLEARAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.kitaplarTableAdapter = new CanerProjeOdev.KutuphaneodevDataSet3TableAdapters.kitaplarTableAdapter();
            this.kitapNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapyazariDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapturuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yayıneviDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stoksayısıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneodevDataSet3)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSlateGray;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(507, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 59);
            this.button2.TabIndex = 9;
            this.button2.Text = "ÇIKIŞ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(147, 68);
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
            this.label1.Location = new System.Drawing.Point(37, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kitap Adı :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSlateGray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(300, 44);
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
            this.kitapNoDataGridViewTextBoxColumn,
            this.kitapadiDataGridViewTextBoxColumn,
            this.kitapyazariDataGridViewTextBoxColumn,
            this.kitapturuDataGridViewTextBoxColumn,
            this.yayıneviDataGridViewTextBoxColumn,
            this.stoksayısıDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kitaplarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 273);
            this.dataGridView1.TabIndex = 5;
            // 
            // kitaplarBindingSource
            // 
            this.kitaplarBindingSource.DataMember = "kitaplar";
            this.kitaplarBindingSource.DataSource = this.kutuphaneodevDataSet3;
            // 
            // kutuphaneodevDataSet3
            // 
            this.kutuphaneodevDataSet3.DataSetName = "KutuphaneodevDataSet3";
            this.kutuphaneodevDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gray;
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kİTAPADIİLEARAToolStripMenuItem,
            this.kİTAPTÜRÜİLEARAToolStripMenuItem,
            this.kİTAPTÜRÜİLEARAToolStripMenuItem1,
            this.yAYİNEVİİLEARAToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(644, 25);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kİTAPADIİLEARAToolStripMenuItem
            // 
            this.kİTAPADIİLEARAToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kİTAPADIİLEARAToolStripMenuItem.Name = "kİTAPADIİLEARAToolStripMenuItem";
            this.kİTAPADIİLEARAToolStripMenuItem.Size = new System.Drawing.Size(146, 21);
            this.kİTAPADIİLEARAToolStripMenuItem.Text = "KİTAP ADI İLE ARA";
            this.kİTAPADIİLEARAToolStripMenuItem.Click += new System.EventHandler(this.kİTAPADIİLEARAToolStripMenuItem_Click);
            // 
            // kİTAPTÜRÜİLEARAToolStripMenuItem
            // 
            this.kİTAPTÜRÜİLEARAToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kİTAPTÜRÜİLEARAToolStripMenuItem.Name = "kİTAPTÜRÜİLEARAToolStripMenuItem";
            this.kİTAPTÜRÜİLEARAToolStripMenuItem.Size = new System.Drawing.Size(171, 21);
            this.kİTAPTÜRÜİLEARAToolStripMenuItem.Text = "KİTAP YAZARI İLE ARA";
            this.kİTAPTÜRÜİLEARAToolStripMenuItem.Click += new System.EventHandler(this.kİTAPTÜRÜİLEARAToolStripMenuItem_Click);
            // 
            // kİTAPTÜRÜİLEARAToolStripMenuItem1
            // 
            this.kİTAPTÜRÜİLEARAToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kİTAPTÜRÜİLEARAToolStripMenuItem1.Name = "kİTAPTÜRÜİLEARAToolStripMenuItem1";
            this.kİTAPTÜRÜİLEARAToolStripMenuItem1.Size = new System.Drawing.Size(158, 21);
            this.kİTAPTÜRÜİLEARAToolStripMenuItem1.Text = "KİTAP TÜRÜ İLE ARA";
            this.kİTAPTÜRÜİLEARAToolStripMenuItem1.Click += new System.EventHandler(this.kİTAPTÜRÜİLEARAToolStripMenuItem1_Click);
            // 
            // yAYİNEVİİLEARAToolStripMenuItem
            // 
            this.yAYİNEVİİLEARAToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yAYİNEVİİLEARAToolStripMenuItem.Name = "yAYİNEVİİLEARAToolStripMenuItem";
            this.yAYİNEVİİLEARAToolStripMenuItem.Size = new System.Drawing.Size(143, 21);
            this.yAYİNEVİİLEARAToolStripMenuItem.Text = "YAYİN EVİ İLE ARA";
            this.yAYİNEVİİLEARAToolStripMenuItem.Click += new System.EventHandler(this.yAYİNEVİİLEARAToolStripMenuItem_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(147, 68);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 12;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Kitap Yazarı :";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(147, 68);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 14;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(27, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Kitap Türü :";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(147, 68);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 16;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(36, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Yayın Evi :";
            // 
            // kitaplarTableAdapter
            // 
            this.kitaplarTableAdapter.ClearBeforeFill = true;
            // 
            // kitapNoDataGridViewTextBoxColumn
            // 
            this.kitapNoDataGridViewTextBoxColumn.DataPropertyName = "Kitap_No";
            this.kitapNoDataGridViewTextBoxColumn.HeaderText = "Kitap No";
            this.kitapNoDataGridViewTextBoxColumn.Name = "kitapNoDataGridViewTextBoxColumn";
            // 
            // kitapadiDataGridViewTextBoxColumn
            // 
            this.kitapadiDataGridViewTextBoxColumn.DataPropertyName = "Kitap_adi";
            this.kitapadiDataGridViewTextBoxColumn.HeaderText = "Kitap Adı";
            this.kitapadiDataGridViewTextBoxColumn.Name = "kitapadiDataGridViewTextBoxColumn";
            // 
            // kitapyazariDataGridViewTextBoxColumn
            // 
            this.kitapyazariDataGridViewTextBoxColumn.DataPropertyName = "Kitap_yazari";
            this.kitapyazariDataGridViewTextBoxColumn.HeaderText = "Kitap Yazarı";
            this.kitapyazariDataGridViewTextBoxColumn.Name = "kitapyazariDataGridViewTextBoxColumn";
            // 
            // kitapturuDataGridViewTextBoxColumn
            // 
            this.kitapturuDataGridViewTextBoxColumn.DataPropertyName = "Kitap_turu";
            this.kitapturuDataGridViewTextBoxColumn.HeaderText = "Kitap Türü";
            this.kitapturuDataGridViewTextBoxColumn.Name = "kitapturuDataGridViewTextBoxColumn";
            // 
            // yayıneviDataGridViewTextBoxColumn
            // 
            this.yayıneviDataGridViewTextBoxColumn.DataPropertyName = "Yayın_evi";
            this.yayıneviDataGridViewTextBoxColumn.HeaderText = "Yayın Evi";
            this.yayıneviDataGridViewTextBoxColumn.Name = "yayıneviDataGridViewTextBoxColumn";
            // 
            // stoksayısıDataGridViewTextBoxColumn
            // 
            this.stoksayısıDataGridViewTextBoxColumn.DataPropertyName = "Stok_sayısı";
            this.stoksayısıDataGridViewTextBoxColumn.HeaderText = "Stok Sayısı";
            this.stoksayısıDataGridViewTextBoxColumn.Name = "stoksayısıDataGridViewTextBoxColumn";
            // 
            // Kitap_sil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(644, 382);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Kitap_sil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap_sil";
            this.Load += new System.EventHandler(this.Kitap_sil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneodevDataSet3)).EndInit();
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kİTAPADIİLEARAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kİTAPTÜRÜİLEARAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kİTAPTÜRÜİLEARAToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem yAYİNEVİİLEARAToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private KutuphaneodevDataSet3 kutuphaneodevDataSet3;
        private System.Windows.Forms.BindingSource kitaplarBindingSource;
        private KutuphaneodevDataSet3TableAdapters.kitaplarTableAdapter kitaplarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapyazariDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapturuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yayıneviDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stoksayısıDataGridViewTextBoxColumn;
    }
}