using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Lab233.Data.Model;

namespace Lab233.Repository
{
    public interface IMovieRepository
    {

        Task Add(Movie movie);
        Task Delete(int id);
        Task<bool> Exists(int id);
        Task<List<Movie>> Get();
        Task<Movie> Get(int id);
        Task Update(Movie movie);
    }
}
