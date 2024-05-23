using Blazor.Model;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Blazor.Dapper.Repository
{
    public class FilmRepository : IFilmRepository
    {

        private string _connection;

        public FilmRepository(string ConnectionString)
        {
            _connection = ConnectionString;
        }


        protected SqlConnection dbConnection()
        {
            return new SqlConnection(_connection);
        }

        public async Task<bool> Create(Film film)
        {
            var db = dbConnection();
            string sql = @"insert into films
                        (director,release,titulo)
                        values(@director,@release,@titulo)";

            var result = await db.ExecuteAsync(sql, new { film.director, film.release, film.titulo });

            return result > 0;
        }

        public async Task<bool> Delete(int Id)
        {
            var db = dbConnection();
            string sql = @"delete films where id = @Id";

            var result = await db.ExecuteAsync(sql, new { Id });

            return result > 0;
        }

        public async Task<IEnumerable<Film>> GetAll()
        {
            var db = dbConnection();
            string sql = @"select director,release,titulo from films";

            var result = await db.QueryAsync<Film>(sql);

            return result;
        }

        public Task<Film> GetFilm(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(int Id, Film film)
        {
            throw new NotImplementedException();
        }
    }
}
