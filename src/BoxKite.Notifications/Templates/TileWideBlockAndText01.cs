namespace BoxKite.Notifications.Templates
{
    internal class TileWideBlockAndText01 : TileWideBase, ITileWideBlockAndText01
    {
        public TileWideBlockAndText01()
            : base(templateName: "TileWideBlockAndText01", imageCount: 0, textCount: 6)
        {
        }

        public INotificationContentText TextBody1 { get { return TextFields[0]; } }
        public INotificationContentText TextBody2 { get { return TextFields[1]; } }
        public INotificationContentText TextBody3 { get { return TextFields[2]; } }
        public INotificationContentText TextBody4 { get { return TextFields[3]; } }
        public INotificationContentText TextBlock { get { return TextFields[4]; } }
        public INotificationContentText TextSubBlock { get { return TextFields[5]; } }
    }
}