using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
  internal abstract class State
  {
    public abstract void GetTrialPeriod(Service service);
    public abstract void BuySubscription(Service service);
    public abstract void Unsubscribe(Service service);
    public abstract void WatchFilm();
    public abstract void OrderFood();
    public abstract void DownlandMusic();
  }
}
