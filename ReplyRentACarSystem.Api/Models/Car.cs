using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReplyRentACarSystem.Api.Models
{
    public class Car
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string GalleryURL { get; set; }
        public int Passengers { get; set; }
        public Engine Engine { get; set; }
        public InfotainSystem InfotainSystem { get; set; }
        public InteriorDesign InteriorDesign { get; set; }
        public CurrentLocation CurrentLocation { get; set; }
    }
}
