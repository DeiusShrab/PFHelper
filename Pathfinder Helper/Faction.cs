//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pathfinder_Helper
{
    using System;
    using System.Collections.Generic;
    
    public partial class Faction
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Faction()
        {
            this.Factions1 = new HashSet<Faction>();
            this.Locations = new HashSet<Location>();
            this.Territories = new HashSet<Territory>();
        }
    
        public int FactionId { get; set; }
        public Nullable<int> ContinentId { get; set; }
        public string Name { get; set; }
        public string Language { get; set; }
        public Nullable<int> Parent_Faction { get; set; }
        public string Primary_Race { get; set; }
        public string Type { get; set; }
    
        public virtual Continent Continent { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Faction> Factions1 { get; set; }
        public virtual Faction Faction1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Location> Locations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Territory> Territories { get; set; }
    }
}
