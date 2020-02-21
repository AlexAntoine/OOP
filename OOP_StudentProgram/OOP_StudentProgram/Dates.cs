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

        public bool setDay(string s)
        {
         
            if (!int.TryParse(s, out _))
            {
                return false;
            }


            if (s.Length > 2 || s == null)
            {
                return false;
            }
               

            if (s[0] == '0' && s[1] == '0')
            {
                return false;
            }
                

            if (s[0] < '0' || s[1] < '0')
            {
                return false;
            }
               

            if (s[0] > '4')
            {
                return false;
            }
               

            if (s[0] == '3' && s[1] > '1')
            {
                return false;
            }
            else
            {
                s = _day;
            }

              
            return true;

           
        }

        public int getDay()
        {
            return int.Parse(_day);
        }

        public bool setMonth(string s)
        {
        
            if (!int.TryParse(s, out _))
                return false;

            if (s.Length > 2 || s == null)
                return false;

            if (s[0] == '0' && s[1] == '0')
                return false;

            if (s[0] < '0' || s[1] < '0')
                return false;

            if (s[0] > '1' || s[0] == '1' && s[1] > '2')
                return false;

            else
            {
                s = _day;
            }

            return true;
        }

        public int getMonth()
        {
            return int.Parse(_month);
        }

        public bool setYear(string s)
        {
           
            if (s.Length != 4)
                return false;

            if (!int.TryParse(s, out _))
                return false;

            if (s[0] < '1' || s[1] > '0')
                return false;

            if (s[2] > '2' || s[2] < '0' || s[3] < '0')
                return false;

            else
            {
                s = _year;
            }
           
            return true;
         
        }

        public int getYear()
        {
            return int.Parse(_year);
        }
    }
}