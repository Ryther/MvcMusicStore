using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace mvcmusicstore.Models
{
    public class Album
    {
        public int AlbumID { get; set; }

        public string Title { get; set; }

        public int ArtistID { get; set; }
        public virtual Artist Artist { get; set; }
    }
}