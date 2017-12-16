using System;
using System.Collections.Generic;

namespace TranslatonManagerDal.Interfaces
{
    public interface ILanguage
    {
        int Id { get; set; }
        
        int ProjectId { get; set; }
        
        string Name { get; set; }
        
        string LanguageKey { get; set; }
        
        DateTime CreatedTime { get; set; }
        
        DateTime UpdateTime { get; set; }
        
        IEnumerable<ITranslation> Translations { get; set; }
    }
}