namespace POO.Concepts.Core;

public class Date
{
    //Fields
    private int _day;
    private int _month;
    private int _year;

    //Constructors Method
    public Date()
    {
        Year = 1900;
        Month = 1;
        Day = 1;
    }

    public Date(int year, int month, int day)
    {
        Year = year;
        Month = month;
        Day = day;
    }

    //Public Properties
    public int Day 
    {
        get 
        {
            return _day; 
        }
        set
        {
            _day = value;
        }
    }

    public int Month
    {
        get
        {
            return _month;
        }
        set
        {
            _month = ValidateMonth(value);
        }
    }

    //Another way to use 'get' when it only has one line with 'return'
    public int Year 
    {
        get => _year;
        set
        {
            _year = ValidateYear(value);
        }
    }

    //Methods

    public override string ToString()
    {
        return $"{Year:0000}/{Month:00}/{Day:00}";
    }

    private bool IsLeapYear (int year)
    {
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }

    private int ValidateYear(int year)
    {
        if (year < 0)
        {
            throw new Exception("Year cannot be negative.");
        }
        return year;
    }

    private int ValidateMonth(int month)
    {
        if (month < 1 || month > 12)
        {
            throw new Exception($"The month: {month} is not valid, should be between 1 and 12.");
        }
        return month;
    }

    private int ValidateDay(int day)
    {
        if (day == 29 && IsLeapYear(Year))
        {
            return day;
        }

        if ((day >= 1 && day <= 28 && Month == 2) ||
            (day >= 1 && day <= 30 && (Month == 4 || Month == 6 || Month == 9 || Month == 11)) ||
            (day >= 1 && day <= 31 && (Month == 1 || Month == 3 || Month == 5 || Month == 7 || Month == 8 || Month == 10 || Month == 12)))
        {
            return day;
        }


        if (day < 1)
        {
            throw new Exception($"The day: {day} is not valid.");
        }
        return day;
    }

}
