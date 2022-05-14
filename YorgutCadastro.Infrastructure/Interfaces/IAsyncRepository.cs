
using System.Collections.Generic;
using System.Threading.Tasks;

namespace YorgutCadastro.Infrastructure.Interfaces
{
    public interface IAsyncRepository<T>
    {
        Task<List<T>> GetAll();

        Task InsertYorgut(T usuario);

        Task<T> LoginYorgut(T usuario);

        Task Delete();
    }
}
