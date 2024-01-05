using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Library.Models
{
    //Book model class contains the attributes related to a book in the library
    //There is a foreign key relationship to the Author model class to identify the author of the book.
    //There is a foreign key relationship to the Category model class to identify the category of the book.
    //The relationship can identify all books related to a particular author using the foreign key attribute.
    //The relationship can identify all books related to a particular category using the foreign key attribute.
    //Each copy of the book will be added to the table even if the same type the copy will be identified by the primary key or ISBN reference.
    public class Book : BaseModel
    {       
        public string Title { get; set; }
        [Display(Name = "Author")]
        public int AuthorId { get; set; }
        [ForeignKey("AuthorId")]
        public Author Author { get; set; }
        [Display(Name = "Category")]
        public int CatogoryId { get; set; }
        [ForeignKey("CatogoryId")]
        public Category Category { get; set; }
        public string ISBNReference { get; set; }
        public string publisher { get; set; }
        public bool Fiction { get; set; }
        public bool Checkedout { get; set; }
    }
}