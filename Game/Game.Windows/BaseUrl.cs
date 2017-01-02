using Game.Windows;
using Xamarin.Forms;

[assembly: Dependency(typeof(BaseUrl))]
namespace Game.Windows
{
    public class BaseUrl : IBaseUrl
    {
        public string Get()
        {
            return "";
        }
    }
}