using System;
using System.Collections.Generic;

namespace TranslationManagerApi.Interfaces
{
    public interface IProject
    {
        int Id { get; set; }
        string Name { get; set; }
        
        // used to identify the project via api
        string ProjectCode { get; set; }
        
        DateTime CreatedTime { get; set; }
        DateTime UpdateTime { get; set; }
        
        IList<ICategory> Categories { get; set; }
        IList<ILanguage> Languages { get; set; }
        
        // can i use here ILangKey.Code and ILanguage.LangKey instead of strings?
        IDictionary<string, IDictionary<string,ILangKey>> LangKeys { get; set; }
    }
}