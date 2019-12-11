using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace XFEssentialsTest.ViewModels
{
    public class TextToSpeechViewModel : BaseViewModel
    {
        string _text;
        public string Text
        {
            get => _text;
            set => SetProperty(ref _text, value);
        }

        public ICommand SpeechCommand { get; private set; }

        public TextToSpeechViewModel()
        {
            SpeechCommand = new Command(async () => await SpeechExecute());
        }

        private async Task SpeechExecute()
        {
            var locales = await TextToSpeech.GetLocalesAsync();
            var language = System.Globalization.CultureInfo.CurrentCulture.ToString();
            var locale = locales.FirstOrDefault(l => l.Language == language);
            var settings = new SpeechOptions()
            {
                Volume = .75f,
                Pitch = 1.0f,
                Locale = locale
            };

            await TextToSpeech.SpeakAsync(Text, settings);
        }
    }
}
