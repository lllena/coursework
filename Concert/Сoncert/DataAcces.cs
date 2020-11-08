using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;
using Сoncert.Models;

namespace Сoncert
{
    public static class DataAcces
    {
        private static string GetConnectionSting()
        {
            return ConfigurationManager
                .ConnectionStrings["Сoncert.Properties.Settings.ConcertConnectionString"].ConnectionString;
        }

        public static int Add(PlaylistModel song)
        {
            int ret = 0;
            try
            {
                using (var conn = new OleDbConnection(GetConnectionSting()))
                {
                    string sql = @"Insert into  Playlist
                                (Title)
                                VALUES(@Title)";
                    conn.Execute(sql, song);
                    sql = @"select MAX(Id)
                            from Playlist";
                    ret = conn.Query<int>(sql).Single();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return ret;
        }

        public static int AddUser(UserModel user)
        {
            int ret = 0;
            try
            {
                if (LoginCheck(user))
                    throw new Exception("Логин уже существует.");
                using (var conn = new OleDbConnection(GetConnectionSting()))
                {
                    string sql = @"Insert into   [User]
                                (Login ,Pasword)
                                VALUES(@Login ,@Pasword)";
                    conn.Execute(sql, user);
                    sql = @"select MAX(Id)
                            from [User]";
                    ret = conn.Query<int>(sql, new DynamicParameters()).Single();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return ret;
        }

        public static int AddUserSong(UserSongModel userSong)
        {
            int ret = 0;
            try
            {
                using (var conn = new OleDbConnection(GetConnectionSting()))
                {
                    string sql = @"Insert into  UserSong
                                (SongId,UserId)
                                VALUES(@UserId,@SongId)";
                    conn.Execute(sql, userSong);
                    sql = @"select MAX(Id)
                            from UserSong";
                    ret = conn.Query<int>(sql).Single();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return ret;
        }

        public static int CheckUser(UserModel user)
        {
            int ret = 0;
            try
            {
                using (var conn = new OleDbConnection(GetConnectionSting()))
                {
                    string sql = @"Select * 
                                    from   [User]
                                Where Login =@Login and Pasword=@Pasword";
                    var output = conn.Query<UserModel>(sql, user).FirstOrDefault();
                    if (output != null)
                        ret = output.Id;
                    else
                        throw new Exception("Пароль неверный");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ret;
        }

        public static void ClearSongFromUser(int userId)
        {
            try
            {
                using (var conn = new OleDbConnection(GetConnectionSting()))
                {
                    string sql = @"Delete from UserSong
                                Where (UserId =@UserId )";
                    var p = new DynamicParameters();
                    p.Add("@UserId", userId);
                    conn.Execute(sql, p);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static List<PlaylistModel> GetPlaylist()
        {
            var list = new List<PlaylistModel>();
            try
            {
                using (var conn = new OleDbConnection(GetConnectionSting()))
                {
                    string sql = "Select * from Playlist";
                    var output = conn.Query<PlaylistModel>(sql, new DynamicParameters());
                    list.AddRange(output);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return list;
        }

        public static List<UserSongModel> GetUserSongs()
        {
            var list = new List<UserSongModel>();
            try
            {
                using (var conn = new OleDbConnection(GetConnectionSting()))
                {
                    string sql = "Select * from UserSong";
                    var output = conn.Query<UserSongModel>(sql, new DynamicParameters());
                    list.AddRange(output);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return list;
        }

        public static List<UserSongModel> GetUserSongs(UserModel user)
        {
            var list = new List<UserSongModel>();
            try
            {
                using (var conn = new OleDbConnection(GetConnectionSting()))
                {
                    string sql = @"Select * from UserSong
                                where UserId=@Id";
                    var output = conn.Query<UserSongModel>(sql, user);
                    list.AddRange(output);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return list;
        }

        public static bool LoginCheck(UserModel user)
        {
            bool ret = true;
            try
            {
                using (var conn = new OleDbConnection(GetConnectionSting()))
                {
                    string sql = @"Select count(*) 
                                    from   [User]
                                Where (Login =@Login )";
                    ret = conn.Query<int>(sql, user).Single() > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return ret;
        }
    }
}
