using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;
using TranslatonManagerDal.Interfaces;

namespace TranslatonManagerDal.Models
{
    public class Project : IProject
    {
     
        [BsonId]
        public int Id { get; set; }

        [BsonElement("name")]
        [Required]
        public string Name { get; set; }

        // used to identify the project via api
        [Required]
        [BsonElement("project_code")]
        public string ProjectCode { get; set; }
        
        [BsonElement("update_time")]
        public DateTime CreatedTime { get; set; }
        
        [BsonElement("create_time")]
        public DateTime UpdateTime { get; set; }
        
        [BsonElement("categories")]
        public IEnumerable<ICategory> Categories { get; set; }
        
        [BsonElement("languages")]
        public IEnumerable<ILanguage> Languages { get; set; }
        
        public IDictionary<string, IDictionary<string, ITranslation>> GetTranslationsByLanguageKey(string LanguageKey)
        {
            throw new NotImplementedException();
        }

        public IDictionary<string, IDictionary<string, ITranslation>> GetAllLanguagesTranslations()
        {
            throw new NotImplementedException();
        }
    }
}