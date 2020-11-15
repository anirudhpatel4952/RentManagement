using System;
using System.Collections.Generic;
using rentManagement.Models;


namespace rentManagement.Storage
{
    public interface IStoreAssignmentList
    {   
        void Create(Assignment newAssignment);
        
        List<Assignment> GetAll();

        void Remove(Assignment assignmentToRemove);
        
    }
}