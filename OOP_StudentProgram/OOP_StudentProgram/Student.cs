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
        private char _gender;
        private string _major;
        private Dates _birthdate; //composition

        public Student()
        {
          //constructor
        }

        public bool setFirstName(string s)
        {
            s = _firstName;
            return true;
        }

        public string getFirstName()
        {
          
            return _firstName;
        }

        public bool setLastName(string s)
        {          
            s = _lastName;
            return true;
        }

        public string getLastName()
        {  
            return _lastName;
        }

        public bool setGender(string s)
        {
          
            if (s == "male" || s == "man")
            {
                _gender = 'm';
                return true;
            }
            else if (s == "woman" || s == "man")
            {
               _gender = 'f';
                return true;
            }
            else
                return false;
        }

        public string getGender()
        {
            
            if (_gender == 'f')
            {
                return "female";
            }
            else if (_gender == 'm')
            {
                return "male";
            }
            else
                return "gender is not initialized";
        }

        public bool setMajor(string s)
        {
          
            s = _major;

            return true;
        }

        public string getMajor()
        {
            return _major;
        }

        public bool setBirthdate(Dates s)
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