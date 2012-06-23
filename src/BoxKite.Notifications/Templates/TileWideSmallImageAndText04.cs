namespace BoxKite.Notifications.Templates
{
    internal class TileWideSmallImageAndText04 : TileWideBase, ITileWideSmallImageAndText04
    {
        public TileWideSmallImageAndText04()
            : base(templateName: "TileWideSmallImageAndText04", imageCount: 1, textCount: 2)
        {
        }

        public INotificationContentImage Image { get { return Images[0]; } }

        public INotificationContentText TextHeading { get { return TextFields[0]; } }
        public INotificationContentText TextBodyWrap { get { return TextFields[1]; } }
    }
}