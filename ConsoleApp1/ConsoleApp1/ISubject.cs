using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  public interface ISubject
  {
    void registerObserver(IObserver o);
    void removeObserver(IObserver o);
    void notifyObserver();  //通知全部的觀察者
  }
}
