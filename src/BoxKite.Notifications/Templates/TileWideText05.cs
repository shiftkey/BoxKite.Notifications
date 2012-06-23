namespace BoxKite.Notifications.Templates
{
    internal class TileWideText05 : TileWideBase, ITileWideText05
    {
        public TileWideText05()
            : base(templateName: "TileWideText05", imageCount: 0, textCount: 5)
        {
        }

        public INotificationContentText TextBody1 { get { return TextFields[0]; } }
        public INotificationContentText TextBody2 { get { return TextFields[1]; } }
        public INotificationContentText TextBody3 { get { return TextFields[2]; } }
        public INotificationContentText TextBody4 { get { return TextFields[3]; } }
        public INotificationContentText TextBody5 { get { return TextFields[4]; } }
    }
}