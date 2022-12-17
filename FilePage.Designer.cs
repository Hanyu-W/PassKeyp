
namespace PassKeyp
{
    partial class FilePage
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.lstWebsites = new System.Windows.Forms.ListBox();
            this.lstUsernames = new System.Windows.Forms.ListBox();
            this.lstPasswords = new System.Windows.Forms.ListBox();
            this.lblWebsites = new System.Windows.Forms.Label();
            this.lblUsernames = new System.Windows.Forms.Label();
            this.lblPasswords = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(96, 393);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 33);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.Location = new System.Drawing.Point(607, 393);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(99, 33);
            this.btnAddNew.TabIndex = 13;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnSort
            // 
            this.btnSort.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSort.Location = new System.Drawing.Point(349, 393);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(99, 33);
            this.btnSort.TabIndex = 15;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // lstWebsites
            // 
            this.lstWebsites.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lstWebsites.FormattingEnabled = true;
            this.lstWebsites.ImeMode = System.Windows.Forms.ImeMode.On;
            this.lstWebsites.ItemHeight = 24;
            this.lstWebsites.Location = new System.Drawing.Point(86, 103);
            this.lstWebsites.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstWebsites.Name = "lstWebsites";
            this.lstWebsites.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstWebsites.Size = new System.Drawing.Size(166, 244);
            this.lstWebsites.TabIndex = 17;
            // 
            // lstUsernames
            // 
            this.lstUsernames.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lstUsernames.FormattingEnabled = true;
            this.lstUsernames.ImeMode = System.Windows.Forms.ImeMode.On;
            this.lstUsernames.ItemHeight = 24;
            this.lstUsernames.Location = new System.Drawing.Point(257, 103);
            this.lstUsernames.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstUsernames.Name = "lstUsernames";
            this.lstUsernames.Size = new System.Drawing.Size(303, 244);
            this.lstUsernames.TabIndex = 17;
            // 
            // lstPasswords
            // 
            this.lstPasswords.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lstPasswords.FormattingEnabled = true;
            this.lstPasswords.ItemHeight = 24;
            this.lstPasswords.Location = new System.Drawing.Point(566, 105);
            this.lstPasswords.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstPasswords.Name = "lstPasswords";
            this.lstPasswords.Size = new System.Drawing.Size(158, 244);
            this.lstPasswords.TabIndex = 18;
            // 
            // lblWebsites
            // 
            this.lblWebsites.AutoSize = true;
            this.lblWebsites.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblWebsites.Location = new System.Drawing.Point(111, 72);
            this.lblWebsites.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWebsites.Name = "lblWebsites";
            this.lblWebsites.Size = new System.Drawing.Size(87, 24);
            this.lblWebsites.TabIndex = 19;
            this.lblWebsites.Text = "Websites";
            // 
            // lblUsernames
            // 
            this.lblUsernames.AutoSize = true;
            this.lblUsernames.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblUsernames.Location = new System.Drawing.Point(360, 72);
            this.lblUsernames.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsernames.Name = "lblUsernames";
            this.lblUsernames.Size = new System.Drawing.Size(106, 24);
            this.lblUsernames.TabIndex = 20;
            this.lblUsernames.Text = "Usernames";
            // 
            // lblPasswords
            // 
            this.lblPasswords.AutoSize = true;
            this.lblPasswords.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblPasswords.Location = new System.Drawing.Point(596, 72);
            this.lblPasswords.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPasswords.Name = "lblPasswords";
            this.lblPasswords.Size = new System.Drawing.Size(101, 24);
            this.lblPasswords.TabIndex = 21;
            this.lblPasswords.Text = "Passwords";
            // 
            // FilePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPasswords);
            this.Controls.Add(this.lblUsernames);
            this.Controls.Add(this.lblWebsites);
            this.Controls.Add(this.lstPasswords);
            this.Controls.Add(this.lstUsernames);
            this.Controls.Add(this.lstWebsites);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAddNew);
            this.Name = "FilePage";
            this.Text = "FIlePage";
            this.Load += new System.EventHandler(this.FilePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.ListBox lstWebsites;
        private System.Windows.Forms.ListBox lstUsernames;
        private System.Windows.Forms.ListBox lstPasswords;
        private System.Windows.Forms.Label lblWebsites;
        private System.Windows.Forms.Label lblUsernames;
        private System.Windows.Forms.Label lblPasswords;
    }
}