using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Dietiy.Entities
{
    public class Food
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public int Calorie { get; set; }

        public int Protein { get; set; }
        public int Fat { get; set; }
        public int Carb { get; set; }
        public int Sugar { get; set; }
        public int Sodium { get; set; }

    }
}
