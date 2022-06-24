using State.Context;

namespace ExamplesPatterns.State
{
    public class StateTest : ITestable
    {
        public void Test()
        {
            // Создаем новое приложение, по умолчанию создастся новый пользователь с неактивной подпиской
            var service = new Service();

            // Попробуем использовать музыкальный сервис и видеохостинг без подписки
            service.DownlandMusic();
            service.WatchFilm();

            // Смотреть с рекламой не очень нравится, поэтому активируем пробный период
            service.GetTrialPeriod();

            // И опробуем несколько сервисов
            service.OrderFood();
            service.OrderFood();
            service.WatchFilm();
            service.WatchFilm();

            // Пробный период закончился, необходимо отписаться... И попробуем заново активировать пробный
            service.Unsubscribe();
            service.GetTrialPeriod();

            // Ничего не выходит, поэтому покупаем подписку и наслаждаемся полным функционалом приложения
            service.BuySubscription();
            service.DownlandMusic();
            service.WatchFilm();
        }
    }
}
