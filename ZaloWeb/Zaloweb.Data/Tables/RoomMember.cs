using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zaloweb.Data.Tables
{
    public class RoomMember
    {
        [Key]
        [ForeignKey("rId")]
        public int roomId { get; set; }

        [ForeignKey("usId")]
        public int userId { get; set; }

        [Required]
        public long roleId { get; set; }

        public virtual Room rId { get; set; }
        public virtual User usId { get; set; }
    }
}
