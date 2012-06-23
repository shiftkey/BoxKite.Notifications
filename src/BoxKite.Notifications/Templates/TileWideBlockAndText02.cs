namespace BoxKite.Notifications.Templates
{
    internal class TileWideBlockAndText02 : TileWideBase, ITileWideBlockAndText02
    {
        public TileWideBlockAndText02()
            : base(templateName: "TileWideBlockAndText02", imageCount: 0, textCount: 6)
        {
        }

        public INotificationContentText TextBodyWrap { get { return TextFields[0]; } }
        public INotificationContentText TextBlock { get { return TextFields[1]; } }
        public INotificationContentText TextSubBlock { get { return TextFields[2]; } }
    }
}