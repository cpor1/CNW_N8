namespace CNW_N8_MVC.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class hotel_bookings
    {
        public int id { get; set; }

        public int? user_id { get; set; }

        [StringLength(100)]
        public string customer_name { get; set; }

        [StringLength(100)]
        public string customer_email { get; set; }

        [StringLength(100)]
        public string customer_phone { get; set; }

        [StringLength(100)]
        public string customer_address { get; set; }

        public int? hotel_id { get; set; }

        [Column(TypeName = "date")]
        public DateTime? from_date { get; set; }

        [Column(TypeName = "date")]
        public DateTime? to_date { get; set; }

        public virtual hotel hotel { get; set; }
    }
}
