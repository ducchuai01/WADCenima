using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WADCenima.Areas.Admin.Models.Entity
{
    [Table("Movie_Genre_Movie")]
    public class Movie_Genre_Movie
    {
        public int Movie_typeId { get; set; }
        public Movie_Type movie_type { get; set; }

        public int MovieId { get; set; }
        public Movie movie { get; set; }
    }
}
