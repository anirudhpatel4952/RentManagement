using System;
using System.Collections.Generic;
using rentManagement.Models;

namespace rentManagement
{
    public class RentManagementSystem
    {
        //functions will come here
        public RentManagementSystem()
        {
            //list of customers living in apt4
            _customersApt4List = new List<Customer>();
            // _customersApt5List = new List<Customer>();
            
            //creating the customer(CUSTOMES OBJECTS)
            Customer customerApt4Unit1 = 
            new Customer(400, "Jay", "Bhai", "01-4100 Rae Street", "S4S3A0", "Regina", "Driver's License", 450);

            Customer customer2Apt4Unit1 = 
            new Customer(401, "Jayshree", "Ben", "01-4100 Rae Street", "S4S3A0", "Regina", "Driver's License", 450);

            Customer customerApt4Unit2 = 
            new Customer(500, "Jayesh", "Kumar", "02-4100 Rae Street", "S4S3A2", "Regina", "Driver's License", 400);

            Customer customer2Apt4Unit2 = 
            new Customer(501, "Jaya", "Kumari", "02-4100 Rae Street", "S4S3A2", "Regina", "Driver's License", 400);
            
            //creating the rental apartment
            Rental firstApartment_unit1 = new Rental(4100, 01, 2, 900);
            Rental firstApartment_unit2 = new Rental(4100, 01, 2, 900);
            Rental secondApartment_unit1 = new Rental(5100, 01, 2, 800);
            Rental secondApartment_unit2 = new Rental(5100, 01, 2, 800);

            // Rental apartment = (Rental)new Customer(1000, "test", "subject", "abc", "123abc", "regina", "sask id", 700);
            //adding the customers in the customer list
            _customersApt4List.Add(customerApt4Unit1);
            _customersApt4List.Add(customer2Apt4Unit1);

            _customersApt4List.Add(customerApt4Unit2);
            _customersApt4List.Add(customer2Apt4Unit2);

            //adding the apartments in the apartment lists
            _firstApartment.Add(firstApartment_unit1);
            _firstApartment.Add(firstApartment_unit2);
            _secondApartment.Add(secondApartment_unit1);
            _secondApartment.Add(secondApartment_unit2);

            //adding the customers to a specific apartment
            _firstApartment.AddRange(_customersApt4List); //not woorking since different types
        }
        
        //list of customers in apartment4100
        private List<Customer> _customersApt4List;
        
         //list customers in apartment5100
        private List<Customer> _customersApt5List;

        //list of apartments
        private List<Rental> _firstApartment;
        private List<Rental> _secondApartment;
        
        public Customer AddACustomer(long customerId, string firstName, string lastName, string address, string postalCode, string city, string idProof, double deposit){
            
            var customer = new Customer(customerId, firstName, lastName, address, postalCode, city, idProof, deposit);

            return null;
        }
        public void DeleteACustomer(){
            System.Console.WriteLine("Customer Deleted");
        }
    }
}