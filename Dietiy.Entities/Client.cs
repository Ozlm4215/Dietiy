using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Dietiy.Entities
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        public string Gender { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Image { get; set; }
        public int Email { get; set; }
        public string Phone { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string IdentityNo { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }

        public Nutritionist Nutritionist{ get; set; }

        public virtual IEnumerable<Appointment> Appointments { get; set; }


    }
}
