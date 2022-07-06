namespace Email_Book
{
    partial class ContactList
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
            this.emailLB = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // emailLB
            // 
            this.emailLB.FormattingEnabled = true;
            this.emailLB.ItemHeight = 20;
            this.emailLB.Location = new System.Drawing.Point(12, 12);
            this.emailLB.Name = "emailLB";
            this.emailLB.Size = new System.Drawing.Size(296, 344);
            this.emailLB.TabIndex = 0;
            this.emailLB.SelectedIndexChanged += new System.EventHandler(this.emailLB_SelectedIndexChanged);
            // 
            // ContactList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 394);
            this.Controls.Add(this.emailLB);
            this.Name = "ContactList";
            this.Text = "Contact List";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox emailLB;
    }
}

