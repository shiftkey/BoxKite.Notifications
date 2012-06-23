namespace BoxKite.Notifications.Templates
{
    internal class TileWidePeekImage01 : TileWideBase, ITileWidePeekImage01
    {
        public TileWidePeekImage01()
            : base(templateName: "TileWidePeekImage01", imageCount: 1, textCount: 2)
        {
        }

        public INotificationContentImage Image { get { return Images[0]; } }

        public INotificationContentText TextHeading { get { return TextFields[0]; } }
        public INotificationContentText TextBodyWrap { get { return TextFields[1]; } }
    }
}