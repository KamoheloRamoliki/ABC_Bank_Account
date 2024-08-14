
namespace ABC_Bank_Account
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.FrontPage = new System.Windows.Forms.Label();
            this.AccntName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(374, 193);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(209, 20);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(340, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // FrontPage
            // 
            this.FrontPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FrontPage.ForeColor = System.Drawing.Color.Red;
            this.FrontPage.Location = new System.Drawing.Point(124, 67);
            this.FrontPage.Name = "FrontPage";
            this.FrontPage.Size = new System.Drawing.Size(499, 40);
            this.FrontPage.TabIndex = 3;
            this.FrontPage.Text = "ABC Bank Account Managment";
            // 
            // AccntName
            // 
            this.AccntName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AccntName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccntName.ForeColor = System.Drawing.Color.Red;
            this.AccntName.Location = new System.Drawing.Point(161, 187);
            this.AccntName.Name = "AccntName";
            this.AccntName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AccntName.Size = new System.Drawing.Size(207, 32);
            this.AccntName.TabIndex = 4;
            this.AccntName.Text = "Account Name";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(158, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(499, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "Welcome to the sef service please enter you account name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 348);
            this.Controls.Add(this.AccntName);
            this.Controls.Add(this.FrontPage);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Mangament Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label FrontPage;
        private System.Windows.Forms.Label AccntName;
        private System.Windows.Forms.Label label1;
    }
}