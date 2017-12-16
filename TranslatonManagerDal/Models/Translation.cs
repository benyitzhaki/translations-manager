using System;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;
using TranslatonManagerDal.Interfaces;

namespace TranslatonManagerDal.Models
{
    public class Translation : ITranslation
    {
        [BsonId]
        public int Id { get; set; }
        
        [Required]
        [BsonElement("project_id")]
        public int ProjectId { get; set; }
        
        [Required]
        [BsonElement("translation_key")]
        public string TranslationKey { get; set; }
        
        [BsonElement("description")]
        public string Description { get; set; }
        
        [BsonElement("create_time")]
        public DateTime CreatedTime { get; set; }
        
        [BsonElement("create_time")]
        public DateTime UpdateTime { get; set; }
    }
}