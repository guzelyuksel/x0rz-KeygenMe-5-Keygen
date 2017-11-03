namespace KeygenMe5Keygen
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.SerialTxt = new System.Windows.Forms.TextBox();
            this.ÜretBtn = new System.Windows.Forms.Button();
            this.Otomatikİşlem = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // NameTxt
            // 
            this.NameTxt.Location = new System.Drawing.Point(12, 14);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(452, 22);
            this.NameTxt.TabIndex = 0;
            this.NameTxt.Text = "YuqseLx";
            this.NameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SerialTxt
            // 
            this.SerialTxt.Location = new System.Drawing.Point(12, 42);
            this.SerialTxt.Multiline = true;
            this.SerialTxt.Name = "SerialTxt";
            this.SerialTxt.Size = new System.Drawing.Size(452, 90);
            this.SerialTxt.TabIndex = 1;
            this.SerialTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ÜretBtn
            // 
            this.ÜretBtn.Location = new System.Drawing.Point(12, 138);
            this.ÜretBtn.Name = "ÜretBtn";
            this.ÜretBtn.Size = new System.Drawing.Size(452, 36);
            this.ÜretBtn.TabIndex = 2;
            this.ÜretBtn.Text = "Üret ve Kopyala";
            this.ÜretBtn.UseVisualStyleBackColor = true;
            this.ÜretBtn.Click += new System.EventHandler(this.ÜretBtn_Click);
            // 
            // Otomatikİşlem
            // 
            this.Otomatikİşlem.AutoSize = true;
            this.Otomatikİşlem.Checked = true;
            this.Otomatikİşlem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Otomatikİşlem.Location = new System.Drawing.Point(112, 180);
            this.Otomatikİşlem.Name = "Otomatikİşlem";
            this.Otomatikİşlem.Size = new System.Drawing.Size(242, 21);
            this.Otomatikİşlem.TabIndex = 3;
            this.Otomatikİşlem.Text = "Otomatik Doldur ve Kontrol Ettir :)";
            this.Otomatikİşlem.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 218);
            this.Controls.Add(this.Otomatikİşlem);
            this.Controls.Add(this.ÜretBtn);
            this.Controls.Add(this.SerialTxt);
            this.Controls.Add(this.NameTxt);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "x0rz KeygenMe #5 Keygen - YuqseLx";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.TextBox SerialTxt;
        private System.Windows.Forms.Button ÜretBtn;
        private System.Windows.Forms.CheckBox Otomatikİşlem;
    }
}

