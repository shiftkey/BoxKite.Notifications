namespace BoxKite.Notifications.Templates
{
    internal class TileWideText01 : TileWideBase, ITileWideText01
    {
        public TileWideText01()
            : base(templateName: "TileWideText01", imageCount: 0, textCount: 5)
        {
        }

        public INotificationContentText TextHeading { get { return TextFields[0]; } }
        public INotificationContentText TextBody1 { get { return TextFields[1]; } }
        public INotificationContentText TextBody2 { get { return TextFields[2]; } }
        public INotificationContentText TextBody3 { get { return TextFields[3]; } }
        public INotificationContentText TextBody4 { get { return TextFields[4]; } }
    }
}