namespace BoxKite.Notifications.Templates
{
    internal class ToastImageAndText04 : ToastNotificationBase, IToastImageAndText04 
    { 
        public ToastImageAndText04() : base(templateName: "ToastImageAndText04", imageCount: 1, textCount: 3) 
        { 
        } 
 
        public INotificationContentImage Image { get { return Images[0]; } } 
 
        public INotificationContentText TextHeading { get { return TextFields[0]; } } 
        public INotificationContentText TextBody1 { get { return TextFields[1]; } } 
        public INotificationContentText TextBody2 { get { return TextFields[2]; } } 
    }
}