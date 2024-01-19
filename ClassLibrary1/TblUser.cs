using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Mockup.datamodels
{
    [Table("tbl_user")]
    public partial class TblUser
    {
        [Key]
        [Column("userid")]
        public int Userid { get; set; }
        [Column("namalengkap")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Namalengkap { get; set; }
        [Column("username")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Username { get; set; }
        [Column("password")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Password { get; set; }
        [Column("status")]
        [StringLength(10)]
        [Unicode(false)]
        public string? Status { get; set; }
    }
}
