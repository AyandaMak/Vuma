using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Library.Models
{
    //The base model class is inherited by all the model classes.
    //BaseModel class is defined to add attributes for all model class
    //BaseModel class can be used to define audit fields CreatedByUser , CreatedDateTime, ModifiedByUser and ModifiedDateTime
    public class BaseModel
    {
        //Primary key value
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Id")]
        public int Id { get; set; }
    }
}