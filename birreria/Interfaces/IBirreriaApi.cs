using System.Collections.Generic;
using System.Threading.Tasks;
using birreria.Models;
using Refit;

namespace birreria.Interfaces
{
    public interface IBirreriaApi
    {
        [Get("/breweries")]
        Task<List<Birreria>> GetBirrerie();

        [Get("/breweries/by_type={type}")]
        Task<List<Birreria>> GetBirrerie(string type);

        [Get("/breweries")]
        Task<List<Birreria>> GetBirrerie(QueryParams queryParams);
    }
}
