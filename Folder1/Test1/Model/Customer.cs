using System;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Test1.Model
{
    public class Customer
    {
         [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Name")]
        [Required]
        public string Name { get; set; }

        [BsonElement("DTB")]
        [Required]
        // [YearRange]
        [DataType(DataType.Date)]
        public DateTime DTB { get; set; }

       

      [BsonElement("Address")]
        [Required]
        public string Address { get; set; }

        [BsonElement("ImageUrl")]
        [Display(Name = "Photo")]
        [DataType(DataType.ImageUrl)]
        [Required]
        public string ImageUrl { get; set; }
    }
}