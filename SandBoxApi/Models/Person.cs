using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SandBoxApi.Models
{
    public class Person
    {        
        [Key]
        public int Id { get; set; }
        public string RfId { get; set; }
        public int LocationId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}