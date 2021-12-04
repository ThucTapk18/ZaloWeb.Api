using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zaloweb.Data.Tables
{
    public class Friend
    {
        [Key]
        [Column(Order = 0)]
        [ForeignKey("LeftUser")]
        public int LeftId { get; set; }

        [Key]
        [Column(Order = 1)]
        [ForeignKey("RightUser")]
        public int RightId { get; set; }

        

        [Required]
        public DateTime StartDate { get; set; }

        public virtual User LeftUser { get; set; }
        public virtual User RightUser { get; set; }
    }
}
