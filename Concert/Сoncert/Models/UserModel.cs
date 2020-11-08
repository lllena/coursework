using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Сoncert.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        [DisplayName(@"Логин")]
        public string Login { get; set; }
        [DisplayName(@"Пароль")]
        public string Pasword { get; set; }
    }
}
