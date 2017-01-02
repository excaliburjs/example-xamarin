using Game.UWP;
using Xamarin.Forms;

[assembly: Dependency(typeof(BaseUrl))]
namespace Game.UWP
{
    public class BaseUrl : IBaseUrl
    {
        public string Get()
        {
            return "ms-appx-web:///";
        }
    }
}