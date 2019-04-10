namespace ReplyRentACarSystem.Api.Models
{
    public class DesiredFeatures
    {
        public int Passengers { get; set; }
        public int MinYear { get; set; }
        public Engine Engine { get; set; }
        public InfotainSystem InfotainSystem { get; set; }

        public InteriorDesign InteriorDesign { get; set; }
    }

}
