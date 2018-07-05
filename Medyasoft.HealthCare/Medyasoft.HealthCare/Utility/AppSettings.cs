using Medyasoft.HealthCare.Extensions;
using Medyasoft.HealthCare.Models;
using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace Medyasoft.HealthCare.Utility
{
    public static class AppSettings
    {
        private static ISettings Settings => CrossSettings.Current;

        public static User User
        {
            get => Settings.GetValueOrDefault(nameof(User), default(User));

            set => Settings.AddOrUpdateValue(nameof(User), value);
        }
    }
}