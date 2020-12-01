using System;
using System.Collections.Generic;

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
  }

  // This is our interface for vehicles using ICEs
  public interface IRunsOnGas
  {
    double CurrentTankPercentage { get; set; }
    double FuelCapacity { get; set; }
    void RefuelTank();
  }

  // This is our interface for vehicles that are using electric engines bb
  public interface IRunOnElectric
  {
    double BatteryKWh { get; set; }
    double CurrentChargePercentage { get; set; }
    void ChargeBattery();
  }


  public class Zero : Vehicle, IRunOnElectric // Electric motorcycle
  {
    public double BatteryKWh { get; set; } = 100;
    public double CurrentChargePercentage { get; set; } = 0;
    public void ChargeBattery()
    {
      this.CurrentChargePercentage = 100.00;
      Console.WriteLine("*ZAP* Fully Juiced BB!");
    }
    public override void Drive()
    {
      Console.WriteLine($"The {this.MainColor} Zero zips by you! Wahhhhhhhhhhh!");
    }
  }
  public class Scooter : Vehicle, IRunOnElectric // A scootin scooter
  {
    public double BatteryKWh { get; set; } = 0;
    public double CurrentChargePercentage { get; set; } = 0;

    public void ChargeBattery()
    {
      this.CurrentChargePercentage = 100.00;
      Console.WriteLine("*ZAP* Fully Juiced BB!");
    }
    public override void Drive()
    {
      Console.WriteLine($"The {this.MainColor} Scooter scoots by you.");
    }
  }

  public class Jetski : Vehicle, IRunsOnGas // Water motorcycle
  {
    public double FuelCapacity { get; set; }
    public double CurrentTankPercentage { get; set; } = 0;

    public void RefuelTank()
    {
      this.CurrentTankPercentage = 100.00;
      Console.WriteLine("Fill it up Eddy!");
    }
    public override void Drive()
    {
      Console.WriteLine($"The {this.MainColor} Jetski splashes by you! Waaaaasssshhhhhhhh!");
    }
  }

  public class Boat : Vehicle, IRunsOnGas // Water motorcycle
  {
    public double FuelCapacity { get; set; }
    public double CurrentTankPercentage { get; set; } = 0;
    public void RefuelTank()
    {
      this.CurrentTankPercentage = 100.00;
      Console.WriteLine("Fill it up Eddy!");
    }
    public override void Drive()
    {
      Console.WriteLine($"The {this.MainColor} Boat bobs passed you! DING DING!");
    }
  }

  public class Cessna : Vehicle, IRunsOnGas // Propellor light aircraft
  {
    public double FuelCapacity { get; set; }
    public double CurrentTankPercentage { get; set; } = 0;
    public void RefuelTank()
    {
      this.CurrentTankPercentage = 100.00;
      Console.WriteLine("Fill it up Eddy!");
    }

    public override void Drive()
    {
      Console.WriteLine($"The {this.MainColor} Cessna flashes by you! Zooooooommmmmmm!");
    }
    public override void Stop()
    {
      Console.WriteLine($"The {this.MainColor} Cessna rolls to a stop on the runway.");
    }
  }

  public class Tesla : Vehicle, IRunOnElectric  // Electric car
  {
    public double BatteryKWh { get; set; } = 0;
    public double CurrentChargePercentage { get; set; } = 0;

    public void ChargeBattery()
    {
      this.CurrentChargePercentage = 100.00;
      Console.WriteLine("*ZAP* Fully Juiced BB!");
    }
    public override void Drive()
    {
      Console.WriteLine($"The {this.MainColor} Tesla blazes by you! Vrrrrrmmmmmm!");
    }
    public override void Turn(string direction)
    {
      Console.WriteLine($"The {this.MainColor} rips around a {direction} turn!");
    }
  }

  public class Ram : Vehicle, IRunsOnGas  // Gas powered truck
  {
    public double FuelCapacity { get; set; }
    public double CurrentTankPercentage { get; set; } = 0;
    public void RefuelTank()
    {
      this.CurrentTankPercentage = 100.00;
      Console.WriteLine("Fill it up Eddy!");
    }

    public override void Drive()
    {
      Console.WriteLine($"The {this.MainColor} Ram drives past RRrrrrrrrrrummbbbbbbble!");
    }

    public override void Stop()
    {
      Console.WriteLine($"The {this.MainColor} Ram comes rolling to a stop.");
    }
  }

  public class RV : Vehicle, IRunsOnGas  // Gas powered truck
  {
    public double FuelCapacity { get; set; }
    public double CurrentTankPercentage { get; set; } = 0;
    public void RefuelTank()
    {
      this.CurrentTankPercentage = 100.00;
      Console.WriteLine("Fill it up Eddy!");
    }

    public override void Drive()
    {
      Console.WriteLine($"The {this.MainColor} RV rumbles passed you!");
    }

    public override void Stop()
    {
      Console.WriteLine($"The {this.MainColor} RV comes rolling to a stop. WHERE ARE MY GRAND BABIES!");
    }
  }

  // Here is the Main Method for running our code.
  class Program
  {
    static void Main(string[] args)
    {
      Zero fxs = new Zero();
      Zero fx = new Zero();
      Tesla modelS = new Tesla();

      List<IRunOnElectric> electricVehicles = new List<IRunOnElectric>() {
        fx, fxs, modelS
            };

      Console.WriteLine("Electric Vehicles");
      foreach (IRunOnElectric ev in electricVehicles)
      {
        Console.WriteLine($"{ev.CurrentChargePercentage}");
      }

      foreach (IRunOnElectric ev in electricVehicles)
      {
        // This should charge the vehicle to 100%
        ev.ChargeBattery();
      }

      foreach (IRunOnElectric ev in electricVehicles)
      {
        Console.WriteLine($"{ev.CurrentChargePercentage}");
      }

      /***********************************************/

      Ram ram = new Ram();
      Cessna cessna150 = new Cessna();

      List<IRunsOnGas> gasVehicles = new List<IRunsOnGas>() {
        ram, cessna150
            };

      Console.WriteLine("Gas Vehicles");
      foreach (IRunsOnGas gv in gasVehicles)
      {
        Console.WriteLine($"{gv.CurrentTankPercentage}");
      }

      foreach (IRunsOnGas gv in gasVehicles)
      {
        // This should completely refuel the gas tank
        gv.RefuelTank();
      }

      foreach (IRunsOnGas gv in gasVehicles)
      {
        Console.WriteLine($"{gv.CurrentTankPercentage}");
      }
    }
  }
}
