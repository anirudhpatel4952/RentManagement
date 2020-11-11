using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace rentManagement.Models
{
    public class Rental
    {
        public Rental(int apartmentNum, int houseNum, double numOfRooms, double cost)
        {
            this.Apartment = apartmentNum;
            this.House = houseNum;
            this.NumberOfRoom = numOfRooms;
            this.Cost = cost;
        }
        // Data member
        //trying composition
        // private Customer customer;
        private int apartment;
        private int house; 
        private double numberofroom;
        private double cost;
        private double location;

        //properties
        public int Apartment { get; set; }
        public int House { get; set; }
        public double NumberOfRoom { get; set; }
        public double Cost { get; set; }
        // public double Location { get; set; }

        


    }
    
}