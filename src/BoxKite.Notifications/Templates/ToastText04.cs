namespace BoxKite.Notifications.Templates
{
    internal class ToastText04 : ToastNotificationBase, IToastText04 
    { 
        public ToastText04() : base(templateName: "ToastText04", imageCount: 0, textCount: 3) 
        { 
        } 
 
        public INotificationContentText TextHeading { get { return TextFields[0]; } } 
        public INotificationContentText TextBody1 { get { return TextFields[1]; } } 
        public INotificationContentText TextBody2 { get { return TextFields[2]; } } 
    }
}