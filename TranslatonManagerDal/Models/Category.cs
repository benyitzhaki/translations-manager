using System;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;
using TranslatonManagerDal.Interfaces;

namespace TranslatonManagerDal.Models
{
    public class Category : ICategory
    {
        [BsonId]
        public int Id { get; set; }
        
        [Required]
        [BsonElement("project_id")]
        public int ProjectId { get; set; }
        
        [Required]
        [BsonElement("name")]
        public string Name { get; set; }
        
        [BsonElement("description")]
        public string Description { get; set; }
        
        [BsonElement("create_time")]
        public DateTime CreatedTime { get; set; }
        
        [BsonElement("update_time")]
        public DateTime UpdateTime { get; set; }
    }
}