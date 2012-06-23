namespace BoxKite.Notifications.Templates
{
    internal class TileWidePeekImage04 : TileWideBase, ITileWidePeekImage04
    {
        public TileWidePeekImage04()
            : base(templateName: "TileWidePeekImage04", imageCount: 1, textCount: 1)
        {
        }

        public INotificationContentImage Image { get { return Images[0]; } }

        public INotificationContentText TextBodyWrap { get { return TextFields[0]; } }
    }
}