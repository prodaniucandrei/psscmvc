using Moq;
using SchoolManagementApp.Controllers;
using SchoolManagementApp.Models;
using SchoolManagementApp.Repositories;
using System;
using System.Collections.Generic;
using Xunit;

namespace SchoolManagementApp.Tests
{
    public class UnitTest1
    {
        private Mock<IStudentRepository> _repository;
        public UnitTest1()
        {
            _repository = new Mock<IStudentRepository>();
            _repository.Setup(m => m.GetAllStudents()).ReturnsAsync(new List<Student>());
        }
        [Fact]
        public async void Test1()
        {
            var controller = new StudentController(_repository.Object);

            await controller.Index();

            _repository.Verify(m => m.GetAllStudents(), Times.Never);
        }
    }
}
