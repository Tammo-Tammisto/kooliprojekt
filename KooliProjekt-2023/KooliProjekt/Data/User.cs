using KooliProjekt.Models;

namespace KooliProjekt.Data
{
    public class User : Entity
    {
        public new int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
