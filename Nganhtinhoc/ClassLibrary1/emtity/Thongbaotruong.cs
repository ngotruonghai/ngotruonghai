namespace ClassLibrary1.emtity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Thongbaotruong")]
    public partial class Thongbaotruong
    {
        public int id { get; set; }

        public string meta { get; set; }

        [StringLength(150)]
        public string tieude { get; set; }

        public string vanban { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngay { get; set; }

        public bool? hide { get; set; }
    }
}
