using System;

namespace TranslatonManagerDal.Interfaces
{
    public interface ICategory
    {
        int Id { get; set; }
        int ProjectId { get; set; }
        string Name { get; set; }  
        string Description { get; set; }

        DateTime CreatedTime { get; set; }
        DateTime UpdateTime { get; set; }
    }
}