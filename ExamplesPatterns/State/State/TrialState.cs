using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
  internal class TrialState : State
  {
    // счетчик, скольок раз были использованы сервисы приложения
    // При превышении лимита приложение отказывает в предоставлении сервисов
    private int count = 0;

    // Наследуемые методы изменения состояния
    public override void BuySubscription(Service service)
    {
      Console.WriteLine("Подписка оформлена!");
      service.state = new SubscriptionState();
    }
    public override void GetTrialPeriod(Service service)
    {
      Console.WriteLine("Пробный период уже действует!\n");
    }
    public override void Unsubscribe(Service service)
    {
      service.state = new WithoutSubscriptionState();
      service.isNewUser = false;
    }

    // Наследуемые методы использования сервисов приложения
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
