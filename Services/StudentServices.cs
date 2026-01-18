using EfcorePractice.Data;
using EfcorePractice.Models;

namespace EfcorePractice.Services
{
    public class StudentServices
    {
        private readonly AppDbContext _context;
        public StudentServices(AppDbContext context)
        {
            _context = context;

        }
        public List<Students> GetStudents()
        {
           return _context.Students.ToList();
        }
        public  void AddStudent(Students student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
        }
        public void updateStudent(Students updatedstudents)
        {
            var existing = _context.Students.FirstOrDefault(s => s.Id == updatedstudents.Id);
            if (existing!=null)
            {
                existing.Name = updatedstudents.Name;
                existing.domain = updatedstudents.domain;
                _context.SaveChanges();
                
            }
        }
        public void deletestud(int studentiD)
        {
            var student = _context.Students.FirstOrDefault(s => s.Id == studentiD);
            if (student != null)
            {
                _context.Students.Remove(student);
                _context.SaveChanges();

            }
            
        }
        public Students?  getstudentbyid(int id)
        {
            var student = _context.Students.FirstOrDefault(s => s.Id == id);
            return student;
        }

        public List<Students> GetStudentsByDomain(string price)
        {
            return _context.Students.Where(s => s.domain == price).ToList();
        }
    }
}
