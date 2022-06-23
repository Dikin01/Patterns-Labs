using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
  internal class Service
  {
    public State state { get; set; }
    public bool isNewUser;

    public Service()
    {
      state = new WithoutSubscriptionState();
      isNewUser = true;
    }

    public Service(State _state){
      state = _state;
      isNewUser = true;
    }

    public void GetTrialPeriod(){
      if(isNewUser){
        state.GetTrialPeriod(this);
        Console.WriteLine("Пробная версия активирована!\n");
      }
      else{
        Console.WriteLine("Вы уже использовали пробную версию.\n");
      }
    }

    public void BuySubscription(){
      state.BuySubscription(this);
      Console.WriteLine("Подписка куплена!\n");
    }

    public void Unsubscribe(){
      state.Unsubscribe(this);
      Console.WriteLine("Подписка отменена!\n");
    }
    public void WatchFilm(){
      state.WatchFilm();
    }
    public void OrderFood(){
      state.OrderFood();
    }
    public void DownlandMusic(){
      state.DownlandMusic();
    }
  }
}
