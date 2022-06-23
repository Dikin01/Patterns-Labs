using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
  internal class WithoutSubscriptionState : State
  {
    public override void BuySubscription(Service service)
    {
      service.state = new SubscriptionState();
    }

    public override void DownlandMusic()
    {
      Console.WriteLine("Вы не можете скачать музыку на свое устройство!\n");
    }

    public override void GetTrialPeriod(Service service)
    {
      if(service.isNewUser == true){
        service.state = new TrialState();
      }
      else{
        Console.WriteLine("Вы уже использовали пробный период\n");
      }
    }

    public override void OrderFood()
    {
      Console.WriteLine("Курьер доставит заказ в течение часа.\n");
    }

    public override void Unsubscribe(Service service)
    { }

    public override void WatchFilm()
    {
      Console.WriteLine("*Реклама*");
      Console.WriteLine("Наслаждайтесь просмотром!");
      Console.WriteLine("*Реклама*\n");
    }
  }
}
