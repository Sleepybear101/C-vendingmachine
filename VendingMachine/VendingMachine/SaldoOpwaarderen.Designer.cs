﻿namespace VendingMachine
{
    partial class SaldoOpwaarderen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaldoOpwaarderen));
            this.button10Cent = new System.Windows.Forms.Button();
            this.button20Cent = new System.Windows.Forms.Button();
            this.button50Cent = new System.Windows.Forms.Button();
            this.button2Euro = new System.Windows.Forms.Button();
            this.button1Euro = new System.Windows.Forms.Button();
            this.textBoxSaldo = new System.Windows.Forms.TextBox();
            this.labelHuidigeSaldo = new System.Windows.Forms.Label();
            this.buttonOpwaarderen = new System.Windows.Forms.Button();
            this.labelCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button10Cent
            // 
            this.button10Cent.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button10Cent.ForeColor = System.Drawing.Color.Linen;
            this.button10Cent.Image = global::VendingMachine.Properties.Resources._10_cent;
            this.button10Cent.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button10Cent.Location = new System.Drawing.Point(8, 15);
            this.button10Cent.Name = "button10Cent";
            this.button10Cent.Size = new System.Drawing.Size(120, 110);
            this.button10Cent.TabIndex = 0;
            this.button10Cent.Text = "0,10";
            this.button10Cent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button10Cent.UseVisualStyleBackColor = false;
            this.button10Cent.Click += new System.EventHandler(this.button_Click);
            // 
            // button20Cent
            // 
            this.button20Cent.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button20Cent.ForeColor = System.Drawing.Color.Linen;
            this.button20Cent.Image = global::VendingMachine.Properties.Resources._20_cent;
            this.button20Cent.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button20Cent.Location = new System.Drawing.Point(131, 15);
            this.button20Cent.Name = "button20Cent";
            this.button20Cent.Size = new System.Drawing.Size(117, 110);
            this.button20Cent.TabIndex = 1;
            this.button20Cent.Text = "0,20";
            this.button20Cent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button20Cent.UseVisualStyleBackColor = false;
            this.button20Cent.Click += new System.EventHandler(this.button_Click);
            // 
            // button50Cent
            // 
            this.button50Cent.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button50Cent.ForeColor = System.Drawing.Color.Linen;
            this.button50Cent.Image = global::VendingMachine.Properties.Resources._50_cent;
            this.button50Cent.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button50Cent.Location = new System.Drawing.Point(254, 15);
            this.button50Cent.Name = "button50Cent";
            this.button50Cent.Size = new System.Drawing.Size(117, 110);
            this.button50Cent.TabIndex = 2;
            this.button50Cent.Text = "0,50";
            this.button50Cent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button50Cent.UseVisualStyleBackColor = false;
            this.button50Cent.Click += new System.EventHandler(this.button_Click);
            // 
            // button2Euro
            // 
            this.button2Euro.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2Euro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2Euro.ForeColor = System.Drawing.Color.Linen;
            this.button2Euro.Image = global::VendingMachine.Properties.Resources._2_euro;
            this.button2Euro.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2Euro.Location = new System.Drawing.Point(205, 128);
            this.button2Euro.Name = "button2Euro";
            this.button2Euro.Size = new System.Drawing.Size(117, 123);
            this.button2Euro.TabIndex = 3;
            this.button2Euro.Text = "2";
            this.button2Euro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2Euro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2Euro.UseVisualStyleBackColor = false;
            this.button2Euro.Click += new System.EventHandler(this.button_Click);
            // 
            // button1Euro
            // 
            this.button1Euro.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1Euro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1Euro.ForeColor = System.Drawing.Color.Linen;
            this.button1Euro.Image = global::VendingMachine.Properties.Resources._1_euro;
            this.button1Euro.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1Euro.Location = new System.Drawing.Point(70, 128);
            this.button1Euro.Name = "button1Euro";
            this.button1Euro.Size = new System.Drawing.Size(117, 110);
            this.button1Euro.TabIndex = 4;
            this.button1Euro.Text = "1";
            this.button1Euro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1Euro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1Euro.UseVisualStyleBackColor = false;
            this.button1Euro.Click += new System.EventHandler(this.button_Click);
            // 
            // textBoxSaldo
            // 
            this.textBoxSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSaldo.Location = new System.Drawing.Point(28, 275);
            this.textBoxSaldo.Name = "textBoxSaldo";
            this.textBoxSaldo.Size = new System.Drawing.Size(100, 45);
            this.textBoxSaldo.TabIndex = 8;
            this.textBoxSaldo.TextChanged += new System.EventHandler(this.TextBoxSaldo_TextChanged);
            // 
            // labelHuidigeSaldo
            // 
            this.labelHuidigeSaldo.AutoSize = true;
            this.labelHuidigeSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHuidigeSaldo.Location = new System.Drawing.Point(280, 254);
            this.labelHuidigeSaldo.Name = "labelHuidigeSaldo";
            this.labelHuidigeSaldo.Size = new System.Drawing.Size(29, 31);
            this.labelHuidigeSaldo.TabIndex = 9;
            this.labelHuidigeSaldo.Text = "0";
            // 
            // buttonOpwaarderen
            // 
            this.buttonOpwaarderen.Location = new System.Drawing.Point(134, 275);
            this.buttonOpwaarderen.Name = "buttonOpwaarderen";
            this.buttonOpwaarderen.Size = new System.Drawing.Size(103, 44);
            this.buttonOpwaarderen.TabIndex = 10;
            this.buttonOpwaarderen.Text = "Opwaarderen";
            this.buttonOpwaarderen.UseVisualStyleBackColor = true;
            this.buttonOpwaarderen.Click += new System.EventHandler(this.ButtonOpwaarderen_Click);
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.BackColor = System.Drawing.Color.White;
            this.labelCount.ForeColor = System.Drawing.Color.White;
            this.labelCount.Location = new System.Drawing.Point(39, 291);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(0, 13);
            this.labelCount.TabIndex = 73;
            // 
            // SaldoOpwaarderen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(412, 329);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.buttonOpwaarderen);
            this.Controls.Add(this.labelHuidigeSaldo);
            this.Controls.Add(this.textBoxSaldo);
            this.Controls.Add(this.button1Euro);
            this.Controls.Add(this.button2Euro);
            this.Controls.Add(this.button50Cent);
            this.Controls.Add(this.button20Cent);
            this.Controls.Add(this.button10Cent);
            this.DoubleBuffered = true;
            this.Name = "SaldoOpwaarderen";
            this.Text = "SaldoOpwaarderen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button10Cent;
        private System.Windows.Forms.Button button20Cent;
        private System.Windows.Forms.Button button50Cent;
        private System.Windows.Forms.Button button2Euro;
        private System.Windows.Forms.Button button1Euro;
        private System.Windows.Forms.TextBox textBoxSaldo;
        private System.Windows.Forms.Label labelHuidigeSaldo;
        private System.Windows.Forms.Button buttonOpwaarderen;
        private System.Windows.Forms.Label labelCount;
    }
}