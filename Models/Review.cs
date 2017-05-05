using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace mvcmusicstore.Models
{
    public class Review
    {
            public int ReviewID { get; set; }

            [Required()]
            [Display(Name="Album")]
            public int AlbumID { get; set; }
            public virtual Album Album { get; set; }

            [Required()]
            [Display(Name="Recensione")]
            public string Contents { get; set; }

            [Required()]
            [Display(Name="Indirizzo Email")]
            [DataType(DataType.EmailAddress)]
            public string ReviewerEmail { get; set; }
    }
}