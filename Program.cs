using System;

namespace garyGarage
{
  // this will be the parent class for all the vehicles we have.
  public class Vehicle
  {
    public string MainColor { get; set; }
    public int MaximumOccupancy { get; set; }

    public virtual void Drive()
    {
      Console.WriteLine("Vrooom!");
    }
    public virtual void Turn(string direction)
    {
      Console.WriteLine($"The vehicle makes a {direction} turn!");
    }
    public virtual void Stop()
    {
      Console.WriteLine("The Vehicle comes to a stop!");
    }

    public double BatteryKWh { get; set; }
    public void ChargeBattery()
    {
      Console.WriteLine("*ZAP* Fully Juiced BB!");
    }

    public double FuelCapacity { get; set; }
    public void RefuelTank()
    {
      Console.WriteLine("Fill it up Eddy!");
    }

  }

  public class Zero : Vehicle // Electric motorcycle
  {
    public override void Drive()
    {
      Console.WriteLine($"The {this.MainColor} Zero zips by you! Wahhhhhhhhhhh!");
    }
  }

  public class Cessna : Vehicle // Propellor light aircraft
  {

    public override void Drive()
    {
      Console.WriteLine($"The {this.MainColor} Cessna flashes by you! Zooooooommmmmmm!");
    }
    public override void Stop()
    {
      Console.WriteLine($"The {this.MainColor} Cessna rolls to a stop on the runway.");
    }
  }

  public class Tesla : Vehicle  // Electric car
  {
    public override void Drive()
    {
      Console.WriteLine($"The {this.MainColor} Tesla blazes by you! Vrrrrrmmmmmm!");
    }
    public override void Turn(string direction)
    {
      Console.WriteLine($"The {this.MainColor} rips around a {direction} turn!");
    }
  }

  public class Ram : Vehicle  // Gas powered truck
  {

    public override void Drive()
    {
      Console.WriteLine($"The {this.MainColor} Ram drives past RRrrrrrrrrrummbbbbbbble!");
    }

    public override void Stop()
    {
      Console.WriteLine($"The {this.MainColor} Ram comes rolling to a stop.");
    }
  }

  // Here is the Main Method for running our code.
  class Program
  {
    static void Main(string[] args)
    {
      Zero fxs = new Zero();
      fxs.MainColor = "Dress Black";
      fxs.MaximumOccupancy = 2;
      Tesla modelS = new Tesla();
      modelS.MainColor = "Royal Blue";
      modelS.MaximumOccupancy = 5;
      Cessna mx420 = new Cessna();
      mx420.MainColor = "Safety Yellow";
      mx420.MaximumOccupancy = 3;
      Ram r1500 = new Ram();
      r1500.MainColor = "Biggest Peter Purple";
      r1500.MaximumOccupancy = 6;

      fxs.Drive();
      modelS.Drive();
      modelS.Turn("Left");
      modelS.Stop();
      mx420.Drive();
      mx420.Turn("Right");
      mx420.Stop();
      r1500.Drive();
      r1500.Turn("Left");
      r1500.Stop();

    }
  }
}
