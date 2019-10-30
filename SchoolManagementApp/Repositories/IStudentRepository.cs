using SchoolManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementApp.Repositories
{
    public interface IStudentRepository
    {
        Task Create(Student student);
    }
}
