using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.Models
{
    //Author model class contains the name of the author
    //The primary key field is inherited from the BaseModel class
    public class Author : BaseModel
    {
        public string Name { get; set; }  
    }
}