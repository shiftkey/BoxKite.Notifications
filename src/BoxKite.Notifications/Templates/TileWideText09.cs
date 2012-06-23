namespace BoxKite.Notifications.Templates
{
    internal class TileWideText09 : TileWideBase, ITileWideText09
    {
        public TileWideText09()
            : base(templateName: "TileWideText09", imageCount: 0, textCount: 2)
        {
        }

        public INotificationContentText TextHeading { get { return TextFields[0]; } }
        public INotificationContentText TextBodyWrap { get { return TextFields[1]; } }
    }
}