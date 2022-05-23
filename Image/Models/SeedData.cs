using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Image.Data;
using System;
using System.Linq;
namespace Image.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ImageContext(
            serviceProvider.GetRequiredService<
            DbContextOptions<ImageContext>>()))
            {
                // Kiểm tra thông tin cuốn sách đã tồn tại hay chưa
                if (context.Comics.Any())
                {
                    return; // Không thêm nếu cuốn sách đã tồn tại trong DB
                }
                context.Comics.AddRange(
                new Comics
                {
                    TenTruyen = "CapTain American",
                    NgayPhatHanh = DateTime.Parse("2018-10-16"),
                    TheLoai = "Viễn Tưởng",
                    Gia = 198000,
                    Rating = "13+"
                },
                new Comics
                {
                    TenTruyen = "Iron Man",
                    NgayPhatHanh = DateTime.Parse("2021-8-3"),
                    TheLoai = "Khoa Học",
                    Gia = 180000,
                    Rating = "13+"
                }
 ); ;
                context.SaveChanges();//lưu dữ liệu
            }
        }
    }
}

