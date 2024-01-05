using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.Models
{
    //Category class contains the categories of the books
    public class Category : BaseModel
    {
        public string Name { get; set; }
    }
}