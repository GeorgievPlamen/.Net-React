using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using API.RequestHelpers;

namespace API.Extensions
{
    public static class HttpExtensions
    {
        public static void AddPaginationHeader(this HttpResponse repsonse, MetaData metaData)
        {
            var options = new JsonSerializerOptions{PropertyNamingPolicy = JsonNamingPolicy.CamelCase};
            
            repsonse.Headers.Add("Pagination", JsonSerializer.Serialize(metaData, options));
            repsonse.Headers.Append("Access-Control-Expose-Headers", "Pagination");
        }
    }
}