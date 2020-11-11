using System;
using System.Collections.Generic;
using System.Text;
using rentManagement.Models;
using System.Linq;
namespace rentManagement
{
    public class RentManagementSystem
    {
        //functions will come here
        public RentManagementSystem()
        {
            
            //list of customers living in first apartment
            _customersFirstApartmentList = new List<Customer>();
            
            //list of units of first apartment
            _firstApartmentList = new List<Rental>();

            //creating the customer(CUSTOMES OBJECTS)
            Customer customerFirstApartmentUnit1 = 
            new Customer(400, "Jay", "Bhai", "01-4100 Rae Street", "S4S3A0", "Regina", "Driver's License", 900);

            Customer customerFirstApartmentUnit2 = 
            new Customer(401, "Jayshree", "Ben", "02-4100 Rae Street", "S4S3A0", "Regina", "Driver's License", 900);

            Customer customerFirstApartmentUnit3 = 
            new Customer(402, "Jayesh", "Kumar", "03-4100 Rae Street", "S4S3A0", "Regina", "Driver's License", 900);

            Customer customerFirstApartmentUnit4 = 
            new Customer(403, "Jaya", "Kumari", "04-4100 Rae Street", "S4S3A0", "Regina", "Driver's License", 900);
            
            
            //creating the rental apartment
            Rental firstApartment_unit1 = new Rental(4100, 01, 2, 900);
            Rental firstApartment_unit2 = new Rental(4100, 02, 2, 900);
            Rental firstApartment_unit3 = new Rental(4100, 03, 2, 900);
            Rental firstApartment_unit4 = new Rental(4100, 04, 2, 900);

            

            //an assignment of the apartment to a customer
            Assignment assignment1 = new Assignment(4004100, firstApartment_unit1, customerFirstApartmentUnit1, true);
            Assignment assignment2 = new Assignment(4014100, firstApartment_unit2, customerFirstApartmentUnit2, true);
            Assignment assignment3 = new Assignment(4024100, firstApartment_unit3, customerFirstApartmentUnit3, true);
            Assignment assignment4 = new Assignment(4034100, firstApartment_unit4, customerFirstApartmentUnit4, true);


            //adding the customers in the customer list
            _customersFirstApartmentList.Add(customerFirstApartmentUnit1);
            _customersFirstApartmentList.Add(customerFirstApartmentUnit2);
            _customersFirstApartmentList.Add(customerFirstApartmentUnit3);
            _customersFirstApartmentList.Add(customerFirstApartmentUnit4);


            //adding the apartments in the apartment lists
            _firstApartmentList.Add(firstApartment_unit1);
            _firstApartmentList.Add(firstApartment_unit2);
            _firstApartmentList.Add(firstApartment_unit3);
            _firstApartmentList.Add(firstApartment_unit4);

            //adding the customers to a specific apartment
            // _firstApartment.AddRange(_customersApt4List); //not woorking since different types
        }
        
            //list of customers in first apartment
            public List<Customer> _customersFirstApartmentList { get; private set; }  
        

            //list of apartments
            private List<Rental> _firstApartmentList;
        
        
        //end of constructor

        //method to add a customer 
        public Customer AddACustomer(long customerId, string firstName, string lastName, string address, string postalCode, string city, string idProof, double deposit){
            if (_customersFirstApartmentList.Count <= 8){
            var customer = new Customer(customerId, firstName, lastName, address, postalCode, city, idProof, deposit);
            _customersFirstApartmentList.Add(customer);
            return customer;
            }
           else{
                throw new Exception("Maximum only 8 units present, all the units are full");
            }
            
        }

        //method to delete a customer

        public Customer DeleteACustomer(long customerIdInput){
             
            for (var i = 0; i < _customersFirstApartmentList.Count; i++) {

                if (customerIdInput == _customersFirstApartmentList[i].CustomerId)
                {
                   var delCustomer = _customersFirstApartmentList;
                   delCustomer.RemoveAt(i);
                //    System.Console.WriteLine("cxremoved");
                   break;
                    
                }
                else {
                    throw new Exception("No Customer found, try a different Id");
                }
                      
            
            }
            return null;
            // System.Console.WriteLine("Customer Deleted");
            
        }
    }
}