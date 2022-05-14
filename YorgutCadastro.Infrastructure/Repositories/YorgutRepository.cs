using YorgutCadastro.Domain.Entities;
using YorgutCadastro.Infrastructure.Context;
using YorgutCadastro.Infrastructure.Interfaces;

namespace YorgutCadastro.Infrastructure.Repositories
{
    public class YorgutRepository : BaseRepository<YorgutCadastroEntity>, IYorgutRepository
    {
        public YorgutRepository(YorgutCadastroContext context) : base(context)
        {
        }
    }
}
