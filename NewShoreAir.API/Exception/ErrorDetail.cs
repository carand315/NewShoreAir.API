using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace NewShoreAir.API.Exception
{
    public class ErrorDetail
    {
        public string Message { get; set; }
        public int StatusCode { get; set; }
        public DateTime GeneratedDate { get; set; }

        public ErrorDetail()
        {

        }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
