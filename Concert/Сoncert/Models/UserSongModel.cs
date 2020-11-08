using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сoncert.Models
{
    public class UserSongModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int SongId { get; set; }
    }
}
