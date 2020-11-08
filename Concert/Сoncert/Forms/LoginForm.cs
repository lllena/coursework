using System;
using System.Linq;
using System.Windows.Forms;
using Сoncert.Models;
using static Сoncert.DataAcces;

namespace Сoncert.Forms
{
    public partial class LoginForm : Form
    {
        private bool isAuthorization;

        public LoginForm() {
            InitializeComponent();
            userBindingSource.DataSource = GetUser;
        }

        private void btnAuthorization_Click(object sender, EventArgs e)
        {
            isAuthorization = true;
            confirmTextBox.Visible = isAuthorization;

            Label confirmLabel = new Label
            {
                AutoSize = true,
                Location = new System.Drawing.Point(7, 67),
                Name = "confirmLabel",
                Size = new System.Drawing.Size(91, 13),
                Text = "Подтверждение:"
            };
            Controls.Add(confirmLabel);
            btnAuthorization.Visible = false;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!CheckTextBoxs())
                return;
            if (isAuthorization && paswordTextBox.Text != confirmTextBox.Text)
            {
                MessageBox.Show("Подтверждение неверно", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            GetUser.Id = (isAuthorization == true) ? AddUser(GetUser) : CheckUser(GetUser);
            if (GetUser.Id > 0)
                DialogResult = DialogResult.OK;
        }

        private bool CheckTextBoxs()
        {
            bool ret = true;
            string mes = "пустые значения не допускается";
            //проверяем правильность ввода данных
            foreach (var ctl in Controls)
                if (ctl is TextBox box && box.Visible == true && string.IsNullOrWhiteSpace(box.Text))
                {
                    errorProvider1.SetError(box, mes);
                    ret = false;
                    break;
                }
            return ret;
        }

        public UserModel GetUser { get; set; } = new UserModel() { Login="админ"};
    }
}
