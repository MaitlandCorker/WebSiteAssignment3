using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace WebSiteAssignment2.Models
{
    public class Band

    {
        [Key]
        public int BandID { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string BandName { get; set; }

        [Required]
        [Column(TypeName = "varchar(5)")]
        public string BandGenre { get; set; }

        [Column(TypeName = "text")]
        public string BandDescription { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string BandImage { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal TicketPrice { get; set; }

        [DataType(DataType.Date)]
        public DateTime GigDate { get; set; }

    }

}