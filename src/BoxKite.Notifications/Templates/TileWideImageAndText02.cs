namespace BoxKite.Notifications.Templates
{
    internal class TileWideImageAndText02 : TileWideBase, ITileWideImageAndText02
    {
        public TileWideImageAndText02()
            : base(templateName: "TileWideImageAndText02", imageCount: 1, textCount: 2)
        {
        }

        public INotificationContentImage Image { get { return Images[0]; } }

        public INotificationContentText TextCaption1 { get { return TextFields[0]; } }
        public INotificationContentText TextCaption2 { get { return TextFields[1]; } }
    }
}