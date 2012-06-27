namespace BoxKite.Notifications.Templates
{
    internal class ToastImageAndText01 : ToastNotificationBase, IToastImageAndText01 
    { 
        public ToastImageAndText01() : base(templateName: "ToastImageAndText01", imageCount: 1, textCount: 1) 
        { 
        } 
 
        public INotificationContentImage Image { get { return Images[0]; } } 
 
        public INotificationContentText TextBodyWrap { get { return TextFields[0]; } } 
    }
}