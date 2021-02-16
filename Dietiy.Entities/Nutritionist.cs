using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Dietiy.Entities
{
    public class Nutritionist
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string LastName { get; set; }
        public int Email { get; set; }
        public string Phone { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string IdentityNo { get; set; }

        public virtual ICollection<Client> Clients { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }

      
    }
}
