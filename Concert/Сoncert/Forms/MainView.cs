using System;
using System.Windows.Forms;
using Сoncert.Controls;
using Сoncert.Models;

namespace Сoncert.Forms
{
    public partial class MainView : Form
    {
        СoncertControls сoncertControl;

        public MainView(UserModel user)
        {
            InitializeComponent();
            SetUser(user);
        }

        private void BtnProgramm_Click(object sender, EventArgs e)
        {
            if (сoncertControl != СoncertControls.Select)
                LoadProgramControl();
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            if (сoncertControl != СoncertControls.Select)
                LoadSelectControl();
        }

        private void BtnUser_Click(object sender, EventArgs e)
        {
            using (LoginForm login = new LoginForm())
                if (login.ShowDialog() == DialogResult.OK)
                {
                    SetUser(login.GetUser);
                    ClearPanel();
                }
        }

        private void ClearPanel()
        {
            splitContainer1.Panel2.Controls.Clear();
            сoncertControl = СoncertControls.Null;
        }

        private void LoadProgramControl()
        {

            ClearPanel();
            сoncertControl = СoncertControls.Programm;
            ProgramControl programControl = new ProgramControl() { GetUser = User, Dock = DockStyle.Fill };
            splitContainer1.Panel2.Controls.Add(programControl);
        }

        private void LoadSelectControl()
        {
            сoncertControl = СoncertControls.Select;
            SelectControl selectControl = new SelectControl() { GetUser = User, Dock = DockStyle.Fill };
            selectControl.SelectControlButtonClick += OnSelectControlButtonClick;
            ClearPanel();
            splitContainer1.Panel2.Controls.Add(selectControl);
        }

        private void OnSelectControlButtonClick(object sender, EventArgs e) => ClearPanel();

        private void SetUser(UserModel user)
        {
            User = user;
            Text = $"Программа концерта (пользователь {user.Login})";
            btnCreate.Visible = User.Id == 1;
        }

        public UserModel User { get; set; }
    }
    public enum СoncertControls
    {
        Null,
        Select,
        Programm
    }
}
