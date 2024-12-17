using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplicationExample_16_VM.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [RegularExpression("^[A-Z]{3,3}[0-9]{0,5}",ErrorMessage ="Productid is inavalid")]
        public string ProductId {  get; set; }

        [Required(ErrorMessage ="Empty product name is not allowed")]
        [MaxLength(30,ErrorMessage ="Name should be less than 30letters")]
        [MinLength(4,ErrorMessage ="Name should be greater than 4 letters")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Empty Quantity is not allowed")]
        [MaxLength(10,ErrorMessage ="Quantity is less than 10 letters")]
        public string Quantity {  get; set; }

        [Required(ErrorMessage ="Empty price is not allowed ")]
        [Range(0,100000,ErrorMessage ="Price should be in range 0 to 100000")]
        public int Price {  get; set; }

    }
}