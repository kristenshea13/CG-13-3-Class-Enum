using System;
using System.Collections.Generic;

namespace CG_13_3_Class_Enum
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Complete a Class Enum program with an enumeration of 
             * all students in class’ first name.Ask the user to enter 
             * their name. Using a Switch statement, print their last name.*/

            List<Student> students = new List<Student>
            {
                new Student() {FirstName = Firstname.Kristen, LastName = LastName.Shea},
                new Student() {FirstName = "Adriana", LastName = LastName.Disano},
                new Student() {FirstName = "Angelique", LastName = LastName.Jacobs},
                new Student() {FirstName = "Carla", LastName = LastName.Huggans},
                new Student() {FirstName = "Jane", LastName = LastName.Brown},
                new Student() {FirstName = "Michelle", LastName = LastName.Crutcher},
                new Student() {FirstName = "Sabrina", LastName = LastName.Lindsey},
                new Student() {FirstName = "Temeka", LastName = LastName.Spears},
                new Student() {FirstName = "Agatha", LastName = LastName.Berwick},
                new Student() {FirstName = "Bennita", LastName = LastName.Higgins},
                new Student() {FirstName = "Carolina", LastName = LastName.Oppy},
                new Student() {FirstName = "Jennifer", LastName = LastName.Faron},
                new Student() {FirstName = "Madelyn", LastName = LastName.Weller},
                new Student() {FirstName = Firstname.Natalia, LastName = LastName.Solano},
                new Student() {FirstName = Firstname.Sandra, LastName = LastName.Nelson},
                new Student() {FirstName = Firstname.Alicia, LastName = LastName.Reynolds},
                new Student() {FirstName = "Blake", LastName = LastName.Pickering},
                new Student() {FirstName = "Diana", LastName = LastName.Peters},
                new Student() {FirstName = "Kendall", LastName = LastName.Union},
                new Student() {FirstName = "Megan", LastName = LastName.Hainline},
                new Student() {FirstName = "Natalie", LastName = LastName.Erdelt},
                new Student() {FirstName = "Sarah", LastName = LastName.Park},
                new Student() {FirstName = "Allison", LastName = LastName.Hix},
                new Student() {FirstName = "Breona", LastName = LastName.Caldwell},
                new Student() {FirstName = "Erin", LastName = LastName.Hogan},
                new Student() {FirstName = "Kendra", LastName = LastName.Kuhl},
                new Student() {FirstName = "Melissa", LastName = LastName.Dodd},
                new Student() {FirstName = "Nichole", LastName = LastName.Church},
                new Student() {FirstName = Firstname.Shelia, LastName = LastName.Wambui}
            };

            Console.Write("What is the student's first name? ");
            var firstNameEntered = Console.ReadLine();




            //    private static void PrintAssessment(List<Todo> todos)
            //{
            //    foreach (var todo in todos)
            //    {
            //        switch (todo.Status)
            //        {
            //            case Status.NotStarted:
            //                Console.ForegroundColor = ConsoleColor.DarkRed;
            //                break;
            //            case Status.InProgress:
            //                Console.ForegroundColor = ConsoleColor.DarkBlue;
            //                break;
            //            case Status.OnHold:
            //                Console.ForegroundColor = ConsoleColor.Yellow;
            //                break;
            //            case Status.Completed:
            //                Console.ForegroundColor = ConsoleColor.Magenta;
            //                break;
            //            case Status.Deleted:
            //                Console.ForegroundColor = ConsoleColor.White;
            //                break;
            //            default:
            //                break;
            //        }




                }

        //private static void PrintLastName(List<Student> students)
        //{
        //    foreach (var student in students)
        //    {
        //        var lastnameprint = LastName.Wambui;

        //        switch (Firstname, LastName)
        //        {
                    
        //            case  Firstname.Shelia:
        //                {
        //                lastnameprint = LastName.Wambui;
        //                break;
        //            } 
                    
        //            case


        //        }


        //    }


        //}

            


        }

    enum LastName
    {
        Shea,
        Disano,
        Kuhl,
        Jacobs,
        Huggans,
        Wambui,
        Brown,
        Church,
        Crutcher,
        Lindsey,
        Spears,
        Berwick,
        Higgins,
        Oppy,
        Dodd,
        Faron,
        Weller,
        Solano,
        Hogan,
        Nelson,
        Reynolds,
        Pickering,
        Peters,
        Union,
        Hainline,
        Erdelt,
        Park,
        Hix,
        Caldwell
    }

    enum Firstname
    {
        Kendall,
        Diana,
        Alicia,
        Natalia,
        Blake,
        Shelia,
        Nichole,
        Melissa,
        Kendra,
        Erin,
        Breona,
        Allison,
        Sarah,
        Natalie,
        Megan,
        Kristen,
        Adriana,
        Madelyn,
        Jennifer,
        Bennita,
        Sandra,
        Temeka,
        Agatha,
        Carolina,
        Jane,
        Carla,
        Angelique,
        Sabrina,
        Michelle
    }
}
