namespace Bai15_SoThocTrenBanCo
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnTinh = new System.Windows.Forms.Button();
            this.txto = new System.Windows.Forms.TextBox();
            this.lsto = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "nhập số ô";
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(80, 115);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(131, 51);
            this.btnTinh.TabIndex = 2;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // txto
            // 
            this.txto.Location = new System.Drawing.Point(116, 65);
            this.txto.Name = "txto";
            this.txto.Size = new System.Drawing.Size(95, 20);
            this.txto.TabIndex = 3;
            // 
            // lsto
            // 
            this.lsto.FormattingEnabled = true;
            this.lsto.Location = new System.Drawing.Point(242, 24);
            this.lsto.Name = "lsto";
            this.lsto.Size = new System.Drawing.Size(175, 199);
            this.lsto.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lsto);
            this.Controls.Add(this.txto);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.TextBox txto;
        private System.Windows.Forms.ListBox lsto;
    }
}

