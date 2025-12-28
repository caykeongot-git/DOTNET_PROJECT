using Lab06.DAL;
using Lab06.DAL.Models;
using Lab06.DAL;
using Lab06.DAL.Models;
using Microsoft.EntityFrameworkCore; 
using System.Collections.Generic;
using System.Linq;

namespace Lab06.BLL
{
    public class SachService
    {
        public List<Sach> GetAll()
        {
            using (var context = new Model1())
            {
                return context.Sachs.Include(s => s.LoaiSach).ToList();
            }
        }

        public List<LoaiSach> GetAllLoaiSach()
        {
            using (var context = new Model1())
            {
                return context.LoaiSachs.ToList();
            }
        }

        public Sach FindById(string maSach)
        {
            using (var context = new Model1())
            {
                return context.Sachs.FirstOrDefault(p => p.MaSach == maSach);
            }
        }

        public void InsertUpdate(Sach s)
        {
            using (var context = new Model1())
            {
                // EF Core không có AddOrUpdate, ta tự check
                var existing = context.Sachs.Find(s.MaSach);
                if (existing == null)
                {
                    context.Sachs.Add(s); // Thêm mới
                }
                else
                {
                    // Update các trường
                    existing.TenSach = s.TenSach;
                    existing.NamXB = s.NamXB;
                    existing.MaLoai = s.MaLoai;
                }
                context.SaveChanges();
            }
        }

        public void Delete(string maSach)
        {
            using (var context = new Model1())
            {
                var s = context.Sachs.Find(maSach);
                if (s != null)
                {
                    context.Sachs.Remove(s);
                    context.SaveChanges();
                }
            }
        }

        public List<Sach> Search(string keyword)
        {
            using (var context = new Model1())
            {
                return context.Sachs.Include(s => s.LoaiSach)
                    .Where(s => s.MaSach.Contains(keyword) ||
                                s.TenSach.Contains(keyword) ||
                                s.NamXB.ToString().Contains(keyword))
                    .ToList();
            }
        }
    }
}