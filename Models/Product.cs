using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreFakture.Models
{
    public class Product
    {
        public int ProductID { get; set; }

        [Required]
        [StringLength(40)]
        public string ProductName { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("UnitPrice", TypeName = "money")]
        public decimal? Cost { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("UnitsInStock")]
        public short? Stock { get; set; }

        public bool Discontinued { get; set; }

        // these two define the foreing key relationship
        // to the Categories table
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

    }
}
