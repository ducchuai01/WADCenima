using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WADCenima.Areas.Admin.Models.Entity
{
    [Table("Movie_Schedule")]
    public class Movie_Schedule
    {
        [DisplayName("Mã lịch chiếu phim")]
        public Guid Movie_scheduleId { get; set; }
        [DisplayName("Ngày chiếu")]
        public DateTime Movie_scheduleDate { get; set; }
        [DisplayName("Ngày chiếu")]
        public DateTime Movie_scheduleTime{ get; set; }
    }
}
