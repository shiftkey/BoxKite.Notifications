namespace BoxKite.Notifications.Templates
{
    internal class TileWideText04 : TileWideBase, ITileWideText04
    {
        public TileWideText04()
            : base(templateName: "TileWideText04", imageCount: 0, textCount: 1)
        {
        }

        public INotificationContentText TextBodyWrap { get { return TextFields[0]; } }
    }
}