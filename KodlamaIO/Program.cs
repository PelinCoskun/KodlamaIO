
using KodlamaIO.Business.Concreate;
using KodlamaIO.DataAccess.Concreate;
using KodlamaIO.Entities;

CourseManager courseManager = new CourseManager(new CourseDal());
CategoryManager categoryManager = new CategoryManager(new CategoryDal());
InstructorManager instructorManager = new InstructorManager(new InstructorDal());

// Tüm kursları listeleme
Console.WriteLine("Tüm kurslar:");
courseManager.GetAll();

Course newCourse = new Course { Id = 4,Name = "Course 4", Description = "Description 4", CategoryId = 4, InstructorId = 4 };
courseManager.Add(newCourse);
Console.WriteLine("Yeni kurs eklendi.");
courseManager.GetAll();

Course courseToUpdate = courseManager.GetById(1);
courseManager.Update(courseToUpdate);
Console.WriteLine("Kurs güncellendi.");
courseManager.GetAll();

int courseIdToDelete = 2;
courseManager.Delete(courseIdToDelete);
Console.WriteLine($"ID'si {courseIdToDelete} olan kurs silindi.");
courseManager.GetAll();

Console.WriteLine("Tüm kategoriler:");
categoryManager.GetAll();

Category newCategory = new Category { Id = 4,Name = "Category 4" };
categoryManager.Add(newCategory);
Console.WriteLine("Yeni kategori eklendi.");
categoryManager.GetAll();

Category categoryToUpdate = categoryManager.GetById(1);
categoryToUpdate.Name = "Updated Category";
categoryManager.Update(categoryToUpdate);
Console.WriteLine("Kategori güncellendi.");
int categoryIdToDelete = 2;
categoryManager.Delete(categoryIdToDelete);
Console.WriteLine($"ID'si {categoryIdToDelete} olan kategori silindi.");
categoryManager.GetAll();
Console.WriteLine("Tüm eğitmenler:");
instructorManager.GetAll();
Instructor newInstructor = new Instructor { Id = 4,Name = "Pelo", Surname = "Cosko" };
instructorManager.Add(newInstructor);
Console.WriteLine("Yeni eğitmen eklendi.");
instructorManager.GetAll();
Instructor instructorToUpdate = instructorManager.GetById(4);
instructorToUpdate.Name = "Updated Pelo";
instructorToUpdate.Surname = "Updated Cosko";
instructorManager.Update(instructorToUpdate);
Console.WriteLine("Eğitmen güncellendi.");
instructorManager.GetAll();
int instructorIdToDelete = 2;
instructorManager.Delete(instructorIdToDelete);
Console.WriteLine($"ID'si {instructorIdToDelete} olan eğitmen silindi.");
instructorManager.GetAll();

Console.ReadLine();