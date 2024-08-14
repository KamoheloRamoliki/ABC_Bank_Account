
namespace ABC_Bank_Account.Properties
{
    partial class CheckAcc
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
            this.PinName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.FrontPage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PinName
            // 
            this.PinName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PinName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PinName.ForeColor = System.Drawing.Color.Red;
            this.PinName.Location = new System.Drawing.Point(181, 94);
            this.PinName.Name = "PinName";
            this.PinName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PinName.Size = new System.Drawing.Size(130, 20);
            this.PinName.TabIndex = 11;
            this.PinName.Text = "Account Number";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(285, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 44);
            this.button1.TabIndex = 10;
            this.button1.Text = "Check Balance\r\n";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(317, 94);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(88, 20);
            this.txtName.TabIndex = 9;
            // 
            // FrontPage
            // 
            this.FrontPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FrontPage.ForeColor = System.Drawing.Color.Red;
            this.FrontPage.Location = new System.Drawing.Point(148, 26);
            this.FrontPage.Name = "FrontPage";
            this.FrontPage.Size = new System.Drawing.Size(499, 40);
            this.FrontPage.TabIndex = 8;
            this.FrontPage.Text = "ABC Bank Account Managment";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(428, 94);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(219, 93);
            this.label1.TabIndex = 12;
            this.label1.Text = "\r\n";
            // 
            // CheckAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 268);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PinName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.FrontPage);
            this.Name = "CheckAcc";
            this.Text = "CheckAcc";
            this.Load += new System.EventHandler(this.CheckAcc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PinName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label FrontPage;
        private System.Windows.Forms.Label label1;
    }
}