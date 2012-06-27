namespace BoxKite.Notifications.Templates
{
    internal class ToastText01 : ToastNotificationBase, IToastText01 
    { 
        public ToastText01() : base(templateName: "ToastText01", imageCount: 0, textCount: 1) 
        { 
        } 
 
        public INotificationContentText TextBodyWrap { get { return TextFields[0]; } } 
    }
}