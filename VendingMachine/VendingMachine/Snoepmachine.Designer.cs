﻿namespace VendingMachine
{
    partial class Snoepmachine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Snoepmachine));
            this.button19 = new System.Windows.Forms.Button();
            this.buttonOpwaarderenSaldo = new System.Windows.Forms.Button();
            this.labelSaldoUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlProduct = new System.Windows.Forms.FlowLayoutPanel();
            this.button16 = new System.Windows.Forms.Button();
            this.textBoxNummer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelWisselgeldUser = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.uNummerPad2 = new VendingMachine.uNummerPad();
            this.uNummerPad1 = new VendingMachine.uNummerPad();
            this.SuspendLayout();
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button19.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button19.FlatAppearance.BorderSize = 60;
            this.button19.Location = new System.Drawing.Point(33, 300);
            this.button19.Margin = new System.Windows.Forms.Padding(2);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(176, 47);
            this.button19.TabIndex = 56;
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.Button19_Click);
            // 
            // buttonOpwaarderenSaldo
            // 
            this.buttonOpwaarderenSaldo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonOpwaarderenSaldo.BackgroundImage")));
            this.buttonOpwaarderenSaldo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonOpwaarderenSaldo.Location = new System.Drawing.Point(304, 330);
            this.buttonOpwaarderenSaldo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOpwaarderenSaldo.Name = "buttonOpwaarderenSaldo";
            this.buttonOpwaarderenSaldo.Size = new System.Drawing.Size(58, 59);
            this.buttonOpwaarderenSaldo.TabIndex = 55;
            this.buttonOpwaarderenSaldo.UseVisualStyleBackColor = true;
            this.buttonOpwaarderenSaldo.Click += new System.EventHandler(this.ButtonOpwaarderenSaldo_Click);
            // 
            // labelSaldoUser
            // 
            this.labelSaldoUser.AutoSize = true;
            this.labelSaldoUser.BackColor = System.Drawing.Color.White;
            this.labelSaldoUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSaldoUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaldoUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelSaldoUser.Location = new System.Drawing.Point(268, 11);
            this.labelSaldoUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSaldoUser.Name = "labelSaldoUser";
            this.labelSaldoUser.Size = new System.Drawing.Size(2, 19);
            this.labelSaldoUser.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(74, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 36;
            this.label1.Text = "Snoepautomaat";
            // 
            // pnlProduct
            // 
            this.pnlProduct.Location = new System.Drawing.Point(33, 41);
            this.pnlProduct.Margin = new System.Windows.Forms.Padding(2);
            this.pnlProduct.Name = "pnlProduct";
            this.pnlProduct.Size = new System.Drawing.Size(159, 245);
            this.pnlProduct.TabIndex = 57;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(225, 266);
            this.button16.Margin = new System.Windows.Forms.Padding(2);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(111, 20);
            this.button16.TabIndex = 55;
            this.button16.Text = "Koop";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.Button16_Click_1);
            // 
            // textBoxNummer
            // 
            this.textBoxNummer.Location = new System.Drawing.Point(218, 33);
            this.textBoxNummer.Name = "textBoxNummer";
            this.textBoxNummer.Size = new System.Drawing.Size(126, 20);
            this.textBoxNummer.TabIndex = 60;
            this.textBoxNummer.Enter += new System.EventHandler(this.textBoxNummer_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(203, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 61;
            this.label2.Text = "Saldo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(16, 358);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 19);
            this.label3.TabIndex = 62;
            this.label3.Text = "Wisselgeld €";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(203, 349);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 27);
            this.button1.TabIndex = 64;
            this.button1.Text = "Wisselgeld";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // labelWisselgeldUser
            // 
            this.labelWisselgeldUser.AutoSize = true;
            this.labelWisselgeldUser.BackColor = System.Drawing.Color.White;
            this.labelWisselgeldUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelWisselgeldUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWisselgeldUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelWisselgeldUser.Location = new System.Drawing.Point(128, 358);
            this.labelWisselgeldUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWisselgeldUser.Name = "labelWisselgeldUser";
            this.labelWisselgeldUser.Size = new System.Drawing.Size(24, 19);
            this.labelWisselgeldUser.TabIndex = 63;
            this.labelWisselgeldUser.Text = " 0";
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(9, 2);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 37);
            this.button2.TabIndex = 65;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // uNummerPad2
            // 
            this.uNummerPad2.Location = new System.Drawing.Point(214, 58);
            this.uNummerPad2.Margin = new System.Windows.Forms.Padding(4);
            this.uNummerPad2.Name = "uNummerPad2";
            this.uNummerPad2.Size = new System.Drawing.Size(129, 258);
            this.uNummerPad2.TabIndex = 64;
            // 
            // uNummerPad1
            // 
            this.uNummerPad1.Location = new System.Drawing.Point(210, 86);
            this.uNummerPad1.Margin = new System.Windows.Forms.Padding(4);
            this.uNummerPad1.Name = "uNummerPad1";
            this.uNummerPad1.Size = new System.Drawing.Size(198, 258);
            this.uNummerPad1.TabIndex = 59;
            // 
            // Snoepmachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(373, 398);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.labelWisselgeldUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNummer);
            this.Controls.Add(this.pnlProduct);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.buttonOpwaarderenSaldo);
            this.Controls.Add(this.labelSaldoUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uNummerPad2);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Snoepmachine";
            this.Text = "Snoepmachine";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button buttonOpwaarderenSaldo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel pnlProduct;
        private uNummerPad uNummerPad1;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.TextBox textBoxNummer;
        public System.Windows.Forms.Label labelSaldoUser;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;

        public System.Windows.Forms.Label labelWisselgeldUser;
        private uNummerPad uNummerPad2;
        private System.Windows.Forms.Button button2;
    }
}

