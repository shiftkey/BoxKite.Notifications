namespace BoxKite.Notifications.Templates
{
    internal class ToastText02 : ToastNotificationBase, IToastText02 
    { 
        public ToastText02() : base(templateName: "ToastText02", imageCount: 0, textCount: 2) 
        { 
        } 
 
        public INotificationContentText TextHeading { get { return TextFields[0]; } } 
        public INotificationContentText TextBodyWrap { get { return TextFields[1]; } } 
    }
}