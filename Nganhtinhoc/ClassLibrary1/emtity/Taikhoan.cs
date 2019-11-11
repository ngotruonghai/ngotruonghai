namespace ClassLibrary1.emtity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Taikhoan")]
    public partial class Taikhoan
    {
        [Key]
        [StringLength(50)]
        public string user { get; set; }

        [StringLength(150)]
        public string password { get; set; }
    }
}
