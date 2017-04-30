using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace mvcmusicstore.Models
{
    public class Artist
    {
        public int ArtistID { get; set; }

        public string Name { get; set; }

        public List<Album> Albums { get; set; }   
    }
}
