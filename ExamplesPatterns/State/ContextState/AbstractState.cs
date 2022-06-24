using State.Context;

namespace State.ContextState
{
    public abstract class AbstractState
    {
        public abstract void GetTrialPeriod(Service service);
        public abstract void BuySubscription(Service service);
        public abstract void Unsubscribe(Service service);
        public abstract void WatchFilm();
        public abstract void OrderFood();
        public abstract void DownlandMusic();
    }
}
