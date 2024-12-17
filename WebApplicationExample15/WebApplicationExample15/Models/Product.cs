using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplicationExample15.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [RegularExpression("^[A-Z]{3,3}[0-9]{5,5}$",ErrorMessage ="Product Id is Invalid")]
        public string ProductId {  get; set; }

        [Required(ErrorMessage ="Product Name is Required")]
        [MaxLength(50,ErrorMessage ="Product Name length should be less than 50")]
        [MinLength(4,ErrorMessage ="Product Name length should be greater than 4 letters")]
        public string ProductName { get; set; }

        [Required(ErrorMessage ="Empty quantity is not allowed")]
        [MaxLength(10,ErrorMessage ="Quanttity should not be greater then 10")]
        public string Quantity {  get; set; }

        [Required(ErrorMessage ="Price is required")]
        [Range(1,10000,ErrorMessage ="Price is between 1 to 10000")]
        public int Price {  get; set; }

    }
}