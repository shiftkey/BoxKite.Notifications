namespace BoxKite.Notifications.Templates
{
    internal class TileWideText03 : TileWideBase, ITileWideText03
    {
        public TileWideText03()
            : base(templateName: "TileWideText03", imageCount: 0, textCount: 1)
        {
        }

        public INotificationContentText TextHeadingWrap { get { return TextFields[0]; } }
    }
}