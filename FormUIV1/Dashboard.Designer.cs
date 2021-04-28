
namespace FormUIV1
{
    partial class Dashboard
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
            this.peopleFoundListBox = new System.Windows.Forms.ListBox();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.firstNameInsLabel = new System.Windows.Forms.Label();
            this.firstNameInsText = new System.Windows.Forms.TextBox();
            this.phoneInsLabel = new System.Windows.Forms.Label();
            this.phoneNumberInsText = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.lastNameInsLabel = new System.Windows.Forms.Label();
            this.lastNameInsText = new System.Windows.Forms.TextBox();
            this.emailInsText = new System.Windows.Forms.TextBox();
            this.InsertRecorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // peopleFoundListBox
            // 
            this.peopleFoundListBox.FormattingEnabled = true;
            this.peopleFoundListBox.Location = new System.Drawing.Point(22, 76);
            this.peopleFoundListBox.Name = "peopleFoundListBox";
            this.peopleFoundListBox.Size = new System.Drawing.Size(495, 108);
            this.peopleFoundListBox.TabIndex = 0;
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(96, 35);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(108, 20);
            this.lastNameText.TabIndex = 1;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(19, 38);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Last Name";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(223, 33);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // firstNameInsLabel
            // 
            this.firstNameInsLabel.AutoSize = true;
            this.firstNameInsLabel.Location = new System.Drawing.Point(19, 215);
            this.firstNameInsLabel.Name = "firstNameInsLabel";
            this.firstNameInsLabel.Size = new System.Drawing.Size(57, 13);
            this.firstNameInsLabel.TabIndex = 5;
            this.firstNameInsLabel.Text = "First Name";
            this.firstNameInsLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // firstNameInsText
            // 
            this.firstNameInsText.Location = new System.Drawing.Point(96, 212);
            this.firstNameInsText.Name = "firstNameInsText";
            this.firstNameInsText.Size = new System.Drawing.Size(108, 20);
            this.firstNameInsText.TabIndex = 4;
            // 
            // phoneInsLabel
            // 
            this.phoneInsLabel.AutoSize = true;
            this.phoneInsLabel.Location = new System.Drawing.Point(19, 295);
            this.phoneInsLabel.Name = "phoneInsLabel";
            this.phoneInsLabel.Size = new System.Drawing.Size(78, 13);
            this.phoneInsLabel.TabIndex = 7;
            this.phoneInsLabel.Text = "Phone Number";
            // 
            // phoneNumberInsText
            // 
            this.phoneNumberInsText.Location = new System.Drawing.Point(96, 292);
            this.phoneNumberInsText.Name = "phoneNumberInsText";
            this.phoneNumberInsText.Size = new System.Drawing.Size(108, 20);
            this.phoneNumberInsText.TabIndex = 6;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(19, 269);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(32, 13);
            this.emailLabel.TabIndex = 9;
            this.emailLabel.Text = "Email";
            // 
            // lastNameInsLabel
            // 
            this.lastNameInsLabel.AutoSize = true;
            this.lastNameInsLabel.Location = new System.Drawing.Point(19, 241);
            this.lastNameInsLabel.Name = "lastNameInsLabel";
            this.lastNameInsLabel.Size = new System.Drawing.Size(58, 13);
            this.lastNameInsLabel.TabIndex = 11;
            this.lastNameInsLabel.Text = "Last Name";
            // 
            // lastNameInsText
            // 
            this.lastNameInsText.Location = new System.Drawing.Point(96, 238);
            this.lastNameInsText.Name = "lastNameInsText";
            this.lastNameInsText.Size = new System.Drawing.Size(108, 20);
            this.lastNameInsText.TabIndex = 10;
            // 
            // emailInsText
            // 
            this.emailInsText.Location = new System.Drawing.Point(96, 266);
            this.emailInsText.Name = "emailInsText";
            this.emailInsText.Size = new System.Drawing.Size(108, 20);
            this.emailInsText.TabIndex = 8;
            // 
            // InsertRecorButton
            // 
            this.InsertRecorButton.Location = new System.Drawing.Point(129, 330);
            this.InsertRecorButton.Name = "InsertRecorButton";
            this.InsertRecorButton.Size = new System.Drawing.Size(75, 23);
            this.InsertRecorButton.TabIndex = 12;
            this.InsertRecorButton.Text = "Insert";
            this.InsertRecorButton.UseVisualStyleBackColor = true;
            this.InsertRecorButton.Click += new System.EventHandler(this.InsertRecorButton_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InsertRecorButton);
            this.Controls.Add(this.lastNameInsLabel);
            this.Controls.Add(this.lastNameInsText);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.emailInsText);
            this.Controls.Add(this.phoneInsLabel);
            this.Controls.Add(this.phoneNumberInsText);
            this.Controls.Add(this.firstNameInsLabel);
            this.Controls.Add(this.firstNameInsText);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.peopleFoundListBox);
            this.Name = "Dashboard";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox peopleFoundListBox;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label firstNameInsLabel;
        private System.Windows.Forms.TextBox firstNameInsText;
        private System.Windows.Forms.Label phoneInsLabel;
        private System.Windows.Forms.TextBox phoneNumberInsText;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label lastNameInsLabel;
        private System.Windows.Forms.TextBox lastNameInsText;
        private System.Windows.Forms.TextBox emailInsText;
        private System.Windows.Forms.Button InsertRecorButton;
    }
}

