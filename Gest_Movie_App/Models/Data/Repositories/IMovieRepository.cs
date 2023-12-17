using Gest_Movie_App.Models.Data.Entities;

namespace Gest_Movie_App.Models.Data.Repositories
{
    public interface IMovieRepository
    {
        public void Insert(Movie movie);
    }
}
