using AXA_Code_Test.Interfaces;
using AXA_Code_Test.Repository;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXA_Code_Test.Classes
{
    public class CityFinder : ICityFinder
    {
        private readonly ICityRepository _cityRepository;

        public CityFinder(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }

        public ICityResult Search(string searchTerm)
        {
            /* Lowing string to keep it consistent, will do the same for data set */
            string lowerSearchTerm = searchTerm.ToLower();

            /* Store length in int. As arrays are 0 index based, a 4 character search term will
             * will give 5th character in the array which will be the next character needed for the NextLetters collection. 
             */
            int nextCharacterPosition = searchTerm.Length;

            List<string> cities = _cityRepository
                             .GetCities().Where(x => x.ToLower().StartsWith(lowerSearchTerm)).ToList();

            ICityResult cityResult = new CityResult();

            /*
                Parallel Foreach, unlike a standard Foreach, 
                do multiple operations together to help speed up to process, utilising multithreading.
                This will help with large datasets.
                
                Leaving this in commented as it's something I've tried but the returned is inconsistent/wrong.

                ConcurrentBag<ICityResult> searchResults = SearchConcurrent(cities, nextCharacterPosition);
             */

            cities.ForEach(x =>
            {
                cityResult.NextCities.Add(x);
                cityResult.NextLetters.Add(x[nextCharacterPosition].ToString());
            });

            return cityResult;
        }


        public static ConcurrentBag<ICityResult> SearchConcurrent(List<string> cities, int nextCharacterPosition)
        {
            var result = new ConcurrentBag<ICityResult>();

            ICityResult cityResult = new CityResult();

            Parallel.ForEach(cities, x =>
            {
                cityResult.NextCities.Add(x);
                cityResult.NextLetters.Add(x[nextCharacterPosition].ToString());

            });
            result.Add(cityResult);
            return result;
        }
    }
}
