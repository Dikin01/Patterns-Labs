using System;

using State.ContextState;

namespace State.Context
{
    public class Service
    {
        // Приложение (Context) хранит в себе текущее состояние 
        public AbstractState state { get; set; }

        // А также сохраняет информацию, новый ли это пользователь, которое изменится при смене состояния
        public bool isNewUser;

        // Конструктор по умолчанию содержит в себе информацию: 
        // Состояние подписки - без подписки
        // Пользователь новый
        public Service()
        {
            state = new WithoutSubscriptionState();
            isNewUser = true;
        }

        // Другой конструктор предусматривает, что состояние может быть отличным от "Без подписки"
        // с начала пользования приложением
        public Service(AbstractState _state)
        {
            state = _state;
            isNewUser = true;
        }

        // Методы изменения состояния подписки
        // Получить пробный период, причем получить его могут только новые пользователи
        public void GetTrialPeriod()
        {
            if (isNewUser)
            {
                state.GetTrialPeriod(this);
                Console.WriteLine("Пробная версия активирована!\n");
            }
            else
            {
                Console.WriteLine("Вы уже использовали пробную версию.\n");
            }
        }

        public void BuySubscription()
        {
            state.BuySubscription(this);
            Console.WriteLine("Подписка куплена!\n");
        }

        public void Unsubscribe()
        {
            state.Unsubscribe(this);
            Console.WriteLine("Подписка отменена!\n");
        }

        // Далее методы вызова методов текущего состояния
        public void WatchFilm()
        {
            state.WatchFilm();
        }

        public void OrderFood()
        {
            state.OrderFood();
        }

        public void DownlandMusic()
        {
            state.DownlandMusic();
        }
    }
}
