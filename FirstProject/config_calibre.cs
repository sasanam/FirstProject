//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FirstProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class config_calibre
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public config_calibre()
        {
            this.connect_calibre_config = new HashSet<connect_calibre_config>();
            this.connect_calibre_config1 = new HashSet<connect_calibre_config>();
            this.connect_calibre_config2 = new HashSet<connect_calibre_config>();
            this.connect_calibre_config3 = new HashSet<connect_calibre_config>();
            this.connect_calibre_config4 = new HashSet<connect_calibre_config>();
            this.connect_calibre_config5 = new HashSet<connect_calibre_config>();
            this.connect_calibre_config6 = new HashSet<connect_calibre_config>();
        }
    
        public int id { get; set; }
        public System.DateTime time_stamp { get; set; }
        public double difference_a { get; set; }
        public double difference_b { get; set; }
        public double parallelism_a { get; set; }
        public double Parallelism_b { get; set; }
        public double curvat_a { get; set; }
        public double curvat_b { get; set; }
        public double curvat_x2_a { get; set; }
        public double curvat_x2_b { get; set; }
        public double ortogon { get; set; }
        public int grade_config { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<connect_calibre_config> connect_calibre_config { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<connect_calibre_config> connect_calibre_config1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<connect_calibre_config> connect_calibre_config2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<connect_calibre_config> connect_calibre_config3 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<connect_calibre_config> connect_calibre_config4 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<connect_calibre_config> connect_calibre_config5 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<connect_calibre_config> connect_calibre_config6 { get; set; }
    }
}
