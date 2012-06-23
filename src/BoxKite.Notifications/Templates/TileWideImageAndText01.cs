namespace BoxKite.Notifications.Templates
{
    internal class TileWideImageAndText01 : TileWideBase, ITileWideImageAndText01
    {
        public TileWideImageAndText01()
            : base(templateName: "TileWideImageAndText01", imageCount: 1, textCount: 1)
        {
        }

        public INotificationContentImage Image { get { return Images[0]; } }

        public INotificationContentText TextCaptionWrap { get { return TextFields[0]; } }
    }
}