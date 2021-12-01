//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace SunshineAirlines1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Aircraft
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Aircraft()
        {
            this.Schedules = new HashSet<Schedule>();
            this.SeatLayouts = new HashSet<SeatLayout>();
        }
    
        public int AircraftId { get; set; }
        public string Name { get; set; }
        public string FirstSeatsLayout { get; set; }
        public int FirstSeatsAmount { get; set; }
        public string BusinessSeatsLayout { get; set; }
        public int BusinessSeatsAmount { get; set; }
        public string EconomySeatsLayout { get; set; }
        public int EconomySeatsAmount { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Schedule> Schedules { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SeatLayout> SeatLayouts { get; set; }
    }
}
