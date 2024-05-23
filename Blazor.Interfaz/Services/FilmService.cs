using Blazor.Dapper.Repository;
using Blazor.Interfaz.Data;
using Blazor.Interfaz.Interfaces;
using Blazor.Model;

namespace Blazor.Interfaz.Services
{
    public class FilmService : IFilmService
    {
        private IFilmRepository repository;
        private readonly ConfiguresSQL configSql;

        public FilmService(ConfiguresSQL configSql)
        {
            this.configSql = configSql;
            repository = new FilmRepository(configSql.ConnectionString);
        }

        public async Task<bool> Save(Film film)
        {
            if(film.id == 0)
            {
                return await repository.Create(film);
            }
            else
            {
                return await repository.Update(film.id, film);
            }
        }

        public async Task<bool> Delete(int Id)
        {
           return await repository.Delete(Id);
        }

        public async Task<IEnumerable<Film>> GetAll()
        {
            return await repository.GetAll();
        }

        public async Task<Film> GetFilm(int Id)
        {
            return await repository.GetFilm(Id);
        }

    }
}
