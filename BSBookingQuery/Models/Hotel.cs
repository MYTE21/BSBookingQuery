using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BSBookingQuery.Models
{
    public class Hotel
    {
        [Key]
        public int Id { get; set; }

        [Column("HotelName", TypeName = "varchar(200)")]
        public string HotelName { get; set; }

        [Column("HotelLocation", TypeName = "varchar(200)")]
        public string HotelLocation { get; set; }

        [Column("HotelRating")]
        [Range(0, 7)]
        public int HotelRating { get; set;}


        public Hotel()
        {
            
        }

    }
}
