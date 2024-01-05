using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.Models
{
    //Member model class contains the information of the members of the library
    public class Member : BaseModel
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string EmailAddress { get; set; }
        public string CardNo { get; set; }
    }
}