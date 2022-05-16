using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
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


        public async Task<YorgutCadastroEntity> LoginYorgut(YorgutCadastroEntity usuario)
        {
            return await _context.Set<YorgutCadastroEntity>().FirstOrDefaultAsync(x => x.Username == usuario.Username && x.Password == usuario.Password);
        }

    }
}
