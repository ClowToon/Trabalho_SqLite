using System.Threading.Tasks;
using YorgutCadastro.Domain.Entities;

namespace YorgutCadastro.Infrastructure.Interfaces
{
    public interface IYorgutRepository : IAsyncRepository<YorgutCadastroEntity>
    {

        Task<YorgutCadastroEntity> LoginYorgut(YorgutCadastroEntity usuario);


    }
}
