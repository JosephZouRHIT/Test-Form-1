namespace Test_Form_1
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
            this.UserNameInput = new System.Windows.Forms.TextBox();
            this.UserName = new System.Windows.Forms.Label();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.ResultOutput = new System.Windows.Forms.RichTextBox();
            this.Result = new System.Windows.Forms.Label();
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserNameInput
            // 
            this.UserNameInput.Location = new System.Drawing.Point(444, 76);
            this.UserNameInput.Name = "UserNameInput";
            this.UserNameInput.Size = new System.Drawing.Size(683, 26);
            this.UserNameInput.TabIndex = 0;
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Location = new System.Drawing.Point(319, 76);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(89, 20);
            this.UserName.TabIndex = 1;
            this.UserName.Text = "User Name";
            // 
            // PasswordInput
            // 
            this.PasswordInput.Location = new System.Drawing.Point(444, 165);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.PasswordChar = '*';
            this.PasswordInput.Size = new System.Drawing.Size(683, 26);
            this.PasswordInput.TabIndex = 2;
            this.PasswordInput.UseSystemPasswordChar = true;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(323, 170);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(78, 20);
            this.Password.TabIndex = 3;
            this.Password.Text = "Password";
            // 
            // ResultOutput
            // 
            this.ResultOutput.Location = new System.Drawing.Point(444, 302);
            this.ResultOutput.Name = "ResultOutput";
            this.ResultOutput.Size = new System.Drawing.Size(683, 508);
            this.ResultOutput.TabIndex = 4;
            this.ResultOutput.Text = "";
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(323, 317);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(55, 20);
            this.Result.TabIndex = 5;
            this.Result.Text = "Result";
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Location = new System.Drawing.Point(1218, 170);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(75, 23);
            this.ConnectBtn.TabIndex = 6;
            this.ConnectBtn.Text = "Connect";
            this.ConnectBtn.UseVisualStyleBackColor = true;
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1786, 1105);
            this.Controls.Add(this.ConnectBtn);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.ResultOutput);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.PasswordInput);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.UserNameInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserNameInput;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.RichTextBox ResultOutput;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Button ConnectBtn;
    }
}

