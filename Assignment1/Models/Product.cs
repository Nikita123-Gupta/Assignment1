using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Assignment1.Models
{
    public class Product
    {
        [Required(ErrorMessage =" Product Id Required")]
        public string Pid { get; set; }

        [Required(ErrorMessage = " Product name Required")]
        public string Pname { get; set; }

        [Required(ErrorMessage = " Price Required")]
        public string Price { get; set; }

        [Required(ErrorMessage = " Stock Required")]
        public int Stock { get; set; }

    }
}
