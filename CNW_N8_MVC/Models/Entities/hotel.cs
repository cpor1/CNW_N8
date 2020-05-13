namespace CNW_N8_MVC.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class hotel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public hotel()
        {
            hotel_bookings = new HashSet<hotel_bookings>();
        }

        public int id { get; set; }

        public int? location_id { get; set; }

        [Required]
        [StringLength(100)]
        public string hotel_name { get; set; }

        [StringLength(100)]
        public string image_url { get; set; }

        [Column(TypeName = "text")]
        public string description { get; set; }

        [Column(TypeName = "text")]
        public string more_imformation { get; set; }

        public int? price { get; set; }

        public int? sell_price { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hotel_bookings> hotel_bookings { get; set; }

        public virtual location location { get; set; }
    }
}
