namespace BoxKite.Notifications.Templates
{
    internal class TileWideSmallImageAndText03 : TileWideBase, ITileWideSmallImageAndText03
    {
        public TileWideSmallImageAndText03()
            : base(templateName: "TileWideSmallImageAndText03", imageCount: 1, textCount: 1)
        {
        }

        public INotificationContentImage Image { get { return Images[0]; } }

        public INotificationContentText TextBodyWrap { get { return TextFields[0]; } }
    }
}