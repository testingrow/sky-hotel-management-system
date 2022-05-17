//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelManagmentSystem.Models.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class tbl_room
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_room()
        {
            this.tbl_booking = new HashSet<tbl_booking>();
        }
    
        [Display(Name = "RoomId")]
        public int room_id { get; set; }
        [Display(Name = "RoomName")]
        public string room_number { get; set; }
        [Display(Name = "RoomId")]
        public int room_type_id { get; set; }
        [Display(Name = "BookingStatusId")]
        public int booking_status_id { get; set; }
        [Display(Name = "IsActive")]
        public Nullable<bool> is_Active { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [Display(Name = "Booking")]
        public virtual ICollection<tbl_booking> tbl_booking { get; set; }
        [Display(Name = "BookingStatus")]
        public virtual tbl_booking_status tbl_booking_status { get; set; }
        [Display(Name = "RoomType")]
        public virtual tbl_room_type tbl_room_type { get; set; }
    }
}
