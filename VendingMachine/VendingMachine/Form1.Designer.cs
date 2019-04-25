namespace VendingMachine
{
    partial class Form1
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
            this.button19 = new System.Windows.Forms.Button();
            this.buttonOpwaarderenSaldo = new System.Windows.Forms.Button();
            this.labelSaldoUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlProduct = new System.Windows.Forms.FlowLayoutPanel();
            this.button20 = new System.Windows.Forms.Button();
            this.uNummerPad1 = new VendingMachine.uNummerPad();
            this.button16 = new System.Windows.Forms.Button();
            this.textBoxNummer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button19.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button19.FlatAppearance.BorderSize = 60;
            this.button19.Location = new System.Drawing.Point(16, 297);
            this.button19.Margin = new System.Windows.Forms.Padding(2);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(146, 47);
            this.button19.TabIndex = 56;
            this.button19.UseVisualStyleBackColor = false;
            // 
            // buttonOpwaarderenSaldo
            // 
            this.buttonOpwaarderenSaldo.Location = new System.Drawing.Point(271, 392);
            this.buttonOpwaarderenSaldo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOpwaarderenSaldo.Name = "buttonOpwaarderenSaldo";
            this.buttonOpwaarderenSaldo.Size = new System.Drawing.Size(128, 20);
            this.buttonOpwaarderenSaldo.TabIndex = 55;
            this.buttonOpwaarderenSaldo.Text = "Saldo opwaarderen";
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
            this.labelSaldoUser.Location = new System.Drawing.Point(249, 11);
            this.labelSaldoUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSaldoUser.Name = "labelSaldoUser";
            this.labelSaldoUser.Size = new System.Drawing.Size(24, 19);
            this.labelSaldoUser.TabIndex = 37;
            this.labelSaldoUser.Text = " 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(52, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 36;
            this.label1.Text = "Snoepautomaat";
            // 
            // pnlProduct
            // 
            this.pnlProduct.Location = new System.Drawing.Point(16, 33);
            this.pnlProduct.Margin = new System.Windows.Forms.Padding(2);
            this.pnlProduct.Name = "pnlProduct";
            this.pnlProduct.Size = new System.Drawing.Size(159, 245);
            this.pnlProduct.TabIndex = 57;
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(52, 375);
            this.button20.Margin = new System.Windows.Forms.Padding(2);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(70, 37);
            this.button20.TabIndex = 58;
            this.button20.Text = "Beheerder";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // uNummerPad1
            // 
            this.uNummerPad1.Location = new System.Drawing.Point(210, 86);
            this.uNummerPad1.Name = "uNummerPad1";
            this.uNummerPad1.Size = new System.Drawing.Size(198, 258);
            this.uNummerPad1.TabIndex = 59;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(271, 297);
            this.button16.Margin = new System.Windows.Forms.Padding(2);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(109, 20);
            this.button16.TabIndex = 55;
            this.button16.Text = "Enter";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // textBoxNummer
            // 
            this.textBoxNummer.Location = new System.Drawing.Point(262, 60);
            this.textBoxNummer.Name = "textBoxNummer";
            this.textBoxNummer.Size = new System.Drawing.Size(137, 20);
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
            this.label2.Location = new System.Drawing.Point(189, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 61;
            this.label2.Text = "Saldo ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(16, 487);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 19);
            this.label3.TabIndex = 62;
            this.label3.Text = "Wisselgeld";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(112, 487);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 19);
            this.label4.TabIndex = 63;
            this.label4.Text = " 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 540);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNummer);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.uNummerPad1);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.pnlProduct);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.buttonOpwaarderenSaldo);
            this.Controls.Add(this.labelSaldoUser);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button buttonOpwaarderenSaldo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel pnlProduct;
        private System.Windows.Forms.Button button20;
        private uNummerPad uNummerPad1;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.TextBox textBoxNummer;
        public System.Windows.Forms.Label labelSaldoUser;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
    }
}

