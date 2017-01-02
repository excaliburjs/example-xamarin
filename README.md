# Excalibur Xamarin Forms Example

This example shows how to embed your Excalibur game into a Xamarin Forms WebView control and
allow access to local assets. You can use it as a basis for your own native cross-platform
mobile game!

## Prerequisites

- Visual Studio 2015 Community or higher
- Xamarin SDK 4.2.1+
- Android SDKs
- Windows 10 SDK

The easiest way to install Xamarin is through the [VS Installer](https://go.microsoft.com/fwlink/?LinkId=691978&clcid=0x409).
Make sure to select all the Xamarin, Android, and Windows SDKs. To test the iOS app, you will need to
set up Xamarin for iOS. Follow the [guides](https://developer.xamarin.com/guides/ios/getting_started/) 
on Xamarin to do so.

This app is using the Visual Studio Xamarin XAML (Portable) project template.

## Launch

Choose the project you want to test and run it (F5). 

## Notes

To host a local web app in Xamarin, you must create a DependencyService for each platform to get the
"base url". In each platform project you can see an example (**BaseUrl.cs**). The code follows the same sample from
Xamarin, [Working with WebView](https://github.com/xamarin/xamarin-forms-samples/tree/master/WorkingWithWebview).
We simply followed the [WebView](https://developer.xamarin.com/guides/xamarin-forms/user-interface/webview/)
guide on Xamarin Forms guides.

In the Game (Portable) class library, the **MainPage.xaml.cs** file has an example of setting the HTML
source of the WebView control. We are hardcoding the "index" HTML, but you could use the [Xamarin
file APIs](https://developer.xamarin.com/guides/xamarin-forms/working-with/files/) to read an embedded resource.

The Game class library also is using TypeScript which compiles to a **game.js** file. The Excalibur dist files
are in the **vendor** directory.

The key to sharing the game.js and excalibur.js files is through the Visual Studio 
"[Add as Link](https://msdn.microsoft.com/en-us/library/9f4t9t92.aspx)" feature. This
does not create a physical copy of the file, allowing you to update a single file and have it used across
all platforms.