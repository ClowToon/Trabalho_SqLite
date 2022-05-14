using System;

namespace YorgutCadastro.Domain.Entities
{
    public class BaseEntity
    {
        public Guid Id { get; set; }

        public int Ativo { get; set; }

        public BaseEntity()
        {
            Id = Guid.NewGuid();
            Ativo = 1;
        }
    }
}
