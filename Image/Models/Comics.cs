using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Image.Models
{
    public class Comics
    {
        public int ID { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        [Display(Name = "Tên Truyện")]
        public string TenTruyen { get; set; }
        [Display(Name = "Ngày Phát Hành")]
        [DataType(DataType.Date)]
        public DateTime NgayPhatHanh { get; set; }
        [Display(Name = "Thể Loại")]
        
        [Required]
        [StringLength(30)]
        public string TheLoai { get; set; }
        [Display(Name = "Giá")]
        [Range(1, 10000000)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Gia { get; set; }
        [Display(Name = "Độ Tuổi")]
        public string Rating { get; set; }
       
     

    }
}
