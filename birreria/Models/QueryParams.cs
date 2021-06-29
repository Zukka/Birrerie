using Refit;
namespace birreria.Models
{
    public class QueryParams
    {
        [AliasAs("by_type")]
        public string ByType { get; set; }

        public QueryParams(string byType)
        {
            ByType = byType;
        }
    }
}
