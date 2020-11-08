using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Сoncert.Models;
using static Сoncert.DataAcces;

namespace Сoncert.Controls
{
    public partial class ProgramControl : UserControl
    {
        public ProgramControl() { InitializeComponent(); }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            var playlist = GetPlaylist();
            var userSongs = GetUserSongs();
            var p = playlist.Join(userSongs, a => a.Id, c => c.SongId, (a, c) => new { a.Title })
                .GroupBy(x => x.Title)
                .Select(x => new { Title = x.Key, Cnt = x.Count() })
                .OrderByDescending(x => x.Cnt);
            int num = 0;

            int cnt = (int)cntUpDown.Value;
            List<PlaylistModel> list = new List<PlaylistModel>();
            foreach (var title in p)
            {
                PlaylistModel song = new PlaylistModel() { Id = ++num, Title = title.Title };
                list.Add(song);
                if (--cnt == 0)
                    break;
            }
            playlistModelBindingSource = new BindingSource
            {
                DataSource = list
            };
            dataGridView1.DataSource = playlistModelBindingSource;
            if (cnt > 0)
                MessageBox.Show("Количество песен в программе превышает количество выбранных",
                                "Предупреждение",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
        }

        public UserModel GetUser { get; set; }
    }
}
