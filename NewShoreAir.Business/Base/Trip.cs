namespace NewShoreAir.Business.Base
{
    public abstract class Trip
    {
        public string Origin { get; set; }
        public string Destination { get; set; }
        public double Price { get; set; }
    }
}
