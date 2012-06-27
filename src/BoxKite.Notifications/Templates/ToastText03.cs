namespace BoxKite.Notifications.Templates
{
    internal class ToastText03 : ToastNotificationBase, IToastText03 
    { 
        public ToastText03() : base(templateName: "ToastText03", imageCount: 0, textCount: 2) 
        { 
        } 
 
        public INotificationContentText TextHeadingWrap { get { return TextFields[0]; } } 
        public INotificationContentText TextBody { get { return TextFields[1]; } } 
    }
}