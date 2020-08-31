using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  class Program
  {
    static void Main(string[] args)
    {
      WeatherData wd = new WeatherData();
      CurrentConditions cc = new CurrentConditions(wd);
      wd.setMeasurements(80, 65, (float)30.4);
      wd.setMeasurements(82, 75, (float)31.4);
      wd.setMeasurements(78, 90, (float)29.2);

      Console.ReadLine();
    }
  }
}
