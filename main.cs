using System;

class MainClass {
  public static void Main (string[] args) {
    int counter = 0;
    double total = 0;
    int number = 1;
    

    while (counter < 7)
    {
      Console.WriteLine ("Enter the distance covered by car #"+ number++);
      var x = Console.ReadLine ();
      double x1 = Convert.ToDouble(x);
      Console.WriteLine ("Enter the time taken by car");
      var y = Console.ReadLine ();
      double y1 = Convert.ToDouble(y);
      double Speed = x1/y1;
      total = total + Speed;
      Console.WriteLine ("The speed of this car is " + (Speed) + " miles per hour");
      counter++;
    }
   double average = total/7;
   Console.WriteLine("average speed of the cars is " + average + " miles per hour");
  }
}