using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndividualProject.Models;
using IndividualProject.BusinessLogic;

namespace IndividualProject
{
    class Program
    {
        static void Main(string[] args)
        {
            CommandPromptUtils cpUtils = new CommandPromptUtils();
            
            //Creation of all lists

            List<Trainer> trainers = new List<Trainer>(); 
            List<Student> students = new List<Student>();
            List<Course> courses = new List<Course>();
            List<Assignment> assignments = new List<Assignment>();

            // prosthiki stis listes afou paroume apo keyboard
           
            //trainers.Add(cpUtils.GetTrainerDetails()); 
            //students.Add(cpUtils.GetStudentDetails());
            //courses.Add(cpUtils.GetCourseDetails());
            //assignments.Add(cpUtils.GetAssignmentDetails());

            //ektyposi listwn

            //cpUtils.PrintTrainersList(trainers);
            //cpUtils.PrintStudentsList(students);
            //cpUtils.PrintCoursesList(courses);
            //cpUtils.PrintAssignmentsList(assignments);

            //ektyposi olwn to objects

            //cpUtils.PrintAllExistingObjects(trainers, students, assignments, courses);

        }
    }
}
