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
    
    public partial class tile_calibre_grade
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tile_calibre_grade()
        {
            this.tiles = new HashSet<tile>();
        }
    
        public int id { get; set; }
        public System.DateTime time_stamp { get; set; }
        public int grade_difference_a { get; set; }
        public int grade_difference_b { get; set; }
        public int grade_parallelism_a { get; set; }
        public int grade_parallelism_b { get; set; }
        public int grade_curvat_a { get; set; }
        public int grade_curvat_b { get; set; }
        public int grade_curvat_x2_a { get; set; }
        public int grade_curvat_x2_b { get; set; }
        public int grade_ortogon { get; set; }
        public int grade_calibre { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tile> tiles { get; set; }
    }
}
