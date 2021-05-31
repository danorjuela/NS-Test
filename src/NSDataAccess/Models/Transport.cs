using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace NSDataAccess.Models
{
    public class Transport
    {
        [Key]
        public int Id { get; set; }
        public String FligthNumber { get; set; }

        [ForeignKey("FligthFk")]
        [InverseProperty("Transport")]
        public virtual ICollection<Fligth> Fligths { get; set; }
    }
}
