
namespace CanerProjeOdev
{
    partial class Uye_Sil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Uye_Sil));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.uyeNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tckimlikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uyeadıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uyeSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogumtarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogumyeriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.epostaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uyelikTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinsiyetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uyelerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kutuphaneodevDataSet = new CanerProjeOdev.KutuphaneodevDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.uyelerTableAdapter = new CanerProjeOdev.KutuphaneodevDataSetTableAdapters.UyelerTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyelerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneodevDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uyeNoDataGridViewTextBoxColumn,
            this.tckimlikDataGridViewTextBoxColumn,
            this.uyeadıDataGridViewTextBoxColumn,
            this.uyeSoyadDataGridViewTextBoxColumn,
            this.dogumtarihDataGridViewTextBoxColumn,
            this.dogumyeriDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.epostaDataGridViewTextBoxColumn,
            this.uyelikTarihDataGridViewTextBoxColumn,
            this.cinsiyetDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.uyelerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(783, 273);
            this.dataGridView1.TabIndex = 0;
            // 
            // uyeNoDataGridViewTextBoxColumn
            // 
            this.uyeNoDataGridViewTextBoxColumn.DataPropertyName = "Uye_No";
            this.uyeNoDataGridViewTextBoxColumn.HeaderText = "Üye No";
            this.uyeNoDataGridViewTextBoxColumn.Name = "uyeNoDataGridViewTextBoxColumn";
            this.uyeNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tckimlikDataGridViewTextBoxColumn
            // 
            this.tckimlikDataGridViewTextBoxColumn.DataPropertyName = "Tc_kimlik";
            this.tckimlikDataGridViewTextBoxColumn.HeaderText = "TC Kimlik";
            this.tckimlikDataGridViewTextBoxColumn.Name = "tckimlikDataGridViewTextBoxColumn";
            // 
            // uyeadıDataGridViewTextBoxColumn
            // 
            this.uyeadıDataGridViewTextBoxColumn.DataPropertyName = "Uye_adı";
            this.uyeadıDataGridViewTextBoxColumn.HeaderText = "Üye Adı";
            this.uyeadıDataGridViewTextBoxColumn.Name = "uyeadıDataGridViewTextBoxColumn";
            // 
            // uyeSoyadDataGridViewTextBoxColumn
            // 
            this.uyeSoyadDataGridViewTextBoxColumn.DataPropertyName = "Uye_Soyad";
            this.uyeSoyadDataGridViewTextBoxColumn.HeaderText = "Üye Soyad";
            this.uyeSoyadDataGridViewTextBoxColumn.Name = "uyeSoyadDataGridViewTextBoxColumn";
            // 
            // dogumtarihDataGridViewTextBoxColumn
            // 
            this.dogumtarihDataGridViewTextBoxColumn.DataPropertyName = "Dogum_tarih";
            this.dogumtarihDataGridViewTextBoxColumn.HeaderText = "Doğum Tarih";
            this.dogumtarihDataGridViewTextBoxColumn.Name = "dogumtarihDataGridViewTextBoxColumn";
            // 
            // dogumyeriDataGridViewTextBoxColumn
            // 
            this.dogumyeriDataGridViewTextBoxColumn.DataPropertyName = "Dogum_yeri";
            this.dogumyeriDataGridViewTextBoxColumn.HeaderText = "Doğum Yeri";
            this.dogumyeriDataGridViewTextBoxColumn.Name = "dogumyeriDataGridViewTextBoxColumn";
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            // 
            // epostaDataGridViewTextBoxColumn
            // 
            this.epostaDataGridViewTextBoxColumn.DataPropertyName = "E_posta";
            this.epostaDataGridViewTextBoxColumn.HeaderText = "E-Posta";
            this.epostaDataGridViewTextBoxColumn.Name = "epostaDataGridViewTextBoxColumn";
            // 
            // uyelikTarihDataGridViewTextBoxColumn
            // 
            this.uyelikTarihDataGridViewTextBoxColumn.DataPropertyName = "Uyelik_Tarih";
            this.uyelikTarihDataGridViewTextBoxColumn.HeaderText = "Üyelik Tarih";
            this.uyelikTarihDataGridViewTextBoxColumn.Name = "uyelikTarihDataGridViewTextBoxColumn";
            // 
            // cinsiyetDataGridViewTextBoxColumn
            // 
            this.cinsiyetDataGridViewTextBoxColumn.DataPropertyName = "Cinsiyet";
            this.cinsiyetDataGridViewTextBoxColumn.HeaderText = "Cinsiyet";
            this.cinsiyetDataGridViewTextBoxColumn.Name = "cinsiyetDataGridViewTextBoxColumn";
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "Adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "Adres";
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            // 
            // uyelerBindingSource
            // 
            this.uyelerBindingSource.DataMember = "Uyeler";
            this.uyelerBindingSource.DataSource = this.kutuphaneodevDataSet;
            // 
            // kutuphaneodevDataSet
            // 
            this.kutuphaneodevDataSet.DataSetName = "KutuphaneodevDataSet";
            this.kutuphaneodevDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSlateGray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(337, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 59);
            this.button1.TabIndex = 1;
            this.button1.Text = "Sil";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Üyenin TC Kimlik No :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(192, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // uyelerTableAdapter
            // 
            this.uyelerTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSlateGray;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(643, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 59);
            this.button2.TabIndex = 4;
            this.button2.Text = "ÇIKIŞ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Uye_Sil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(816, 402);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Uye_Sil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uye_Sil";
            this.Load += new System.EventHandler(this.Uye_Sil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyelerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneodevDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private KutuphaneodevDataSet kutuphaneodevDataSet;
        private System.Windows.Forms.BindingSource uyelerBindingSource;
        private KutuphaneodevDataSetTableAdapters.UyelerTableAdapter uyelerTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn uyeNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tckimlikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uyeadıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uyeSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogumtarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogumyeriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn epostaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uyelikTarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinsiyetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
    }
}