using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Xml.Linq;

namespace Library.Models
{
    //The Checkout class contains the attributes related to the books checked out by the library members

    public class Checkout : BaseModel
    {       
        [Display(Name = "Book")]
        public int BookId { get; set; }
        [ForeignKey("BookId")]
        public Book Book { get; set; }
        [Display(Name = "Member")]
        public int MemberId { get; set; }
        [ForeignKey("MemberId")]
        public Member Member { get; set; }
        public DateTime CheckoutDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public bool IsReturned { get; set; }
      
    }
}