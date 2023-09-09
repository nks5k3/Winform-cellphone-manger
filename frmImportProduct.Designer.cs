namespace DoAnWinformBanDienThoai
{
    partial class frmImportProduct
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.ucBrand1 = new DoAnWinformBanDienThoai.UCBrand();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.ucBrand1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 342);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1082, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ucBrand1
            // 
            this.ucBrand1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucBrand1.Location = new System.Drawing.Point(0, 0);
            this.ucBrand1.Name = "ucBrand1";
            this.ucBrand1.PBrand = null;
            this.ucBrand1.PColor = null;
            this.ucBrand1.PDescription = null;
            this.ucBrand1.PGuarantee = null;
            this.ucBrand1.PKindOfProduct = null;
            this.ucBrand1.PMake = null;
            this.ucBrand1.PName = "12345";
            this.ucBrand1.PNewTime = null;
            this.ucBrand1.PPrice = null;
            this.ucBrand1.Size = new System.Drawing.Size(1200, 342);
            this.ucBrand1.TabIndex = 0;
            this.ucBrand1.Load += new System.EventHandler(this.ucBrand1_Load);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 342);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1200, 408);
            this.panel2.TabIndex = 1;
            // 
            // frmImportProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 750);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmImportProduct";
            this.Text = "frmImportProduct";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private UCBrand ucBrand1;
        private System.Windows.Forms.Button button1;
    }
}