using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dreamscape.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public bool ClubMember { get; set; }

        public DateTime DOB { get; set; }

        public bool IsActive { get; set; }

        public DateTime TimeUpdated { get; set; }

        public int CreatedBy { get; set; }

        public string FullName { get {

                return FirstName + " " + LastName;
            } 
        }

    }
}
