
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
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(192, 756);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(150, 63);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.Location = new System.Drawing.Point(1214, 756);
            this.btnAddNew.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(198, 63);
            this.btnAddNew.TabIndex = 13;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnSort
            // 
            this.btnSort.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSort.Location = new System.Drawing.Point(698, 756);
            this.btnSort.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(198, 63);
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
            this.lstWebsites.ItemHeight = 42;
            this.lstWebsites.Location = new System.Drawing.Point(172, 198);
            this.lstWebsites.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstWebsites.Name = "lstWebsites";
            this.lstWebsites.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstWebsites.Size = new System.Drawing.Size(328, 466);
            this.lstWebsites.TabIndex = 17;
            // 
            // lstUsernames
            // 
            this.lstUsernames.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lstUsernames.FormattingEnabled = true;
            this.lstUsernames.ImeMode = System.Windows.Forms.ImeMode.On;
            this.lstUsernames.ItemHeight = 42;
            this.lstUsernames.Location = new System.Drawing.Point(514, 198);
            this.lstUsernames.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstUsernames.Name = "lstUsernames";
            this.lstUsernames.Size = new System.Drawing.Size(602, 466);
            this.lstUsernames.TabIndex = 17;
            // 
            // lstPasswords
            // 
            this.lstPasswords.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lstPasswords.FormattingEnabled = true;
            this.lstPasswords.ItemHeight = 42;
            this.lstPasswords.Location = new System.Drawing.Point(1132, 202);
            this.lstPasswords.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstPasswords.Name = "lstPasswords";
            this.lstPasswords.Size = new System.Drawing.Size(312, 466);
            this.lstPasswords.TabIndex = 18;
            // 
            // lblWebsites
            // 
            this.lblWebsites.AutoSize = true;
            this.lblWebsites.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblWebsites.Location = new System.Drawing.Point(222, 138);
            this.lblWebsites.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWebsites.Name = "lblWebsites";
            this.lblWebsites.Size = new System.Drawing.Size(177, 44);
            this.lblWebsites.TabIndex = 19;
            this.lblWebsites.Text = "Websites";
            // 
            // lblUsernames
            // 
            this.lblUsernames.AutoSize = true;
            this.lblUsernames.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblUsernames.Location = new System.Drawing.Point(720, 138);
            this.lblUsernames.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsernames.Name = "lblUsernames";
            this.lblUsernames.Size = new System.Drawing.Size(215, 44);
            this.lblUsernames.TabIndex = 20;
            this.lblUsernames.Text = "Usernames";
            // 
            // lblPasswords
            // 
            this.lblPasswords.AutoSize = true;
            this.lblPasswords.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblPasswords.Location = new System.Drawing.Point(1192, 138);
            this.lblPasswords.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPasswords.Name = "lblPasswords";
            this.lblPasswords.Size = new System.Drawing.Size(205, 44);
            this.lblPasswords.TabIndex = 21;
            this.lblPasswords.Text = "Passwords";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(435, 756);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(198, 63);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FilePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblPasswords);
            this.Controls.Add(this.lblUsernames);
            this.Controls.Add(this.lblWebsites);
            this.Controls.Add(this.lstPasswords);
            this.Controls.Add(this.lstUsernames);
            this.Controls.Add(this.lstWebsites);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAddNew);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
        private System.Windows.Forms.Button btnSave;
    }
}