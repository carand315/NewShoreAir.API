using NewShoreAir.Business.Base;
using System.Text.Json.Serialization;

namespace NewShoreAir.Business.Models
{
    public class Flight : Trip
    {
        public int Id { get; set; }
        public virtual Transport Transport { get; set; }
        [JsonIgnore]
        public int TransportId { get; set; }
        [JsonIgnore]
        public Journey Journey { get; set; }
        public Flight()
        {
            this.Transport = new Transport();
        }

    }
}
