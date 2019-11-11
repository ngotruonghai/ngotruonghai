namespace ClassLibrary1.emtity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Thongbao")]
    public partial class Thongbao
    {
        public int id { get; set; }

        [StringLength(150)]
        public string tieude { get; set; }

        public string vanban { get; set; }

        [StringLength(150)]
        public string img { get; set; }

        public string meta { get; set; }

        public string gioithieu { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngay { get; set; }

        public bool? hide { get; set; }
    }
}
