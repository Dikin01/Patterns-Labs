using System;

using State.Context;

namespace State.ContextState
{
    public class WithoutSubscriptionState : AbstractState
    {
        // Методы изменения состояния
        public override void BuySubscription(Service service)
        {
            service.state = new SubscriptionState();
        }

        public override void Unsubscribe(Service service) { }

        public override void GetTrialPeriod(Service service)
        {
            if (service.isNewUser)
            {
                service.state = new TrialState();
            }
            else
            {
                Console.WriteLine("Вы уже использовали пробный период\n");
            }
        }

        // Наследуемые методы использования сервисов приложения
        public override void OrderFood()
        {
            Console.WriteLine("Курьер доставит заказ в течение часа.\n");
        }

        public override void DownlandMusic()
        {
            Console.WriteLine("Вы не можете скачать музыку на свое устройство!\n");
        }

        public override void WatchFilm()
        {
            Console.WriteLine("*Реклама*");
            Console.WriteLine("Наслаждайтесь просмотром!");
            Console.WriteLine("*Реклама*\n");
        }
    }
}
