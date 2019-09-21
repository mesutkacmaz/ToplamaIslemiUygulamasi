namespace ToplamaIslemi
{
    partial class ToplamaForm
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
            this.btnTopla = new System.Windows.Forms.Button();
            this.lblBirinciSayi = new System.Windows.Forms.Label();
            this.lblIkinciSayi = new System.Windows.Forms.Label();
            this.txtBirinciSayi = new System.Windows.Forms.TextBox();
            this.txtIkinciSayi = new System.Windows.Forms.TextBox();
            this.tabGenel = new System.Windows.Forms.TabControl();
            this.tabToplama = new System.Windows.Forms.TabPage();
            this.btnIleri = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.txtSonuc = new System.Windows.Forms.TextBox();
            this.tabLoglama = new System.Windows.Forms.TabPage();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.lvLog = new System.Windows.Forms.ListView();
            this.tabGenel.SuspendLayout();
            this.tabToplama.SuspendLayout();
            this.tabLoglama.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTopla
            // 
            this.btnTopla.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTopla.Location = new System.Drawing.Point(88, 114);
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.Size = new System.Drawing.Size(100, 23);
            this.btnTopla.TabIndex = 3;
            this.btnTopla.Text = "TOPLA";
            this.btnTopla.UseVisualStyleBackColor = true;
            this.btnTopla.Click += new System.EventHandler(this.BtnTopla_Click);
            // 
            // lblBirinciSayi
            // 
            this.lblBirinciSayi.AutoSize = true;
            this.lblBirinciSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBirinciSayi.Location = new System.Drawing.Point(15, 24);
            this.lblBirinciSayi.Name = "lblBirinciSayi";
            this.lblBirinciSayi.Size = new System.Drawing.Size(73, 15);
            this.lblBirinciSayi.TabIndex = 1;
            this.lblBirinciSayi.Text = "Birinci Sayı :";
            // 
            // lblIkinciSayi
            // 
            this.lblIkinciSayi.AutoSize = true;
            this.lblIkinciSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIkinciSayi.Location = new System.Drawing.Point(15, 61);
            this.lblIkinciSayi.Name = "lblIkinciSayi";
            this.lblIkinciSayi.Size = new System.Drawing.Size(67, 15);
            this.lblIkinciSayi.TabIndex = 2;
            this.lblIkinciSayi.Text = "İkinci Sayı :";
            // 
            // txtBirinciSayi
            // 
            this.txtBirinciSayi.Location = new System.Drawing.Point(88, 23);
            this.txtBirinciSayi.Name = "txtBirinciSayi";
            this.txtBirinciSayi.ShortcutsEnabled = false;
            this.txtBirinciSayi.Size = new System.Drawing.Size(100, 20);
            this.txtBirinciSayi.TabIndex = 1;
            this.txtBirinciSayi.TextChanged += new System.EventHandler(this.TxtBirinciSayi_TextChanged);
            this.txtBirinciSayi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBirinciSayi_KeyPress);
            // 
            // txtIkinciSayi
            // 
            this.txtIkinciSayi.Location = new System.Drawing.Point(88, 60);
            this.txtIkinciSayi.Name = "txtIkinciSayi";
            this.txtIkinciSayi.ShortcutsEnabled = false;
            this.txtIkinciSayi.Size = new System.Drawing.Size(100, 20);
            this.txtIkinciSayi.TabIndex = 2;
            this.txtIkinciSayi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIkinciSayi_KeyPress);
            // 
            // tabGenel
            // 
            this.tabGenel.Controls.Add(this.tabToplama);
            this.tabGenel.Controls.Add(this.tabLoglama);
            this.tabGenel.Location = new System.Drawing.Point(4, 3);
            this.tabGenel.Name = "tabGenel";
            this.tabGenel.SelectedIndex = 0;
            this.tabGenel.Size = new System.Drawing.Size(288, 373);
            this.tabGenel.TabIndex = 5;
            // 
            // tabToplama
            // 
            this.tabToplama.Controls.Add(this.btnIleri);
            this.tabToplama.Controls.Add(this.lblSonuc);
            this.tabToplama.Controls.Add(this.txtSonuc);
            this.tabToplama.Controls.Add(this.txtBirinciSayi);
            this.tabToplama.Controls.Add(this.txtIkinciSayi);
            this.tabToplama.Controls.Add(this.btnTopla);
            this.tabToplama.Controls.Add(this.lblBirinciSayi);
            this.tabToplama.Controls.Add(this.lblIkinciSayi);
            this.tabToplama.Location = new System.Drawing.Point(4, 22);
            this.tabToplama.Name = "tabToplama";
            this.tabToplama.Padding = new System.Windows.Forms.Padding(3);
            this.tabToplama.Size = new System.Drawing.Size(280, 347);
            this.tabToplama.TabIndex = 0;
            this.tabToplama.Text = "Toplama";
            this.tabToplama.UseVisualStyleBackColor = true;
            // 
            // btnIleri
            // 
            this.btnIleri.Location = new System.Drawing.Point(88, 284);
            this.btnIleri.Name = "btnIleri";
            this.btnIleri.Size = new System.Drawing.Size(100, 23);
            this.btnIleri.TabIndex = 4;
            this.btnIleri.Text = "İleri >";
            this.btnIleri.UseVisualStyleBackColor = true;
            this.btnIleri.Click += new System.EventHandler(this.BtnIleri_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.Location = new System.Drawing.Point(15, 182);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(55, 15);
            this.lblSonuc.TabIndex = 6;
            this.lblSonuc.Text = "Sonuç :";
            // 
            // txtSonuc
            // 
            this.txtSonuc.Enabled = false;
            this.txtSonuc.Location = new System.Drawing.Point(88, 182);
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.Size = new System.Drawing.Size(100, 20);
            this.txtSonuc.TabIndex = 5;
            // 
            // tabLoglama
            // 
            this.tabLoglama.Controls.Add(this.btnTemizle);
            this.tabLoglama.Controls.Add(this.btnGeri);
            this.tabLoglama.Controls.Add(this.lvLog);
            this.tabLoglama.Location = new System.Drawing.Point(4, 22);
            this.tabLoglama.Name = "tabLoglama";
            this.tabLoglama.Padding = new System.Windows.Forms.Padding(3);
            this.tabLoglama.Size = new System.Drawing.Size(280, 347);
            this.tabLoglama.TabIndex = 1;
            this.tabLoglama.Text = "Loglama";
            this.tabLoglama.UseVisualStyleBackColor = true;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(177, 321);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 23);
            this.btnTemizle.TabIndex = 2;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(21, 321);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(75, 23);
            this.btnGeri.TabIndex = 1;
            this.btnGeri.Text = "< Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.BtnGeri_Click);
            // 
            // lvLog
            // 
            this.lvLog.HideSelection = false;
            this.lvLog.Location = new System.Drawing.Point(0, 0);
            this.lvLog.Name = "lvLog";
            this.lvLog.Size = new System.Drawing.Size(277, 315);
            this.lvLog.TabIndex = 0;
            this.lvLog.UseCompatibleStateImageBehavior = false;
            this.lvLog.View = System.Windows.Forms.View.List;
            // 
            // ToplamaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 388);
            this.Controls.Add(this.tabGenel);
            this.MaximizeBox = false;
            this.Name = "ToplamaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Toplama İşlemi";
            this.Shown += new System.EventHandler(this.ToplamaForm_Shown);
            this.tabGenel.ResumeLayout(false);
            this.tabToplama.ResumeLayout(false);
            this.tabToplama.PerformLayout();
            this.tabLoglama.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTopla;
        private System.Windows.Forms.Label lblBirinciSayi;
        private System.Windows.Forms.Label lblIkinciSayi;
        private System.Windows.Forms.TextBox txtBirinciSayi;
        private System.Windows.Forms.TextBox txtIkinciSayi;
        private System.Windows.Forms.TabControl tabGenel;
        private System.Windows.Forms.TabPage tabToplama;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.TextBox txtSonuc;
        private System.Windows.Forms.TabPage tabLoglama;
        private System.Windows.Forms.ListView lvLog;
        private System.Windows.Forms.Button btnIleri;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnTemizle;
    }
}

