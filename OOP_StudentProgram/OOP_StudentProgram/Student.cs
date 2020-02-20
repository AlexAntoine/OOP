using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_StudentProgram
{
    public class Student
    {
        //attributes
        private string _firstName;
        private string _lastName;
        private string _gender;
        private string _major;
        private Dates _birthdate; //composition

        public Student()
        {
          //constructor
        }

        public bool setFirstName(string s)
        {
           //set rules sets for the students first name
           
            /*
             * student's first name can be whatever 
             * assign the string to the first name attribute
             * return true
             */
        }

        public string getFirstName()
        {
            //return students first name as a string 
        }

        public bool setLastName(string s)
        {
            //set rules sets for the students last name

            /*
             * student's last name can be whatever 
             * assign the string to the last name attribute
             * return true
             */

           
        }

        public string getLastName()
        {
            //return students last name as a string 
        }

        public bool setGender(string s)
        {
            //set rules sets for the students gender

            /*
             * if input match male, man. assing 'm' to gender attribute and return true
             * if input match female or woman. assign 'f' to gender attribute and return true
             * else return false;
             * 
            */
        }

        public string getGender()
        {
            /*
             * if gender attribute matches 'f' return "female"
             * if gender attribute matches 'm' return "male
             * else "gender not found false;
             * 
            */
        }

        public bool setMajor(string s)
        {
            //set rules sets for the students major

            /*
            * set string to major attribute
            * return true
            */
        }

        public string getMajor()
        {
           //retrun major attribute
        }

        public string setBirthdat(Dates s)
        {
            //assgin dates object to birthdate attribute
            //return true
        }

        public string getBirthdate()
        {
            //return birthdate in a string format.
            // 00/00/0000
        }
    }
}