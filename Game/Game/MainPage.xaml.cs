using Xamarin.Forms;

namespace Game
{
    /// <summary>
    /// Implemented by each platform to get base URL
    /// </summary>
    public interface IBaseUrl { string Get(); }

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            //
            // Load local web resources
            //
            var htmlSource = new HtmlWebViewSource();

            // Basic index.html file
            htmlSource.Html = @"
<!DOCTYPE html>

<html lang=""en"" xmlns=""http://www.w3.org/1999/xhtml"">
<head>
    <meta charset=""utf-8"" />
</head>
<body>
    <script src=""excalibur.js""></script>
    <script src=""game.js"" ></script>
</body>
</html>";

            // Set baseUrl
            htmlSource.BaseUrl = DependencyService.Get<IBaseUrl>().Get();

            // Set web view source
            GameWebView.Source = htmlSource;
        }
    }
}
