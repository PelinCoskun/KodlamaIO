using KodlamaIO.DataAccess.Abstract;
using KodlamaIO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO.DataAccess.Concreate
{
    public class CourseDal : ICourseDal
    {
        private List<Course> _courses;

        public CourseDal()
        {

            _courses = new List<Course>
            {
                new Course { Id = 1, Name = "Course 1", Description = "Description 1", CategoryId = 1, InstructorId = 1 },
                new Course { Id = 2, Name = "Course 2", Description = "Description 2",  CategoryId = 2, InstructorId = 2 },
                new Course { Id = 3, Name = "Course 3", Description = "Description 3", CategoryId = 3, InstructorId = 3 }
            };
        }

        public void Add(Course course)
        {
            _courses.Add(course);
        }

        public void Delete(int id)
        {
            Course courseToDelete = _courses.FirstOrDefault(c => c.Id == id);
            if (courseToDelete != null)
            {
                _courses.Remove(courseToDelete);
            }
        }

        public List<Course> GetAll()
        {
            foreach (var course in _courses)
            {
                Console.WriteLine($"Kurs Adı: {course.Name}, Açıklama: {course.Description}");
            }

            return _courses;
        }

        public Course GetById(int id)
        {
            return _courses.FirstOrDefault(c => c.Id == id);
        }

        public void Update(Course course)
        {
            Course courseToUpdate = _courses.FirstOrDefault(c => c.Id == course.Id);
            if (courseToUpdate != null)
            {
                // Özelliklerini güncelliyoruz
                courseToUpdate.Name = course.Name;
                courseToUpdate.Description = course.Description;
                courseToUpdate.CategoryId = course.CategoryId;
                courseToUpdate.InstructorId = course.InstructorId;
            }
        }
    }
}
