using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bigschool.Models
{
    public class course
    {
        public int id { get; set; }
        public ApplicationUser lecturer { get; set;  }
        [Required]
        public string Lecturer  { get; set;  }
        [Required]
        [StringLength(255)]
        public string Place { get; set; }
        public DateTime DateTime { get; set; }
        public Category  Category { get; set; }
        [Required]
        public byte CategoryID { get; set; } 
    }
   
    //internal class stringlengthAttribute : Attribute
    //{
    //    private int v;

    //    public stringlengthAttribute(int v)
    //    {
    //        this.v = v;
    //    }
    //}

    //internal class requiredAttribute : Attribute
    //{
    //}
}