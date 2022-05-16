using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using YorgutCadastro.Domain.Entities;
using YorgutCadastro.Infrastructure.Context;
using YorgutCadastro.Infrastructure.Interfaces;


namespace YorgutCadastro.Infrastructure.Repositories
{
    public class BaseRepository<T> :  IAsyncRepository<T> where T : BaseEntity
    {
        protected readonly YorgutCadastroContext _context;

        public BaseRepository(YorgutCadastroContext context)
        {
            _context = context;
        }

        public async Task<List<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task InsertYorgut(T usuario)
        {
            await _context.Set<T>().AddAsync(usuario);
            await _context.SaveChangesAsync();
        }

        public async Task Delete()
        {
            using var con = new SqliteConnection("Data Source=C:\\Users\\Elias\\Documents\\CadastroYorgut.db");

            string sqlStatement = "DELETE FROM YorgutCadastroEntity";

            con.Open();

            using var cmd = new SqliteCommand(sqlStatement, con);

            cmd.ExecuteNonQuery();
        } 
        

    }
}
