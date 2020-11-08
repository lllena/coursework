using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Сoncert.Models;
using static Сoncert.DataAcces;

namespace Сoncert.Forms
{
    public partial class SelectControl : UserControl
    {
        List<PlaylistModel> playlist;

        public SelectControl()
        {
            InitializeComponent();
        }

        public event EventHandler SelectControlButtonClick;

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewSong.Text))
            {
                errorProvider1.SetError(txtNewSong, "пустые значения не допускаются");
                return;
            }

            if (!playlist.Any(x => x.Title == txtNewSong.Text.Trim()))
            {
                var song = new PlaylistModel() { Title = txtNewSong.Text.Trim() };
                int id = Add(song);
                if (id > 0)
                {
                    song.Id = id;
                    playlist.Add(song);
                    checkedListBoxPlayList.Items.Add(song.Title);
                    checkedListBoxPlayList.SetItemChecked(checkedListBoxPlayList.Items.Count - 1, true);
                }
            }
            else
                MessageBox.Show("Композиция уже содержится в плейлисте",
                    Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            SelectControlButtonClick?.Invoke(sender, e);
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            ClearSongFromUser(GetUser.Id);
            for (int i = 0; i < checkedListBoxPlayList.Items.Count; i++)
                if (checkedListBoxPlayList.GetItemCheckState(i) == CheckState.Checked)
                {
                    var song = playlist
                        .Where(x => x.Title == checkedListBoxPlayList.GetItemText(checkedListBoxPlayList.Items[i]))
                        .FirstOrDefault();
                    if (song != null)
                    {
                        UserSongModel userSong = new UserSongModel() { UserId = GetUser.Id, SongId = song.Id };
                        AddUserSong(userSong);
                    }
                }
            SelectControlButtonClick?.Invoke(sender, e);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            playlist = GetPlaylist();
            var userSongs = GetUserSongs(GetUser);
            int i = 0;
            foreach (var item in playlist)
            {
                checkedListBoxPlayList.Items.Add(item.Title);
                if (userSongs.Any(x => x.SongId == item.Id))
                    checkedListBoxPlayList.SetItemChecked(i, true);
                i++;
            }
        }

        private void txtNewSong_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNewSong.Text))
                errorProvider1.SetError(txtNewSong, string.Empty);
        }

        public UserModel GetUser { get; set; }
    }
}
