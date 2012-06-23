BoxKite.Notifications
===============

## What is this?

Create notifications inside your Win8 apps using C# objects rather than fiddling with XML. 

I can't take credit for the initial code - I found it inside an MSDN sample - specifically [this one](http://code.msdn.microsoft.com/windowsapps/Toast-notifications-sample-52eeba29/).

But rather than include the source code for every app, I've pulled this out to a NuGet package so that it is easier to consume (for me and for everyone else).

**Install-Package BoxKite.Notifications**

## How to use

First off, get familiar with the [templates available](http://msdn.microsoft.com/en-us/library/windows/apps/hh761491.aspx) when creating notifications.

After installing the NuGet package, add these namespaces to the top of the class:

    using BoxKite.Notifications;
    using BoxKite.Notifications.Templates;

Then, use the `ToastContentFactory` static class to create the desired template and populate the content:

    var tileContent = TileContentFactory.CreateTileWideSmallImageAndText03();
    tileContent.Image.Src = tweet.User.Avatar;
    tileContent.TextBodyWrap.Text = tweet.Text;
    tileContent.Image.Alt = tweet.User.Name;

    var squareContent = TileContentFactory.CreateTileSquareText04();
    squareContent.TextBodyWrap.Text = tweet.Text;
    tileContent.SquareContent = squareContent;

**Note:** why did I create two tiles? Because the live tiles may be wide or square depending on how the user has configured the tile - don't forget this!

And lastly, send this update to the ToastNotificationManager:

    var toast = toastContent.CreateNotification(); 
 
    ToastNotificationManager.CreateToastNotifier().Show(toast); 
  
And that's it. How easy is that?

## What else is missing?

Not sure. I'd rather keep this library specialized for this task, but if there's features you think would work nicely why not get in touch on [Twitter](http://twitter.com/shiftkey) or leave an issue on [the site](https://github.com/shiftkey/BoxKite.Notifications/issues)...