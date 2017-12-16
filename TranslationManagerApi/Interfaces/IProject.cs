using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;

namespace TranslationManagerApi.Interfaces
{
    public interface IProject
    {
        [BsonId]
        int Id { get; set; }
        
        [Required]
        [BsonElement("name")]
        string Name { get; set; }
        
        // used to identify the project via api
        [Required]
        [BsonElement("project_code")]
        string ProjectCode { get; set; }
        
        [BsonElement("update_time")]
        DateTime CreatedTime { get; set; }
        
        [BsonElement("create_time")]
        DateTime UpdateTime { get; set; }
        
        [BsonElement("categories")]
        IEnumerable<ICategory> Categories { get; set; }
        
        [BsonElement("languages")]
        IEnumerable<ILanguage> Languages { get; set; }
        
        // can i use here ILangKey.Code and ILanguage.LangKey instead of strings?
        IDictionary<string, IDictionary<string, ILangKey>> GeTranslationKeysByLanguage(string LanguageCode);

        IDictionary<string, IDictionary<string, ILangKey>> GeTranslationKeys();
    }
}