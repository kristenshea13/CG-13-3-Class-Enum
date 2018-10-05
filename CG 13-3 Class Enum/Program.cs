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

            //var students = new List<Student>
            //{
            //    new Student() {FirstName = Firstname.Kristen, LastName = "Shea"},
            //    new Student() {FirstName = Firstname.Adriana, LastName = "Disano"},
            //    new Student() {FirstName = Firstname.Angelique, LastName = "Jacobs"},
            //new Student() {FirstName = Firstname.Carla, LastName = Lastname.Huggans},
            //new Student() {FirstName = Firstname.Jane, LastName = Lastname.Brown},
            //new Student() {FirstName = Firstname.Michelle, LastName = Lastname.Crutcher},
            //new Student() {FirstName = Firstname.Sabrina, LastName = Lastname.Lindsey},
            //new Student() {FirstName = Firstname.Temeka, LastName = Lastname.Spears},
            //new Student() {FirstName = Firstname.Agatha, LastName = Lastname.Berwick},
            //new Student() {FirstName = Firstname.Bennita, LastName = Lastname.Higgins},
            //new Student() {FirstName = Firstname.Carolina, LastName = Lastname.Oppy},
            //new Student() {FirstName = Firstname.Jennifer, LastName = Lastname.Faron},
            //new Student() {FirstName = Firstname.Madelyn, LastName = Lastname.Weller},
            //new Student() {FirstName = Firstname.Natalia, LastName = Lastname.Solano},
            //new Student() {FirstName = Firstname.Sandra, LastName = Lastname.Nelson},
            //new Student() {FirstName = Firstname.Alicia, LastName = Lastname.Reynolds},
            //new Student() {FirstName = Firstname.Blake, LastName = Lastname.Pickering},
            //new Student() {FirstName = Firstname.Diana, LastName = Lastname.Peters},
            //new Student() {FirstName = Firstname.Kendall, LastName = Lastname.Union},
            //new Student() {FirstName = Firstname.Megan, LastName = Lastname.Hainline},
            //new Student() {FirstName = Firstname.Natalie, LastName = Lastname.Erdelt},
            //new Student() {FirstName = Firstname.Sarah, LastName = Lastname.Park},
            //new Student() {FirstName = Firstname.Allison, LastName = Lastname.Hix},
            //new Student() {FirstName = Firstname.Breona, LastName = Lastname.Caldwell},
            //new Student() {FirstName = Firstname.Erin, LastName = Lastname.Hogan},
            //new Student() {FirstName = Firstname.Kendra, LastName = Lastname.Kuhl},
            //new Student() {FirstName = Firstname.Melissa, LastName = Lastname.Dodd},
            //new Student() {FirstName = Firstname.Nichole, LastName = Lastname.Church},
            //new Student() {FirstName = Firstname.Shelia, LastName = Lastname.Wambui}
            //};

            Console.Write("What is the student's first name? ");
            string firstNameEntered = Console.ReadLine();
            Firstname firstnameUser;
            firstnameUser = (Firstname)Enum.Parse(typeof(Firstname), firstNameEntered, true);

            PrintLastName(firstnameUser);


            Console.ReadLine();
        }

        private static void PrintLastName(Firstname firstname)
        {


            string lastnamePrint;

            switch (firstname)
            {


                case Firstname.Kristen:
                    lastnamePrint = "Shea";
                    break;

                case Firstname.Adriana:
                    lastnamePrint = "Disano";
                    break;

                //case Firstname.Angelique:
                //    lastnamePrint = ;
                //    break;

                default:
                    lastnamePrint = "";
                    break;

            }



            Console.WriteLine(lastnamePrint);





        }


    }
    public enum Firstname
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
    /*enum Lastname
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
        }*/


}
