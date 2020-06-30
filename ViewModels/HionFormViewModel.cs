using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hion.ViewModels
{
    public class HionFormViewModel
    {
        [Required(ErrorMessage = "The Event Link field is required.")]
        public string Venue { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [FutureDate]
        public string Date { get; set; }

        [Required]
        [ValidTime]
        public string Time { get; set; }

        [Required]
        public int Genre { get; set; }

       
        public IEnumerable<Genre> Genres { get; set; }
        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }
    }
}