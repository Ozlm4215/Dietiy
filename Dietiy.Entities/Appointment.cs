using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Dietiy.Entities
{
    public class Appointment 
    {
        [Key]
        public int Id { get; set; }

        public DateTime DateTime { get; set; }

        public  Client Client { get; set; }
        public Nutritionist Nutritionist { get; set; }

        public string Number { get; set; }
        public string CustomNote1 { get; set; }

    }
}
