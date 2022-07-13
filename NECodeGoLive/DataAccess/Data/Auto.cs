using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class Auto
    {
        [Key]
        public int Id { get; set; }

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Door { get; set; }
        public bool IsElectric { get; set; }
        public int FuelEfficiencyCity { get; set; }
        public int FuelEfficiencyHighway { get; set; }
        public string ExteriorColor { get; set; }
        public string InteriorColor { get; set; }
        public string Engine { get; set; }
        public string DriveTrain { get; set; }

        //TODO:
        //public double Price { get; set; }

    }
}
