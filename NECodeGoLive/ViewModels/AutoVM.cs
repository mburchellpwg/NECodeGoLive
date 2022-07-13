using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class AutoVM
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Error: Make required")]
        public string Make { get; set; } = null;
        [Required(ErrorMessage = "Error: Model required")]
        public string Model { get; set; } = null;
        [Range(1900, 2048, ErrorMessage = "Error: Year range invalid")]
        public int Year { get; set; }
    }
}
