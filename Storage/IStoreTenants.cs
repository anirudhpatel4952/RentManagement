using System;
using System.Collections.Generic;

using rentManagement.Models;

namespace rentManagement.Storage
{
    public interface IStoreTenants
    {
         
        Tenant Create(long tenantId, string firstName, string lastName, string address, string postalCode, string city, string idProof, double deposit, bool isAssigned);

        Tenant RemoveById(long tenantIdInput);
        

        List<Tenant> GetAll();

        Tenant GetById(long tenantToSearchById);
        
    }
}

    
