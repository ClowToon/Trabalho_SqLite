
using System.Threading.Tasks;
using YorgutCadastro.Application.Dto;

namespace YorgutCadastro.Application.Interfaces
{
    public interface IYorgutService
    {
        Task<RetornoDto> Get();

        void Add(CadastroDto dadosCadastro);

        Task<RetornoDto> Login(string username, string password);

        void Delete();

    }
}
