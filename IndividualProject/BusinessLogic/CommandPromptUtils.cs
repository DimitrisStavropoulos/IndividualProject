using IndividualProject.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject.BusinessLogic
{
    class CommandPromptUtils
    {
        public Trainer GetTrainerDetails()
        {
            Trainer trainer = new Trainer();
            trainer.FirstName = AskDetail("Give the trainer's first name");
            trainer.LastName = AskDetail("Give the trainer's last name");
            trainer.Subject = AskDetail("Give the trainer's subject");
            return (trainer);
        }

        public Assignment GetAssignmentDetails()
        {
            Assignment assignment = new Assignment();
            assignment.Title = AskDetail("Give the assignment's title");
            assignment.Description = AskDetail("Give the assignment's description");
            assignment.SubDateTime = Convert.ToDateTime(AskDetail("Give the assignment's submission date"));
            assignment.OralMark = float.Parse(AskDetail("Give the assignment's oral mark"));
            assignment.TotalMark = float.Parse(AskDetail("Give the assignment's total mark"));
            return (assignment);
        }

        public Student GetStudentDetails()
        {
            Student student = new Student();
            student.FirstName = AskDetail("Give the student's first name ");
            student.Lastname = AskDetail("Give the student's last name ");
            student.Dateofbirth = Convert.ToDateTime(AskDetail("Give the student's birthday"));
            student.Tuitionfees = double.Parse(AskDetail("Give the student's tuition fees"));
            return (student);
        }

        public Course GetCourseDetails()
        {
            Course course = new Course();
            course.Title = AskDetail("Give the course's title");
            course.Stream = AskDetail("Give the course's stream");
            course.Type = AskDetail("Give the course's type");
            course.StartDate = Convert.ToDateTime(AskDetail("Give the course's start date"));
            course.EndDate = Convert.ToDateTime(AskDetail("Give the course's end date"));
            return (course);
        }
        private string AskDetail (string message)
        {
            string result = "";
            Console.Write(message + ": ");
            result = Console.ReadLine();
            return (result);
        }

        public void PrintTrainersList(List<Trainer> trainers)
        {
            Console.WriteLine("The list of trainers is:");
            foreach(var trainer in trainers)
            {
                Console.WriteLine(trainer);
            }
        }

        public void PrintStudentsList(List<Student> students)
        {
            Console.WriteLine("The list of students is:");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

        public void PrintAssignmentsList(List<Assignment> assignments)
        {
            Console.WriteLine("The list of assignments is:");
            foreach (var assignment in assignments)
            {
                Console.WriteLine(assignment);
            }
        }
        public void PrintCoursesList(List<Course> courses)
        {
            Console.WriteLine("The list of courses is:");
            foreach (var course in courses)
            {
                Console.WriteLine(course);
            }
        }

        public void PrintAllExistingObjects(List<Trainer> trainers, List<Student> students, List<Assignment> assignments, List<Course> courses)
        {
            Console.WriteLine("The list of ALL OBJECTS is:");
            PrintTrainersList(trainers);
            PrintStudentsList(students);
            PrintCoursesList(courses);
            PrintAssignmentsList(assignments);
        }
    }   

}
