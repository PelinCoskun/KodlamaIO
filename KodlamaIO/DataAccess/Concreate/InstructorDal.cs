using KodlamaIO.DataAccess.Abstract;
using KodlamaIO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO.DataAccess.Concreate
{
    public class InstructorDal : IInstructorDal
    {
        private List<Instructor> _instructors;

        public InstructorDal()
        {

            _instructors = new List<Instructor>
            {
                new Instructor { Id = 1, Name = "Pelin",Surname = "Coşkun" },
                new Instructor { Id = 2, Name = "İzel", Surname = "Coşkun" },
                new Instructor { Id = 3, Name = "Ece", Surname = "Coşkun" }
            };
        }

        public List<Instructor> GetAll()
        {
            foreach (var instructor in _instructors)
            {
                Console.WriteLine($"ID: {instructor.Id}, Adı: {instructor.Name}, Soyadı: {instructor.Surname}");
            }

            return _instructors;
        }

        public Instructor GetById(int id)
        {
            return _instructors.FirstOrDefault(i => i.Id == id);
        }

        public void Add(Instructor instructor)
        {
            _instructors.Add(instructor);
        }

        public void Update(Instructor instructor)
        {
            Instructor instructorToUpdate = _instructors.FirstOrDefault(i => i.Id == instructor.Id);
            if (instructorToUpdate != null)
            {
                instructorToUpdate.Name = instructor.Name;
                instructorToUpdate.Surname = instructor.Surname;
            }
        }

        public void Delete(int id)
        {
            Instructor instructorToDelete = _instructors.FirstOrDefault(i => i.Id == id);
            if (instructorToDelete != null)
            {
                _instructors.Remove(instructorToDelete);
            }
        }
    }
}
