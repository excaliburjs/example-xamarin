using Xamarin.Forms;
using Game.iOS;
using Foundation;

[assembly: Dependency(typeof(BaseUrl))]
namespace Game.iOS
{
    public class BaseUrl : IBaseUrl
    {
        public string Get()
        {
            return NSBundle.MainBundle.BundlePath;
        }
    }
}