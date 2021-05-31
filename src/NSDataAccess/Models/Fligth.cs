using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace NSDataAccess.Models
{
    public class Fligth
    {
        [Key]
        public int Id { get; set; }
        public String DepartureStation {get;set;}
        public String ArrivalStation { get; set; }
        public String Currency { get; set; }
        public Decimal Price { get; set; }
        public virtual Transport Transport { get; set; }
    }
}
