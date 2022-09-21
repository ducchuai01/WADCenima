using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WADCenima.Areas.Admin.Models.Entity
{
    [Table("Movie")]
    public class Movie
    {
        [DisplayName("Mã phim")]
        public Guid MovieId { get; set; }
        [DisplayName("Tên phim")]
        [StringLength(100)]
        public string MovieName { get; set; }
        [DisplayName("Trailer phim")]
        [MaxLength()]
        public string MovieTrailer { get; set; }
        [DisplayName("Diễn viên")]
        [MaxLength()]
        public string MovieCast { get; set; }
        [DisplayName("Dạo diễn")]
        [StringLength(100)]
        public string MovieDirectors { get; set; }
        [DisplayName("Quốc gia")]
        [StringLength(100)]
        public string MovieCountry { get; set; }
        [DisplayName("Cảnh báo")]
        [StringLength(100)]
        public string MovieWarning { get; set; }
        [DisplayName("Thời lượng")]
        public int MovieTime { get; set; }
        [DisplayName("Ảnh bìa")]
        [MaxLength()]
        public string MoviePoster { get; set; }
        [DisplayName("Ngày khởi chiếu")]
        public DateTime PremiereDate { get; set; }
        [DisplayName("Chi tiết")]
        [MaxLength()]
        public DateTime MovieDescription { get; set; }
    }
}
