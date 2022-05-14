

namespace YorgutCadastro.Domain.Entities
{
    public class YorgutCadastroEntity : BaseEntity
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public string Name { get; set; }

        public int Gender { get; set; }

        public int Age { get; set; }

        public string Bios { get; set; }


    }
}
