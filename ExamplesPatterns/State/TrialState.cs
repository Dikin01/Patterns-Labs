using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
  internal class TrialState : State
  {
    private int count = 0;
    public override void BuySubscription(Service service)
    {
      Console.WriteLine("Подписка оформлена!");
      service.state = new SubscriptionState();
    }

    public override void DownlandMusic()
    {
      if(count < 3){
        Console.WriteLine("Музыка скачивается...");
        Console.WriteLine("Завершено!");
        Console.WriteLine("Скачанная музыка станет недоступна по завершению пробного периода.\n");
        count += 1;
      }
      else{
        Console.WriteLine("Пробный период завершен. Купите или отмените подписку.\n");
      }
    }

    public override void GetTrialPeriod(Service service)
    {
      Console.WriteLine("Пробный период уже действует!\n");
    }

    public override void OrderFood()
    {
      if (count < 3)
      {
        Console.WriteLine("Курьер доставит заказ в течение 15-ти минут.\n");
        count += 1;
      }
      else
      {
        Console.WriteLine("Пробный период завершен. Купите или отмените подписку.\n");
      }
    }

    public override void Unsubscribe(Service service)
    {
      service.state = new WithoutSubscriptionState();
      service.isNewUser = false;
    }

    public override void WatchFilm()
    {
      if (count < 3)
      {
        Console.WriteLine("Наслаждайтесь просмотром!\n");
        count += 1;
      }
      else
      {
        Console.WriteLine("Пробный период завершен. Купите или отмените подписку.\n");
      }
    }
  }
}
