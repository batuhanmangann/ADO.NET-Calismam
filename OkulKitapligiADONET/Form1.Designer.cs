
namespace OkulKitapligiADONET
{
    partial class FormYazarlar
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtYazar = new System.Windows.Forms.TextBox();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.buttonTemizle = new System.Windows.Forms.Button();
            this.dataGridYazarlar = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.guncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silBaskaBirYontemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silPasifeCekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridYazarlar)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yazar Ad-Soyad:";
            // 
            // txtYazar
            // 
            this.txtYazar.Location = new System.Drawing.Point(131, 80);
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(331, 20);
            this.txtYazar.TabIndex = 1;
            // 
            // buttonEkle
            // 
            this.buttonEkle.Location = new System.Drawing.Point(493, 71);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(96, 37);
            this.buttonEkle.TabIndex = 2;
            this.buttonEkle.Text = "EKLE";
            this.buttonEkle.UseVisualStyleBackColor = true;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // buttonTemizle
            // 
            this.buttonTemizle.Location = new System.Drawing.Point(624, 71);
            this.buttonTemizle.Name = "buttonTemizle";
            this.buttonTemizle.Size = new System.Drawing.Size(96, 37);
            this.buttonTemizle.TabIndex = 3;
            this.buttonTemizle.Text = "TEMİZLE";
            this.buttonTemizle.UseVisualStyleBackColor = true;
            this.buttonTemizle.Click += new System.EventHandler(this.buttonTemizle_Click);
            // 
            // dataGridYazarlar
            // 
            this.dataGridYazarlar.AllowUserToAddRows = false;
            this.dataGridYazarlar.AllowUserToDeleteRows = false;
            this.dataGridYazarlar.AllowUserToOrderColumns = true;
            this.dataGridYazarlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridYazarlar.Location = new System.Drawing.Point(15, 122);
            this.dataGridYazarlar.Name = "dataGridYazarlar";
            this.dataGridYazarlar.ReadOnly = true;
            this.dataGridYazarlar.Size = new System.Drawing.Size(782, 264);
            this.dataGridYazarlar.TabIndex = 4;
            this.dataGridYazarlar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridYazarlar_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guncelleToolStripMenuItem,
            this.silToolStripMenuItem,
            this.silBaskaBirYontemToolStripMenuItem,
            this.silPasifeCekToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(183, 114);
            // 
            // guncelleToolStripMenuItem
            // 
            this.guncelleToolStripMenuItem.Name = "guncelleToolStripMenuItem";
            this.guncelleToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.guncelleToolStripMenuItem.Text = "Güncelle";
            this.guncelleToolStripMenuItem.Click += new System.EventHandler(this.guncelleToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // silBaskaBirYontemToolStripMenuItem
            // 
            this.silBaskaBirYontemToolStripMenuItem.Name = "silBaskaBirYontemToolStripMenuItem";
            this.silBaskaBirYontemToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.silBaskaBirYontemToolStripMenuItem.Text = "Sil-Başka bir yöntem";
            this.silBaskaBirYontemToolStripMenuItem.Click += new System.EventHandler(this.silBaskaBirYontemToolStripMenuItem_Click);
            // 
            // silPasifeCekToolStripMenuItem
            // 
            this.silPasifeCekToolStripMenuItem.Name = "silPasifeCekToolStripMenuItem";
            this.silPasifeCekToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.silPasifeCekToolStripMenuItem.Text = "Sil-Pasife çek";
            this.silPasifeCekToolStripMenuItem.Click += new System.EventHandler(this.silPasifeCekToolStripMenuItem_Click);
            // 
            // FormYazarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(821, 398);
            this.Controls.Add(this.dataGridYazarlar);
            this.Controls.Add(this.buttonTemizle);
            this.Controls.Add(this.buttonEkle);
            this.Controls.Add(this.txtYazar);
            this.Controls.Add(this.label1);
            this.Name = "FormYazarlar";
            this.Text = "Yazar İşlemleri";
            this.Load += new System.EventHandler(this.FormYazarlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridYazarlar)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYazar;
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.Button buttonTemizle;
        private System.Windows.Forms.DataGridView dataGridYazarlar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem guncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silBaskaBirYontemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silPasifeCekToolStripMenuItem;
    }
}

