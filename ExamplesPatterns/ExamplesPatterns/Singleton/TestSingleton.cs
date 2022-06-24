using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace ExamplesPatterns.Singleton
{
    public class TestSingleton : ITestable
    {
        // Проверим, что получилось
        public void Test()
        {
            // Одиночка проинициализируется при первом вызове Instance
            var userProfile = Profile.Instance;

            // Изменим имя профиле и добавим настроек
            userProfile.Name = "Ivan";
            userProfile.Settings.Add("theme", "dark");
            userProfile.Settings.Add("notifications", "false");

            // Теперь мы может передать экземпляр одиночки в любой метод
            UseProfile(userProfile);

            // Мы также можем сериализовать Одиноку, чтобы сохранить его на диске или БД            
            var serializedUserProfile = JsonSerializer.Serialize(userProfile);
            Console.WriteLine(serializedUserProfile);

            // А десериализацию можно реализовать в конструкторе Одиночки
        }

        private void UseProfile(Profile profile)
        {
            Console.WriteLine($"Profile name: {profile.Name}");

            foreach (var setting in profile.Settings)
                Console.WriteLine($"{setting.Key}: {setting.Value}");
        }
    }
}
