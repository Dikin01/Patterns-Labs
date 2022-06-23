using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
  internal class SubscriptionState : State
  {
    public override void BuySubscription(Service service)
    {
      Console.WriteLine("Подписка уже куплена\n");
    }

    public override void DownlandMusic()
    {
      Console.WriteLine("Музыка скачивается...");
      Console.WriteLine("Завершено!\n");
    }

    public override void GetTrialPeriod(Service service)
    {}

    public override void OrderFood()
    {
      Console.WriteLine("Курьер доставит заказ в течение 10-ти минут.\n");
    }

    public override void Unsubscribe(Service service)
    {
      Console.WriteLine("Подписка отменена!\n");
      service.state = new WithoutSubscriptionState();
      service.isNewUser = false;
    }

    public override void WatchFilm()
    {
      Console.WriteLine("Наслаждайтесь просмотром!\n");
    }
  }
}
