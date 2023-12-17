using Gest_Movie_App.Models.Data.Entities;
using Gest_Movie_App.Models.Data.Repositories;
using Microsoft.Data.SqlClient;

namespace Gest_Movie_App.Models.Data.Services
{
    public class MovieService : IMovieRepository
    {
        public void Insert(Movie movie)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = @"";
            }
        }
    }
}
