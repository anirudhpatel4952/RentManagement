using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace rentManagement.Models
{
    public class Utility
    {
        //Data members
        private double _propertyTax;
        private double _waterBill;
        private double _powerBill;
        private double _internetBill;

        //constructor - rent will include all this service
        public Utility(double propertyTax, double waterBill, double powerBill, double internetBill)
        {
            _propertyTax = propertyTax;
            _waterBill = waterBill;
            _powerBill = powerBill;
            _internetBill = internetBill;
        }
        public Utility(double propertyTax, double waterBill)
        {
            _propertyTax = propertyTax;
            _waterBill = waterBill;
        }
        //Properties or access func
        public double PropertyTax { get => _propertyTax; set => _propertyTax = value; }
        public double WaterBill { get => _waterBill; set => _waterBill = value; }
        public double PowerBill { get => _powerBill; set => _powerBill = value; }
        public double InternetBill { get => _internetBill; set => _internetBill = value; }
    }
}