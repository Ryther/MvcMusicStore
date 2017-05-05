using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace mvcmusicstore.Models
{
    public class Artist
    {
        public int ArtistID { get; set; }

        [Required()]
        [Display(Name="Artista")]
        public string Name { get; set; }
    }
}
