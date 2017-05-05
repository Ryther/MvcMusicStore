using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace mvcmusicstore.Models
{
    public class Album
    {
        public int AlbumID { get; set; }

        [Required()]
        [Display(Name="Titolo")]
        public string Title { get; set; }

        
        [Required()]
        [Display(Name="Artista")]
        public int ArtistID { get; set; }

        public virtual Artist Artist { get; set; }
    }
}