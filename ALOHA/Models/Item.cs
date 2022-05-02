using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ALOHA.Models
{
    public class Item
    {
       public int ID { get; set; }
        [StringLength(60, MinimumLength=2)]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }= String.Empty;
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }  
        public int Quantity { get; set;}

        //[Range(1,100)]
        [DataType(DataType.Currency)]
       [Column(TypeName = "decimal(18,2")]
        public decimal  Price { get; set;}
    }
}
