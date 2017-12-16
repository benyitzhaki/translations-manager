using System;

namespace TranslationManagerApi.Interfaces
{
    public interface ILangKey
    {
        int Id { get; set; }
        int ProjectId { get; set; }
        
        // code used in our application as key for translation (for example: "Error.MissingFirstName")
        string KeyCode { get; set; }
        
        string Description { get; set; }
        
        DateTime CreatedTime { get; set; }
        DateTime UpdateTime { get; set; }
    }
}