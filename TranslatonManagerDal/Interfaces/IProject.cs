using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TranslatonManagerDal.Interfaces
{
    public interface IProject
    {
        int Id { get; set; }
        
        string Name { get; set; }
        
        string ProjectCode { get; set; }
        
        DateTime CreatedTime { get; set; }
        
        DateTime UpdateTime { get; set; }
        
        IEnumerable<ICategory> Categories { get; set; }
        
        IEnumerable<ILanguage> Languages { get; set; }
        
        // Methods
        IDictionary<string, IDictionary<string, ITranslation>> GetTranslationsByLanguageKey(string LanguageKey);
        
        IDictionary<string, IDictionary<string, ITranslation>> GetAllLanguagesTranslations();
        
        Task<IProject> Get(string ProjectCode);
        void Save();
        void Delete();
    }
}