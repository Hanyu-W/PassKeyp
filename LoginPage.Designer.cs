
namespace PassKeyp
{
    partial class LoginPage
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblSelectFile = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnCreateNew = new System.Windows.Forms.Button();
            this.btnFileExplorer = new System.Windows.Forms.Button();
            this.txtFileLocation = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(504, 235);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 33);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(210, 50);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(369, 47);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome to PassKeyp!";
            // 
            // lblSelectFile
            // 
            this.lblSelectFile.AutoSize = true;
            this.lblSelectFile.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectFile.Location = new System.Drawing.Point(81, 115);
            this.lblSelectFile.Name = "lblSelectFile";
            this.lblSelectFile.Size = new System.Drawing.Size(100, 25);
            this.lblSelectFile.TabIndex = 2;
            this.lblSelectFile.Text = "Select File:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(81, 169);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(95, 25);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(212, 167);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(367, 33);
            this.txtPassword.TabIndex = 4;
            // 
            // btnCreateNew
            // 
            this.btnCreateNew.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateNew.Location = new System.Drawing.Point(86, 378);
            this.btnCreateNew.Name = "btnCreateNew";
            this.btnCreateNew.Size = new System.Drawing.Size(150, 38);
            this.btnCreateNew.TabIndex = 5;
            this.btnCreateNew.Text = "Create New File";
            this.btnCreateNew.UseVisualStyleBackColor = true;
            this.btnCreateNew.Click += new System.EventHandler(this.btnCreateNew_Click);
            // 
            // btnFileExplorer
            // 
            this.btnFileExplorer.Location = new System.Drawing.Point(602, 109);
            this.btnFileExplorer.Name = "btnFileExplorer";
            this.btnFileExplorer.Size = new System.Drawing.Size(120, 42);
            this.btnFileExplorer.TabIndex = 6;
            this.btnFileExplorer.Text = "Open File Explorer";
            this.btnFileExplorer.UseVisualStyleBackColor = true;
            this.btnFileExplorer.Click += new System.EventHandler(this.btnFileExplorer_Click);
            // 
            // txtFileLocation
            // 
            this.txtFileLocation.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileLocation.Location = new System.Drawing.Point(211, 112);
            this.txtFileLocation.Name = "txtFileLocation";
            this.txtFileLocation.Size = new System.Drawing.Size(367, 33);
            this.txtFileLocation.TabIndex = 7;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtFileLocation);
            this.Controls.Add(this.btnFileExplorer);
            this.Controls.Add(this.btnCreateNew);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblSelectFile);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnSubmit);
            this.Name = "LoginPage";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblSelectFile;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnCreateNew;
        private System.Windows.Forms.Button btnFileExplorer;
        private System.Windows.Forms.TextBox txtFileLocation;
    }
}

