namespace BoxKite.Notifications.Templates
{
    internal class ToastImageAndText03 : ToastNotificationBase, IToastImageAndText03 
    { 
        public ToastImageAndText03() : base(templateName: "ToastImageAndText03", imageCount: 1, textCount: 2) 
        { 
        } 
 
        public INotificationContentImage Image { get { return Images[0]; } } 
 
        public INotificationContentText TextHeadingWrap { get { return TextFields[0]; } } 
        public INotificationContentText TextBody { get { return TextFields[1]; } } 
    }
}