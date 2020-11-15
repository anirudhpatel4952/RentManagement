using System;
using System.Collections.Generic;
using rentManagement.Models;

namespace rentManagement.Storage
{
    public class RentalStorageList : IStoreRentals
    {
        private List<Rental> _apartmentUnitsList;
        public RentalStorageList()
        {
            _apartmentUnitsList = new List<Rental>();
        }
        public void Create(Rental unitToCreate){
            _apartmentUnitsList.Add(unitToCreate);
        }
        public List<Rental> GetAll(){
            return _apartmentUnitsList;
        }

        public Rental GetByUnitNum(int unitToSearchByUnitNum) {
            for (int i = 0; i < _apartmentUnitsList.Count;i++) {
                var unit = _apartmentUnitsList[i];
                if (unitToSearchByUnitNum == unit.Unit){
                    return unit;
                }
                
            }
            return null;
        }

    }
}