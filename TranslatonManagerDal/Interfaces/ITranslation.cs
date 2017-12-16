using System;

namespace TranslatonManagerDal.Interfaces
{
    public interface ITranslation
    {
        int Id { get; set; }

        int ProjectId { get; set; }
        
        string TranslationKey { get; set; }
        
        string Description { get; set; }
        
        DateTime CreatedTime { get; set; }
        DateTime UpdateTime { get; set; }
    }
}