/// <reference path="vendor/excalibur.d.ts"/>
var game = new ex.Engine({ displayMode: ex.DisplayMode.FullScreen });
var hello = new ex.Label('Hello Xamarin', game.getWidth() / 2, 100, 'Segoe UI Light');
hello.color = ex.Color.White;
hello.fontSize = 50;
hello.textAlign = ex.TextAlign.Center;
game.add(hello);
game.start();
