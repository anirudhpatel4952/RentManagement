using System;
using System.Collections.Generic;
using rentManagement.Models;


namespace rentManagement.Storage
{
    public class AssignStorageList : IStoreAssignmentList
    {
        private List<Assignment> _innerList;

        public AssignStorageList() {
            _innerList = new List<Assignment>();
        }
        
        public void Create(Assignment newAssignment){
            _innerList.Add(newAssignment);
        }
        
        public List<Assignment> GetAll(){
            return _innerList;
        }

        public void Remove(Assignment assignmentToRemove){
            _innerList.Remove(assignmentToRemove);
        }
        
    }
}