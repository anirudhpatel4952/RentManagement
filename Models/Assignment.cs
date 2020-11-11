using System;

namespace rentManagement.Models
{
    public class Assignment
    {
        public Assignment(long assignId, Rental rental, Customer customer, bool isAssigned) 
        {
            this.AssignId = assignId;
            this.rental = rental;
            this.customer = customer;
            this.IsAssigned = isAssigned;
               
        }
        public long AssignId { get; set; }
        public Rental rental{ get; set; }
        public Customer customer { get; set; }
        public bool IsAssigned { get; set; }
    }
}