namespace model.Emtity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Nganh")]
    public partial class Nganh
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Nganh()
        {
            Giaovien = new HashSet<Giaovien>();
            Sinhvien = new HashSet<Sinhvien>();
            Thoikhoabieu = new HashSet<Thoikhoabieu>();
        }

        [Key]
        [StringLength(10)]
        public string manganh { get; set; }

        [StringLength(150)]
        public string tennganh { get; set; }

        [StringLength(150)]
        public string khoahoc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Giaovien> Giaovien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sinhvien> Sinhvien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Thoikhoabieu> Thoikhoabieu { get; set; }
    }
}
