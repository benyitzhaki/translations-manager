using System;
using System.Collections.Generic;

namespace TranslationManagerApi.Interfaces
{
    public interface ILanguage
    {
        int Id { get; set; }
        int ProjectId { get; set; }
        string Name { get; set; }
        
        // used to identify the language by api (for English we would use en)
        string LangCode { get; set; }
        
        DateTime CreatedTime { get; set; }
        DateTime UpdateTime { get; set; }
        
        IList<ILangKey> LangKeys { get; set; }
    }
}