namespace ClassLibrary1.emtity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Diemsinhvien")]
    public partial class Diemsinhvien
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(12)]
        public string masinhvien { get; set; }

        [StringLength(150)]
        public string monhoc { get; set; }

        public int? dieml1 { get; set; }

        public int? dieml2 { get; set; }

        public int? dieml3 { get; set; }

        public int? dieml4 { get; set; }

        [StringLength(50)]
        public string kq { get; set; }

        public virtual Sinhvien Sinhvien { get; set; }
    }
}
