using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_StudentProgram
{
    public class Dates
    {
        private string _day;
        private string _month;
        private string _year;

        public Dates()
        {
            //constructor
        }

        public void setDay(string s)
        {
          //set the the day of the birth
          
            /*
             *length can only be two digits
             * cannot be greater than 31, equal to 00, or any negative number
             * assign string to day attribue 
             * return true
             * 
             */
        }

        public int getDay()
        {
           //convert day attribute to an int and return it 
        }

        public bool setMonth(string s)
        {
            //set the the month of birth

            /*
             * only tweleve months in a year
             * two digits only 
             * no negatives 
             * 00 is not allowed 
             * assign string to month attribute 
             * return true
             */
        }

        public void getMonth()
        {
            //convert month attribute to an int and return it 
        }

        public bool setYear(string s)
        {
            //set the the year of birth

            /* four digits only 
             * years before 1920 is not allowed
             * assign string to attribute 
             * second digit has to equal 0
             * third digit cannot be greater than two or less than 0
             * 
             * return true
             * 
             */
        }

        public int getYear()
        {
            //convert year attribute to an int and return it 
        }
    }
}