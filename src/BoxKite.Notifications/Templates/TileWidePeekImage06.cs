namespace BoxKite.Notifications.Templates
{
    internal class TileWidePeekImage06 : TileWideBase, ITileWidePeekImage06
    {
        public TileWidePeekImage06()
            : base(templateName: "TileWidePeekImage06", imageCount: 2, textCount: 1)
        {
        }

        public INotificationContentImage ImageMain { get { return Images[0]; } }
        public INotificationContentImage ImageSecondary { get { return Images[1]; } }

        public INotificationContentText TextHeadingWrap { get { return TextFields[0]; } }
    }
}