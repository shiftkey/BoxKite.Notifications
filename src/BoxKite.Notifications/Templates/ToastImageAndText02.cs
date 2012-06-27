namespace BoxKite.Notifications.Templates
{
    internal class ToastImageAndText02 : ToastNotificationBase, IToastImageAndText02 
    { 
        public ToastImageAndText02() : base(templateName: "ToastImageAndText02", imageCount: 1, textCount: 2) 
        { 
        } 
 
        public INotificationContentImage Image { get { return Images[0]; } } 
 
        public INotificationContentText TextHeading { get { return TextFields[0]; } } 
        public INotificationContentText TextBodyWrap { get { return TextFields[1]; } } 
    }
}