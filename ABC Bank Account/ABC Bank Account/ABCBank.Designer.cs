
namespace ABC_Bank_Account
{
    partial class ABCPassword
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
            this.FrontPage = new System.Windows.Forms.Label();
            this.PinName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FrontPage
            // 
            this.FrontPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FrontPage.ForeColor = System.Drawing.Color.Red;
            this.FrontPage.Location = new System.Drawing.Point(85, 30);
            this.FrontPage.Name = "FrontPage";
            this.FrontPage.Size = new System.Drawing.Size(499, 40);
            this.FrontPage.TabIndex = 4;
            this.FrontPage.Text = "ABC Bank Account Managment";
            // 
            // PinName
            // 
            this.PinName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PinName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PinName.ForeColor = System.Drawing.Color.Red;
            this.PinName.Location = new System.Drawing.Point(109, 146);
            this.PinName.Name = "PinName";
            this.PinName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PinName.Size = new System.Drawing.Size(207, 23);
            this.PinName.TabIndex = 5;
            this.PinName.Text = "Pin";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(331, 149);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(209, 20);
            this.txtName.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(286, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ABCPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(689, 315);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.PinName);
            this.Controls.Add(this.FrontPage);
            this.Name = "ABCPassword";
            this.Text = "Manage Account";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FrontPage;
        private System.Windows.Forms.Label PinName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button button1;
    }
}

