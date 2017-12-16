using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;
using TranslatonManagerDal.Interfaces;

namespace TranslatonManagerDal.Models
{
    public class Language : ILanguage
    {
        [BsonId]
        public int Id { get; set; }
        
        [Required]
        [BsonElement("project_id")]
        public int ProjectId { get; set; }
        
        [Required]
        [BsonElement("name")]
        public string Name { get; set; }
        
        [Required]
        [BsonElement("lang_key")]
        public string LanguageKey { get; set; }
        
        [BsonElement("create_time")]
        public DateTime CreatedTime { get; set; }
        
        [BsonElement("update_time")]
        public DateTime UpdateTime { get; set; }
        
        [BsonElement("translations")]
        public IEnumerable<ITranslation> Translations { get; set; }
    }
}