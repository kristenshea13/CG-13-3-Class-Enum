using System;
using System.Collections.Generic;

namespace CG_13_3_Class_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
             
           //prompt user for first name
            Console.Write("What is the student's first name? ");
            
            //take name and assign it as a string with a variable name
            string firstNameEntered = Console.ReadLine();

            //assign variable name to parse to enum value
            Firstname firstnameUser;

            //use Enum.Parse to convert name from string into Enum, 
            //*true* is so it will ignore case.
            //I was getting an error when I entered a name not on the enum list.
            //i added try/catch statements. if name is in program, the program will continue
            //if name is not in program, console will stop running and close
            try
            {
                firstnameUser = (Firstname)Enum.Parse(typeof(Firstname), firstNameEntered, true);
            }

            catch (Exception)
            {
                return;
            }
            

            //call on switch to print last name
            PrintLastName(firstnameUser);


            Console.ReadLine();
        }


        /// <summary>
        /// switch statement to take given enum (first name) and print out last name
        /// </summary>
        /// <param name="firstname"></param>
        private static void PrintLastName(Firstname firstname)
        {
            //declare variable for last name outside switch statement
            string lastnamePrint;

            switch (firstname)
            {
                
                //prints out last name string based on first name enum
                case Firstname.Kristen:
                    lastnamePrint = "Shea";
                    break;

                case Firstname.Adriana:
                    lastnamePrint = "Disano";
                    break;

                case Firstname.Angelique:
                    lastnamePrint = "Jacobs";
                    break;

                case Firstname.Carla:
                    lastnamePrint = "Huggans";
                    break;

                case Firstname.Jane:
                    lastnamePrint = "Brown";
                    break;

                case Firstname.Michelle:
                    lastnamePrint = "Crutcher";
                    break;

                case Firstname.Sabrina:
                    lastnamePrint = "Lindsey";
                    break;

                case Firstname.Temeka:
                    lastnamePrint = "Spears";
                    break;

                case Firstname.Agatha:
                    lastnamePrint = "Berwick";
                    break;

                case Firstname.Shelia:
                    lastnamePrint = "Wambui";
                    break;

                case Firstname.Bennita:
                    lastnamePrint = "Higgins";
                    break;

                case Firstname.Carolina:
                    lastnamePrint = "Oppy";
                    break;

                case Firstname.Jennifer:
                    lastnamePrint = "Faron";
                    break;

                case Firstname.Nichole:
                    lastnamePrint = "Church";
                    break;

                case Firstname.Melissa:
                    lastnamePrint = "Dodd";
                    break;

                case Firstname.Kendra:
                    lastnamePrint = "Kuhl";
                    break;

                case Firstname.Erin:
                    lastnamePrint = "Hogan";
                    break;

                case Firstname.Breona:
                    lastnamePrint = "Caldwell";
                    break;

                case Firstname.Allison:
                    lastnamePrint = "Hix";
                    break;

                case Firstname.Kendall:
                    lastnamePrint = "Union";
                    break;

                case Firstname.Sarah:
                    lastnamePrint = "Park";
                    break;

                case Firstname.Sandra:
                    lastnamePrint = "Nelson";
                    break;

                case Firstname.Natalia:
                    lastnamePrint = "Solano";
                    break;

                case Firstname.Alicia:
                    lastnamePrint = "Reynolds";
                    break;

                case Firstname.Diana:
                    lastnamePrint = "Peters";
                    break;

                case Firstname.Blake:
                    lastnamePrint = "Pickering";
                    break;

                case Firstname.Madelyn:
                    lastnamePrint = "Weller";
                    break;

                case Firstname.Megan:
                    lastnamePrint = "Hainline";
                    break;

                case Firstname.Natalie:
                    lastnamePrint = "Erdelt";
                    break;

                //create catch all string if name entered is not in program
                default:
                    lastnamePrint = "Student not recognized.";
                    break;
            }

            Console.WriteLine($"Last name: {lastnamePrint}");

        }


    }

    //created enum, added all first names
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
    
}
