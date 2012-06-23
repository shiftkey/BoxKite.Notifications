namespace BoxKite.Notifications.Templates
{
    internal class TileWidePeekImage05 : TileWideBase, ITileWidePeekImage05
    {
        public TileWidePeekImage05()
            : base(templateName: "TileWidePeekImage05", imageCount: 2, textCount: 2)
        {
        }

        public INotificationContentImage ImageMain { get { return Images[0]; } }
        public INotificationContentImage ImageSecondary { get { return Images[1]; } }

        public INotificationContentText TextHeading { get { return TextFields[0]; } }
        public INotificationContentText TextBodyWrap { get { return TextFields[1]; } }
    }
}