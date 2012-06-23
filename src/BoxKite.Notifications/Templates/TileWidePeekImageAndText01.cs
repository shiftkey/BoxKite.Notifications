namespace BoxKite.Notifications.Templates
{
    internal class TileWidePeekImageAndText01 : TileWideBase, ITileWidePeekImageAndText01
    {
        public TileWidePeekImageAndText01()
            : base(templateName: "TileWidePeekImageAndText01", imageCount: 1, textCount: 1)
        {
        }

        public INotificationContentImage Image { get { return Images[0]; } }

        public INotificationContentText TextBodyWrap { get { return TextFields[0]; } }
    }
}