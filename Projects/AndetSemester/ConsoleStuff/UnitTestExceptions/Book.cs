using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestExceptions
{
    public class Book
    {
        private string _title;
        private int _year;

        public string Title
        {
            get { return _title; }
            set { CheckTitle(value);_title = value; }
        }

        public int Year
        {
            get { return _year; }
            set { CheckYear(value);_year = value; }
        }

        public Book(string title, int year)
        {
            CheckTitle(title);
            CheckYear(year);
            _title = title;
            _year = year;
        }

        public static void CheckTitle(string title)
        {
            if (String.IsNullOrWhiteSpace(title))
            {
                throw new ArgumentException("Title is null or empty");
            }

            if (title.Length <= 2)
            {
                throw new ArgumentException("Title must be more than 2 characters long");
            }
        }

        public static void CheckYear(int year)
        {
            if (year <= 1100 || year >= 2015)
            {
                throw new ArgumentException("Year has to be between 1100 and 2015");
            }
        }

        public override string ToString()
        {
            return $"Title: {Title}, Year: {Year}";
        }
    }
}
