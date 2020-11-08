namespace Сoncert.Forms
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label loginLabel;
            System.Windows.Forms.Label paswordLabel;
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAuthorization = new System.Windows.Forms.Button();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paswordTextBox = new System.Windows.Forms.TextBox();
            this.confirmTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            loginLabel = new System.Windows.Forms.Label();
            paswordLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Location = new System.Drawing.Point(57, 15);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new System.Drawing.Size(41, 13);
            loginLabel.TabIndex = 4;
            loginLabel.Text = "Логин:";
            // 
            // paswordLabel
            // 
            paswordLabel.AutoSize = true;
            paswordLabel.Location = new System.Drawing.Point(50, 41);
            paswordLabel.Name = "paswordLabel";
            paswordLabel.Size = new System.Drawing.Size(48, 13);
            paswordLabel.TabIndex = 5;
            paswordLabel.Text = "Пароль:";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(106, 100);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "Войти";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(192, 100);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(77, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Отказаться";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAuthorization
            // 
            this.btnAuthorization.Location = new System.Drawing.Point(12, 100);
            this.btnAuthorization.Name = "btnAuthorization";
            this.btnAuthorization.Size = new System.Drawing.Size(84, 23);
            this.btnAuthorization.TabIndex = 4;
            this.btnAuthorization.Text = "Авторизация";
            this.btnAuthorization.UseVisualStyleBackColor = true;
            this.btnAuthorization.Click += new System.EventHandler(this.btnAuthorization_Click);
            // 
            // loginTextBox
            // 
            this.loginTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Login", true));
            this.loginTextBox.Location = new System.Drawing.Point(104, 12);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(163, 20);
            this.loginTextBox.TabIndex = 5;
            this.loginTextBox.Tag = "";
            this.loginTextBox.Text = "admin";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(Сoncert.Models.UserModel);
            // 
            // paswordTextBox
            // 
            this.paswordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Pasword", true));
            this.paswordTextBox.Location = new System.Drawing.Point(104, 38);
            this.paswordTextBox.Name = "paswordTextBox";
            this.paswordTextBox.Size = new System.Drawing.Size(163, 20);
            this.paswordTextBox.TabIndex = 6;
            // 
            // confirmTextBox
            // 
            this.confirmTextBox.Location = new System.Drawing.Point(104, 64);
            this.confirmTextBox.Name = "confirmTextBox";
            this.confirmTextBox.Size = new System.Drawing.Size(163, 20);
            this.confirmTextBox.TabIndex = 6;
            this.confirmTextBox.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(284, 127);
            this.Controls.Add(paswordLabel);
            this.Controls.Add(this.confirmTextBox);
            this.Controls.Add(this.paswordTextBox);
            this.Controls.Add(loginLabel);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.btnAuthorization);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход";
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAuthorization;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox paswordTextBox;
        private System.Windows.Forms.TextBox confirmTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}