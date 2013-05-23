BoxKite.Notifications
===============

## What is this?

Create notifications for your Windows 8 apps without parsing XML like a caveman.

I can't take credit for the initial code - it came from a Windows 8 [MSDN sample](http://code.msdn.microsoft.com/windowsapps/Toast-notifications-sample-52eeba29/).

So rather than copy the source code into each app, I've pulled this out to a NuGet package so that it is easier to consume (for me and for everyone else). I'm also cleaning up the code for readability as I go.

To install it from NuGet:

###`PM> Install-Package BoxKite.Notifications -Version 0.0.4-pre -Pre`

## How do I use it?

First off, have a look at the notification [templates available](http://msdn.microsoft.com/en-us/library/windows/apps/hh761491.aspx) for creating notifications. This will give you an idea of what information you can show to users. 

After installing the NuGet package, add these namespaces to the top of the class:

    using BoxKite.Notifications;
    using BoxKite.Notifications.Templates;

### Tile Notifications

Then, use the `TileContentFactory` static class to create the desired template and populate the content.

    var tileUpdate = TileContentFactory.CreateTileWideSmallImageAndText03();
    tileUpdate.Image.Src = tweet.User.Avatar;
    tileUpdate.TextBodyWrap.Text = tweet.Text;
    tileUpdate.Image.Alt = tweet.User.Name;

    var squareUpdate = TileContentFactory.CreateTileSquareText04();
    squareUpdate.TextBodyWrap.Text = tweet.Text;
    tileUpdate.SquareContent = squareContent;

**Note:** why did I create two tiles? Because the live tiles may be wide or square depending on how the user has configured the tile - don't forget this!

And lastly, send this update to the TileUpdateManager:

    TileUpdateManager.CreateTileUpdaterForApplication().Update(tileUpdate.CreateNotification()); 
  
And that's it. How easy is that?

### Toast Notifications

These behave in a similar way, using `ToastContentFactory` instead.

    var notifier = ToastNotificationManager.CreateToastNotifier();
    if (notifier.Setting == NotificationSetting.Enabled)
    {
        var template = ToastContentFactory.CreateToastImageAndText04();

        template.TextHeading.Text = "Some Heading";
        template.TextBody1.Text = "Words go here";
        template.TextBody2.Text = "and also here";
        template.Image.Src = "https://dl.dropbox.com/u/5803705/sample.png";

        ToastNotificationManager.CreateToastNotifier().Show(template.CreateNotification());    
    }

Oh, and don't forget to enable `Toast Capable` in your manifest. Otherwise toasts probably won't work:

![](https://dl.dropboxusercontent.com/u/5803705/boxkite-notifications-enable-it.png)

## What else is missing?

I haven't integrated the BadgeContent samples (to show numbers or symbols on the tile). Let's see if I can do this now

I'd rather keep this library specialized for a single task, but if there's features you think would work nicely within this context you can get in touch on [Twitter](http://twitter.com/shiftkey) or leave an issue on [the site](https://github.com/shiftkey/BoxKite.Notifications/issues)...

Also open to pull requests to simplify the API - while the syntax makes it easy to discover, I'm not a huge fan of the `template.Foo.Bar.Something` dot-heavy conventions...

## Why MS-LPL (Microsoft Limited Public License)?

Personally, I would have chosen a more permissive license. However this was the licence associated with all the Windows 8 samples. I am not a lawyer, so I am choosing to follow the upstream licenses with this project.
