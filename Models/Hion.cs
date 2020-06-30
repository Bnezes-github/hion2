using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hion.Models
{
    public class Hion
    {
        public int Id { get; set; }

        public ApplicationUser Host { get; set; }

        [Required]
        public  string HostId { get; set; }

        public DateTime DateTime { get; set; }

        [Required]
        [StringLength(1500)]
        [DisplayName ("Event Link")]
        public string Venue { get; set; }

        [Required]
        [StringLength(1500)]
        public string Title { get; set; }

        public Genre Genre { get; set; }

        [Required]
        public int GenrerId { get; set; }


    }
}   
