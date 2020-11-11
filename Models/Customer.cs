using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;


namespace rentManagement.Models
{
    public class Customer
    {
        // //Data member
        // private long _customerId;
        // private string _firstName;
        // private string _lastName;
        // private string _address;
        // private string _postalCode;
        // private string _city;
        // private string _idProof;
        // private double _deposit;
        
        //trying composition
        // private Rental _rental;
        public Customer(long customerId, string firstName, string lastName, string address, string postalCode, string city, string idProof, double deposit)
        {
            CustomerId = customerId;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            PostalCode = postalCode;
            City = city;
            IdProof = idProof;
            Deposit = deposit;
        }

        //properties or access func
        public long CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string IdProof { get; set; }
        public double Deposit { get; set; }


        

    }
}