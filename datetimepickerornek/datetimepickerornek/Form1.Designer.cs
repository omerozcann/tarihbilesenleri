﻿namespace datetimepickerornek
{
    partial class datetimeFrm
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tarihbtn = new System.Windows.Forms.Button();
            this.guntxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.aytxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.yiltxt = new System.Windows.Forms.TextBox();
            this.tamtxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ayisimtxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gunisimtxt = new System.Windows.Forms.TextBox();
            this.tarihbtn2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(72, 37);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // tarihbtn
            // 
            this.tarihbtn.Location = new System.Drawing.Point(303, 26);
            this.tarihbtn.Name = "tarihbtn";
            this.tarihbtn.Size = new System.Drawing.Size(110, 48);
            this.tarihbtn.TabIndex = 1;
            this.tarihbtn.Text = "Tarih";
            this.tarihbtn.UseVisualStyleBackColor = true;
            this.tarihbtn.Click += new System.EventHandler(this.tarihbtn_Click);
            // 
            // guntxt
            // 
            this.guntxt.Location = new System.Drawing.Point(72, 133);
            this.guntxt.Name = "guntxt";
            this.guntxt.Size = new System.Drawing.Size(100, 22);
            this.guntxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gün";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ay";
            // 
            // aytxt
            // 
            this.aytxt.Location = new System.Drawing.Point(72, 189);
            this.aytxt.Name = "aytxt";
            this.aytxt.Size = new System.Drawing.Size(100, 22);
            this.aytxt.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Yıl";
            // 
            // yiltxt
            // 
            this.yiltxt.Location = new System.Drawing.Point(72, 245);
            this.yiltxt.Name = "yiltxt";
            this.yiltxt.Size = new System.Drawing.Size(100, 22);
            this.yiltxt.TabIndex = 6;
            // 
            // tamtxt
            // 
            this.tamtxt.Location = new System.Drawing.Point(72, 105);
            this.tamtxt.Name = "tamtxt";
            this.tamtxt.Size = new System.Drawing.Size(200, 22);
            this.tamtxt.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tam";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ay";
            // 
            // ayisimtxt
            // 
            this.ayisimtxt.Location = new System.Drawing.Point(72, 217);
            this.ayisimtxt.Name = "ayisimtxt";
            this.ayisimtxt.Size = new System.Drawing.Size(100, 22);
            this.ayisimtxt.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Gün";
            // 
            // gunisimtxt
            // 
            this.gunisimtxt.Location = new System.Drawing.Point(72, 161);
            this.gunisimtxt.Name = "gunisimtxt";
            this.gunisimtxt.Size = new System.Drawing.Size(100, 22);
            this.gunisimtxt.TabIndex = 12;
            // 
            // tarihbtn2
            // 
            this.tarihbtn2.Location = new System.Drawing.Point(303, 92);
            this.tarihbtn2.Name = "tarihbtn2";
            this.tarihbtn2.Size = new System.Drawing.Size(110, 48);
            this.tarihbtn2.TabIndex = 14;
            this.tarihbtn2.Text = "Tarih 2";
            this.tarihbtn2.UseVisualStyleBackColor = true;
            this.tarihbtn2.Click += new System.EventHandler(this.tarihbtn2_Click);
            // 
            // datetimeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 286);
            this.Controls.Add(this.tarihbtn2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gunisimtxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ayisimtxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tamtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.yiltxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.aytxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guntxt);
            this.Controls.Add(this.tarihbtn);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "datetimeFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DateTime";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button tarihbtn;
        private System.Windows.Forms.TextBox guntxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox aytxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox yiltxt;
        private System.Windows.Forms.TextBox tamtxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ayisimtxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox gunisimtxt;
        private System.Windows.Forms.Button tarihbtn2;
    }
}

