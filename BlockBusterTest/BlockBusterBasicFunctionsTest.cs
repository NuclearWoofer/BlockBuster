using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using BlockBuster.Models;
using BlockBuster;

namespace BlockBusterTest
{
    //Make sure we make these classes public.
    public class BlockBusterBasicFunctionsTest
    {
        [Fact]
        public void GetMovieByIdTest()
        {
            var result = BlockBusterBasicFunctions.GetMovieById(11);
            Assert.True(result.Title == "Vertigo");
            Assert.True(result.ReleaseYear == 1958);
              
        }

        [Fact]
        public void GetAllMoviesTest()
        {
            var result = BlockBusterBasicFunctions.GetAllMovies();
            Assert.True(result.Count == 49);
        }

        [Fact]
        public void GetAllCheckedOutMovies()
        {
            var result = BlockBusterBasicFunctions.GetAllCheckedOutMovies();
            Assert.True(result.Count == 3);
        }

        //Get all movue by Genre Description
        [Fact]
        public void GetMoviesByGenreDescriptionTest()
        {
            var result = BlockBusterBasicFunctions.GetMoviesByGenreDescription();
            Assert.True(result.GenreId);
        }
        //Get all movies by Director Last Name
        [Fact]
        public void GetMoviesByLastNameTest()
        {
            var result = BlockBusterBasicFunctions.GetMovieByLastName();
            Assert.True(result.Director.LastName == "Hitchcock");
        }
    }
}
