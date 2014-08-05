using System;

class BooleanVariable
{
    static void Main(string[] args)
    {
        string myGender = "male";
        bool isFemale;
        if (myGender == "male")
        {
            isFemale = false;
            Console.WriteLine("My gender is female: " + isFemale);
        }
        else if (myGender != "male")
        {
            isFemale = true;
            Console.WriteLine("My gender is female:" + isFemale);
        }

    }
}

