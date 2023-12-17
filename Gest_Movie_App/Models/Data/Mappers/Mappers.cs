﻿using Gest_Movie_App.Models.Data.Entities;
using System.Data.Common;

namespace Gest_Movie_App.Models.Data.Mappers
{
    internal static class Mappers
    {
        internal static Movie ToMovie(this DbDataReader reader)
        {
            return new Movie()
            {
                Id = (int)reader["Id"],
                Nom = (string)reader["Nom"],
                Annee = (int)reader["Annee"],
                Realisateur = (string)reader["Realisateur"]
            };
        }
    }
}
