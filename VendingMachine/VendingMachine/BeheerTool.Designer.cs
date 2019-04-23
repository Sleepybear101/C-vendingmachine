namespace VendingMachine
{
    partial class BeheerTool
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
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.btnPrijs = new System.Windows.Forms.Button();
            this.btnNaam = new System.Windows.Forms.Button();
            this.textBoxPrijs = new System.Windows.Forms.TextBox();
            this.textBoxNaam = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(348, 26);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(424, 22);
            this.searchTextBox.TabIndex = 28;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(54, 293);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(163, 49);
            this.button6.TabIndex = 27;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btnPrijs
            // 
            this.btnPrijs.Location = new System.Drawing.Point(13, 132);
            this.btnPrijs.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrijs.Name = "btnPrijs";
            this.btnPrijs.Size = new System.Drawing.Size(126, 34);
            this.btnPrijs.TabIndex = 26;
            this.btnPrijs.Text = "Prijs";
            this.btnPrijs.UseVisualStyleBackColor = true;
            // 
            // btnNaam
            // 
            this.btnNaam.Location = new System.Drawing.Point(13, 87);
            this.btnNaam.Margin = new System.Windows.Forms.Padding(4);
            this.btnNaam.Name = "btnNaam";
            this.btnNaam.Size = new System.Drawing.Size(126, 37);
            this.btnNaam.TabIndex = 25;
            this.btnNaam.Text = "Productnaam";
            this.btnNaam.UseVisualStyleBackColor = true;
            // 
            // textBoxPrijs
            // 
            this.textBoxPrijs.Location = new System.Drawing.Point(147, 138);
            this.textBoxPrijs.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPrijs.Name = "textBoxPrijs";
            this.textBoxPrijs.Size = new System.Drawing.Size(157, 22);
            this.textBoxPrijs.TabIndex = 24;
            // 
            // textBoxNaam
            // 
            this.textBoxNaam.Location = new System.Drawing.Point(147, 93);
            this.textBoxNaam.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNaam.Name = "textBoxNaam";
            this.textBoxNaam.Size = new System.Drawing.Size(157, 22);
            this.textBoxNaam.TabIndex = 23;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(128, 13);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(163, 49);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(312, 76);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(527, 230);
            this.dataGridView1.TabIndex = 21;
            // 
            // BeheerTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 453);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnPrijs);
            this.Controls.Add(this.btnNaam);
            this.Controls.Add(this.textBoxPrijs);
            this.Controls.Add(this.textBoxNaam);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BeheerTool";
            this.Text = "BeheerTool";
            this.Load += new System.EventHandler(this.BeheerTool_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnPrijs;
        private System.Windows.Forms.Button btnNaam;
        private System.Windows.Forms.TextBox textBoxPrijs;
        private System.Windows.Forms.TextBox textBoxNaam;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}