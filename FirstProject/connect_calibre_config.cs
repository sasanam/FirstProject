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
    
    public partial class connect_calibre_config
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public connect_calibre_config()
        {
            this.tile_group = new HashSet<tile_group>();
        }
    
        public int id { get; set; }
        public int id_calibre_config_1 { get; set; }
        public int id_calibre_config_2 { get; set; }
        public int id_calibre_config_3 { get; set; }
        public Nullable<int> id_calibre_config_4 { get; set; }
        public Nullable<int> id_calibre_config_5 { get; set; }
        public Nullable<int> id_calibre_config_6 { get; set; }
        public Nullable<int> id_calibre_config_7 { get; set; }
    
        public virtual config_calibre config_calibre { get; set; }
        public virtual config_calibre config_calibre1 { get; set; }
        public virtual config_calibre config_calibre2 { get; set; }
        public virtual config_calibre config_calibre3 { get; set; }
        public virtual config_calibre config_calibre4 { get; set; }
        public virtual config_calibre config_calibre5 { get; set; }
        public virtual config_calibre config_calibre6 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tile_group> tile_group { get; set; }
    }
}