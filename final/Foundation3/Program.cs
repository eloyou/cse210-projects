using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        Address a1 = new Address("Pob. Zone 3","Del Gallego","Camarines Sur","Philippines");
        Address a2 = new Address("Cebu Temple","Cebu City","Cebu","Philippines");
        Lectures lecture = new Lectures("The Book of Mormon","The what and why of The Book of Mormon","04/06/2024","10:00 pm",a1,"Tad Callister",100);
        Reception reception = new Reception("Paula and Angelo Wedding Reception","For time and for all eternity","06/28/23","2:00 - 3:00 pm",a2,"angelobcaringal@gmail.com");
        Outdoor outdoor = new Outdoor("Volleybal Tournament","ward activty","02/24/24","1:00 - 3:00 pm",a1,"Sunny Day");
        
        lecture.GetStandardDetails();
        lecture.GetShortDescription();
        lecture.GetFullDetails();

        Console.WriteLine();

        reception.GetStandardDetails();
        reception.GetShortDescription();
        reception.GetFullDetails();

        Console.WriteLine();

        outdoor.GetStandardDetails();
        outdoor.GetShortDescription();
        outdoor.GetFullDetails();
    }
}