using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }

        public int? Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        public Genre Genre { get; set; }

        [Required]
        public byte GenreId { get; set; }

        [Required]
        public DateTime? ReleaseDate { get; set; }

        [Required]
        public DateTime? DateAdded { get; set; }

        [Required]
        [Range(1, 20, ErrorMessage = "El campo {0} debe estar entre {1} y {2}.")]
        [Display(Name = "Number in Stock")]
        public int? Stock { get; set; }

        public string Title {
            get
            {
                return Id != 0 ? "Edit Movie" : "New Movie";
            }
                
        }

        public MovieFormViewModel()
        {
            Id = 0;
            Name = string.Empty;
            ReleaseDate = DateTime.MinValue;
            Stock = 0;
        }

        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            Stock = movie.Stock;
            GenreId = movie.GenreId;
        }
    }
}