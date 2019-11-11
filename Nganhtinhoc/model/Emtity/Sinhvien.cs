namespace model.Emtity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sinhvien")]
    public partial class Sinhvien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sinhvien()
        {
            Diemsinhvien = new HashSet<Diemsinhvien>();
        }

        [Key]
        [StringLength(12)]
        public string masinhvien { get; set; }

        [StringLength(10)]
        public string manganh { get; set; }

        [StringLength(50)]
        public string tensinhvien { get; set; }

        [StringLength(20)]
        public string pass { get; set; }

        public string meta { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Diemsinhvien> Diemsinhvien { get; set; }

        public virtual Nganh Nganh { get; set; }
    }
}
