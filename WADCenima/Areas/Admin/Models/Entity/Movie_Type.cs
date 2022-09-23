using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WADCenima.Areas.Admin.Models.Entity
{
    [Table("Movie_Type")]
    public class Movie_Type
    {
        [DisplayName("Mã thể loại phim")]
        public Guid Movie_typeId { get; set; }

        [DisplayName("Tên thể loại phim")]
        [StringLength(100)]
        public string Movie_typeName { get; set; }
        public ICollection<Movie_Genre_Movie> movie_Genre_Movies{ get; set; }
    }
}
