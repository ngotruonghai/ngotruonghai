namespace model.Emtity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Giaovien")]
    public partial class Giaovien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Giaovien()
        {
            Tailieux = new HashSet<Tailieu>();
        }

        [Key]
        [StringLength(15)]
        public string magiaovien { get; set; }

        [StringLength(10)]
        public string manganh { get; set; }

        [StringLength(150)]
        public string tengiaovien { get; set; }

        [StringLength(15)]
        public string pass { get; set; }

        public virtual Nganh Nganh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tailieu> Tailieux { get; set; }
    }
}
