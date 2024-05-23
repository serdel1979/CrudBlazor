using Blazor.Model;

namespace Blazor.Interfaz.Interfaces
{
    public interface IFilmService
    {
        Task<IEnumerable<Film>> GetAll();

        Task<Film> GetFilm(int Id);

        Task<bool> Delete(int Id);

        Task<bool> Save(Film film);
    }
}
