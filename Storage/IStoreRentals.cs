using System;
using System.Collections.Generic;
using rentManagement.Models;

namespace rentManagement.Storage
{
    public interface IStoreRentals
    {
        
        List<Rental> GetRentals();
       

        Rental DisplayAllRentalByUnitNum(int unitToSearchByUnitNum);

    }
}