//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Nganhtinhoc.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Thoikhoabieu
    {
        public int id { get; set; }
        public string manganh { get; set; }
        public string monhoc { get; set; }
        public string thu { get; set; }
        public string phong { get; set; }
        public string naybatdau { get; set; }
        public string ngayketthuc { get; set; }
        public string giaoviengiangday { get; set; }
    
        public virtual Nganh Nganh { get; set; }
    }
}
