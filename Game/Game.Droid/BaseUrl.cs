using Game.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(BaseUrl))]
namespace Game.Droid
{
    public class BaseUrl : IBaseUrl
    {
        public string Get()
        {
            return "file:///android_asset/";
        }
    }
}