using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Сoncert.Models
{
    public class PlaylistModel
    {
        public int Id { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Пустые строки не допускаются")]
        [DisplayName(@"Композиция")]
        public string Title { get; set; }
    }
}
