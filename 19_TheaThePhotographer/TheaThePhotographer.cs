using System;
  
public class TheaThePhotographer
{
   public static void Main()
    {
        int allPictures = int.Parse(Console.ReadLine());
        int filterTimePerPic = int.Parse(Console.ReadLine());
        byte filterFactor = byte.Parse(Console.ReadLine());
        int uploadTimePerPic = int.Parse(Console.ReadLine());
               
        long filterTime = allPictures * filterTimePerPic;
        int goodPictures = (int)Math.Ceiling(allPictures * filterFactor / 100m);
        long uploadTime = goodPictures * uploadTimePerPic;
        long totalTime = filterTime + uploadTime;

        byte sec = (byte) (totalTime % 60);
        long tempTime = totalTime / 60;
        byte min = (byte)(tempTime % 60);
        tempTime /= 60;
        byte hours = (byte)(tempTime % 60); 
        tempTime /= 60;
        int days = (int)(tempTime / 24);

        Console.WriteLine("{0:0}:{1:00}:{2:00}:{3:00}", days, hours, min, sec);
    }
}

