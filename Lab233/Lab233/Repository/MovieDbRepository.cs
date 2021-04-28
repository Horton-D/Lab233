using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Lab233.Data.Model;

namespace Lab233.Repository
{
    public class MovieDbRepository : IMovieRepository
    {
        public Task Add(Movie movie)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Exists(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Movie>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<Movie> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Movie movie)
        {
            throw new NotImplementedException();
        }
    }
}
