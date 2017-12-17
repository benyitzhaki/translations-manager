using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using TranslatonManagerDal.Interfaces;

namespace TranslatonManagerDal.Models
{
    public class Project : IProject
    {
        private MonngoDbContext _context;
        
        public Project(IOptions<Settings> settings)
        {
            _context = new MonngoDbContext(settings);
        }
        
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
        public DateTime CreatedTime { get; set; }  = DateTime.Now;
        
        [BsonElement("create_time")]
        public DateTime UpdateTime { get; set; }  = DateTime.Now;
        
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

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }
        
        public async Task<IProject> Get(string ProjectCode)
        {
            var filter = Builders<IProject>.Filter.Eq("project_code", ProjectCode);

            try
            {
                return await _context.Projects
                    .Find(filter)
                    .FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                // log or manage the exception
                throw ex;
            }
        }
    }
}