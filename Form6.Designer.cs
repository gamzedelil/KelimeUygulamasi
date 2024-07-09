namespace DilOgrenmeUygulamasi
{
    partial class Form6
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDogru = new System.Windows.Forms.Label();
            this.lblYanlis = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Soru Sayısı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soru";
            // 
            // lblDogru
            // 
            this.lblDogru.AutoSize = true;
            this.lblDogru.Location = new System.Drawing.Point(31, 34);
            this.lblDogru.Name = "lblDogru";
            this.lblDogru.Size = new System.Drawing.Size(87, 16);
            this.lblDogru.TabIndex = 2;
            this.lblDogru.Text = "Doğru Sayısı:";
            // 
            // lblYanlis
            // 
            this.lblYanlis.AutoSize = true;
            this.lblYanlis.Location = new System.Drawing.Point(31, 81);
            this.lblYanlis.Name = "lblYanlis";
            this.lblYanlis.Size = new System.Drawing.Size(87, 16);
            this.lblYanlis.TabIndex = 3;
            this.lblYanlis.Text = "Yanlış Sayısı:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightPink;
            this.button1.Location = new System.Drawing.Point(190, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(312, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.DortButon);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightPink;
            this.button2.Location = new System.Drawing.Point(190, 144);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(312, 45);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.DortButon);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightPink;
            this.button3.Location = new System.Drawing.Point(190, 195);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(312, 45);
            this.button3.TabIndex = 6;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.DortButon);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightPink;
            this.button4.Location = new System.Drawing.Point(190, 245);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(312, 45);
            this.button4.TabIndex = 7;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.DortButon);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightPink;
            this.button5.Location = new System.Drawing.Point(249, 327);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(189, 63);
            this.button5.TabIndex = 8;
            this.button5.Text = "Başlat";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(895, 293);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblYanlis);
            this.panel2.Controls.Add(this.lblDogru);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(680, 293);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 228);
            this.panel2.TabIndex = 10;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(895, 521);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button5);
            this.Name = "Form6";
            this.Text = "Form6";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDogru;
        private System.Windows.Forms.Label lblYanlis;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}