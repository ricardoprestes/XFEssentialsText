using Xamarin.Essentials;

namespace XFEssentialsTest.Helpers
{
    public static class Settings
    {
        public static string Token
        {
            get => SecureStorage.GetAsync(nameof(Token)).Result;
            set => SecureStorage.SetAsync(nameof(Token), value);
        }

        public static void Reset()
        {
            SecureStorage.RemoveAll();
        }
    }
}
