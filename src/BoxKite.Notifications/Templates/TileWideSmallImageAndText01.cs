namespace BoxKite.Notifications.Templates
{
    internal class TileWideSmallImageAndText01 : TileWideBase, ITileWideSmallImageAndText01
    {
        public TileWideSmallImageAndText01()
            : base(templateName: "TileWideSmallImageAndText01", imageCount: 1, textCount: 1)
        {
        }

        public INotificationContentImage Image { get { return Images[0]; } }

        public INotificationContentText TextHeadingWrap { get { return TextFields[0]; } }
    }
}