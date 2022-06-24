using System;

using State.Context;

namespace State.ContextState
{
    public class TrialState : AbstractState
    {
        // Лимит использования сервисов
        private const int _limitNumberUses = 3;

        // Cчетчик, сколько раз были использованы сервисы приложения
        // При превышении лимита приложение отказывает в предоставлении сервисов
        private int _numberUses = 0;

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
            if (_numberUses < _limitNumberUses)
            {
                Console.WriteLine("Музыка скачивается...");
                Console.WriteLine("Завершено!");
                Console.WriteLine("Скачанная музыка станет недоступна по завершению пробного периода.\n");
                _numberUses ++;
            }
            else
            {
                Console.WriteLine("Пробный период завершен. Купите или отмените подписку.\n");
            }
        }

        public override void OrderFood()
        {
            if (_numberUses < _limitNumberUses)
            {
                Console.WriteLine("Курьер доставит заказ в течение 15-ти минут.\n");
                _numberUses++;
            }
            else
            {
                Console.WriteLine("Пробный период завершен. Купите или отмените подписку.\n");
            }
        }

        public override void WatchFilm()
        {
            if (_numberUses < _limitNumberUses)
            {
                Console.WriteLine("Наслаждайтесь просмотром!\n");
                _numberUses++;
            }
            else
            {
                Console.WriteLine("Пробный период завершен. Купите или отмените подписку.\n");
            }
        }
    }
}
