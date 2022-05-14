using System.Threading.Tasks;
using YorgutCadastro.Application.Dto;
using YorgutCadastro.Application.Interfaces;
using YorgutCadastro.Domain.Entities;
using YorgutCadastro.Infrastructure.Interfaces;

namespace YorgutCadastro.Application.Services
{
    public class YorgutService : IYorgutService
    {
        private readonly IYorgutRepository _yorgutRepository;

        public YorgutService(IYorgutRepository yorgutRepository)
        {
            _yorgutRepository = yorgutRepository;
        }


        public async Task<RetornoDto> Get()
        {
            try
            {
                var result = await _yorgutRepository.GetAll();

                return new RetornoDto { Mensagem = "Dados encontrados", Status = 200, Item = result };
            }
            catch
            {
                return new RetornoDto { Mensagem = "Erro", Status = 400, Item = null };
            }
        }

        public void Add(CadastroDto dadosCadastro)
        {

            var entidade = new YorgutCadastroEntity
            {
                Username = dadosCadastro.Username,
                Password = dadosCadastro.Password,
                Age = dadosCadastro.Age,
                Gender = dadosCadastro.Gender,
                Name = dadosCadastro.Name,
                Bios = dadosCadastro.Bios
            };


            _yorgutRepository.InsertYorgut(entidade);
        }

        public async Task<RetornoDto> Login(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
               return new RetornoDto { Mensagem = "Todos campos devem conter valor", Status = 400, Item = null };
            }

            var entidade = new YorgutCadastroEntity
            {
                Username = username,
                Password = password
            };

            var result = await _yorgutRepository.LoginYorgut(entidade);

            if (result == null) return new RetornoDto { Mensagem = "Dados não encontrados!", Status = 404, Item = null };

            return new RetornoDto { Mensagem = "Login realizado com sucesso", Status = 200, Item = result };

        }

        public void Delete() =>  _yorgutRepository.Delete();
    }
}
