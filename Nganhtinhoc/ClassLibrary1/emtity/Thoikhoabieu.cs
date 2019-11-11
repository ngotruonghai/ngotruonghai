namespace ClassLibrary1.emtity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Thoikhoabieu")]
    public partial class Thoikhoabieu
    {
        public int id { get; set; }

        [StringLength(10)]
        public string manganh { get; set; }

        [StringLength(150)]
        public string monhoc { get; set; }

        [StringLength(20)]
        public string thu { get; set; }

        [StringLength(50)]
        public string phong { get; set; }

        [StringLength(50)]
        public string naybatdau { get; set; }

        [StringLength(50)]
        public string ngayketthuc { get; set; }

        [StringLength(150)]
        public string giaoviengiangday { get; set; }

        public virtual Nganh Nganh { get; set; }
    }
}
