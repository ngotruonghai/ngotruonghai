namespace ClassLibrary1.emtity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tailieu")]
    public partial class Tailieu
    {
        public int id { get; set; }

        [StringLength(150)]
        public string tentailieu { get; set; }

        public string text { get; set; }

        public string file { get; set; }

        [StringLength(15)]
        public string magiaovien { get; set; }

        public virtual Giaovien Giaovien { get; set; }
    }
}
