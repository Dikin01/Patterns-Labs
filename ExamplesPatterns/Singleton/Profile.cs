using System;
using System.Collections.Generic;

namespace ExamplesPatterns.Singleton
{
    // Нашим Одиночкой будет профиль пользователя
    public class Profile
    {
        public string Name { get; set; }
        public Dictionary<string, string> Settings { get; private set; }

        // Используем класс Lazy<T> для отложенной инициализации,
        // для потокобезопасности добавим модификатор readonly
        private static readonly Lazy<Profile> _instance =
            new(() => new Profile());

        private Profile() 
        {
            Settings = new Dictionary<string, string>();
        }            

        public static Profile Instance
        {
            get
            {
                return _instance.Value;
            }
        }
    }
}
