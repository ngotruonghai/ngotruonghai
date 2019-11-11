namespace model.Emtity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tuyendung")]
    public partial class Tuyendung
    {
        public int id { get; set; }

        [StringLength(150)]
        public string img { get; set; }

        [StringLength(150)]
        public string tieude { get; set; }

        public string vanban { get; set; }

        [StringLength(150)]
        public string meta { get; set; }

        public bool? hide { get; set; }
    }
}
