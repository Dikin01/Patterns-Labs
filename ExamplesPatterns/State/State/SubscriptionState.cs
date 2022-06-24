using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
  internal class SubscriptionState : State
  {
    // Методы изменения состояния
    public override void BuySubscription(Service service)
    {
      Console.WriteLine("Подписка уже куплена\n");
    }
    public override void GetTrialPeriod(Service service)
    { } // Пожалуй, не за чем использовать пробный период, когда подписка уже активна
    public override void Unsubscribe(Service service)
    {
      Console.WriteLine("Подписка отменена!\n");
      service.state = new WithoutSubscriptionState();
      service.isNewUser = false;
    }

    // Наследуемые методы использования сервисов приложения
    public override void DownlandMusic()
    {
      Console.WriteLine("Музыка скачивается...");
      Console.WriteLine("Завершено!\n");
    }

    public override void OrderFood()
    {
      Console.WriteLine("Курьер доставит заказ в течение 10-ти минут.\n");
    }

    public override void WatchFilm()
    {
      Console.WriteLine("Наслаждайтесь просмотром!\n");
    }
  }
}
