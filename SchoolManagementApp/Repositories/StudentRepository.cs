using SchoolManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementApp.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly StudentDbContext _context;
        public StudentRepository(StudentDbContext studentDbContext)
        {
            _context = studentDbContext;
        }
        public async Task Create(Student student)
        {
            _context.Add(student);
            await _context.SaveChangesAsync();
        }
    }
}
