using System;

using State.ContextState;

namespace State.Context
{
    public class Service
    {
        // Приложение (Context) хранит в себе текущее состояние 
        public AbstractState State { get; set; }

        // А также сохраняет информацию, новый ли это пользователь, которое изменится при смене состояния
        public bool IsNewUser { get; set; }

        // Конструктор по умолчанию содержит в себе информацию: 
        // Состояние подписки - без подписки
        // Пользователь новый
        public Service()
        {
            State = new WithoutSubscriptionState();
            IsNewUser = true;
        }

        // Другой конструктор предусматривает, что состояние может быть отличным от "Без подписки"
        // с начала пользования приложением
        public Service(AbstractState _state)
        {
            State = _state;
            IsNewUser = true;
        }

        // Методы изменения состояния подписки
        // Получить пробный период, причем получить его могут только новые пользователи
        public void GetTrialPeriod()
        {
            if (IsNewUser)
            {
                State.GetTrialPeriod(this);
                Console.WriteLine("Пробная версия активирована!\n");
            }
            else
            {
                Console.WriteLine("Вы уже использовали пробную версию.\n");
            }
        }

        public void BuySubscription()
        {
            State.BuySubscription(this);
            Console.WriteLine("Подписка куплена!\n");
        }

        public void Unsubscribe()
        {
            State.Unsubscribe(this);
            Console.WriteLine("Подписка отменена!\n");
        }

        // Далее методы вызова методов текущего состояния
        public void WatchFilm()
        {
            State.WatchFilm();
        }

        public void OrderFood()
        {
            State.OrderFood();
        }

        public void DownlandMusic()
        {
            State.DownlandMusic();
        }
    }
}
