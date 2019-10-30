using Moq;
using SchoolManagementApp.Controllers;
using SchoolManagementApp.Models;
using SchoolManagementApp.Repositories;
using System;
using Xunit;

namespace SchoolManagementApp.Tests
{
    public class UnitTest1
    {
        private Mock<IStudentRepository> repository;

        public UnitTest1()
        {
            repository = new Mock<IStudentRepository>();
            //repository.Setup(m => m.Create()).Returns();
        }
        [Fact]
        public async void Test1()
        {
            var controller = new StudentsController(repository.Object);
            var sStudent = new Student() { Numele = "Andrei", An=4};
            await controller.Create(sStudent);
            repository.Verify(a=>a.Create(It.IsAny<Student>()), Times.Once);
        }
    }
}
