namespace BoxKite.Notifications.Templates
{
    internal class TileWidePeekImage03 : TileWideBase, ITileWidePeekImage03
    {
        public TileWidePeekImage03()
            : base(templateName: "TileWidePeekImage03", imageCount: 1, textCount: 1)
        {
        }

        public INotificationContentImage Image { get { return Images[0]; } }

        public INotificationContentText TextHeadingWrap { get { return TextFields[0]; } }
    }
}