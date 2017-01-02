using Game.WinPhone;
using Xamarin.Forms;

[assembly: Dependency(typeof(BaseUrl))]
namespace Game.WinPhone
{
    public class BaseUrl : IBaseUrl
    {
        public string Get()
        {
            return "";
        }
    }
}