using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  public class CurrentConditions : IObserver
  {
    private float temperature;
    private float humidity;
    private float pressure;
    private ISubject subject;
    public CurrentConditions(ISubject _subject)
    {
      subject = _subject;
      subject.registerObserver(this);
    }
    public void update(float temperature, float humidity, float pressure)
    {
      this.temperature = temperature;
      this.humidity = humidity;
      this.pressure = pressure;
      display();
    }
    public void display()
    {
      Console.WriteLine("[CurrentConditions]");
      Console.WriteLine("temperature: "+ temperature.ToString());
      Console.WriteLine("humidity: " + humidity.ToString());
      Console.WriteLine("pressure: " + pressure.ToString());
    }
  }
}
