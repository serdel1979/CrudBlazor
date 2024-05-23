using Blazor.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Dapper.Repository
{
    public interface IFilmRepository
    {
        Task<IEnumerable<Film>> GetAll();

        Task<Film> GetFilm(int Id);

        Task<bool> Update(int Id, Film film);

        Task<bool> Delete(int Id);

        Task<bool> Create(Film film);

    }
}
