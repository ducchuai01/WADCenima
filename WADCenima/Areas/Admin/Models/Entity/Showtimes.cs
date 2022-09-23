using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WADCenima.Areas.Admin.Models.Entity
{
    [Table("Showtimes")]
    public class Showtimes
    {
        [DisplayName("Mã khung giờ chiếu")]
        public Guid ShowtimesId { get; set; }

        [DisplayName("Các ngày trong tuần")]
        public DateTime Days_of_week { get; set; }

        [DisplayName("Giờ chiếu")]
        public DateTime TimeShow { get; set; }
    }
}
