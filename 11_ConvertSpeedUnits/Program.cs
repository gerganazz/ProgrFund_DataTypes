using System;
   
class Program
{
    static void Main()
    {
        float distMeters = float.Parse(Console.ReadLine());
        int hours = int.Parse(Console.ReadLine());
        int min = int.Parse(Console.ReadLine());
        int sec = int.Parse(Console.ReadLine());

        int timeSec = hours * 60 * 60 + min * 60 + sec;
        float timeHours = timeSec / 3600f;
        float distKm = distMeters / 1000;
        float distMiles = distMeters / 1609;

        float speedMPS = distMeters / timeSec;
        float speedKPH = distKm / timeHours;
        float speedMPH = distMiles / timeHours;

        Console.WriteLine(speedMPS);
        Console.WriteLine(speedKPH);
        Console.WriteLine(speedMPH);
    }                                     
}

