namespace BoxKite.Notifications.Templates
{
    internal class TileSquarePeekImageAndText02 : TileSquareBase, ITileSquarePeekImageAndText02
    {
        public TileSquarePeekImageAndText02()
            : base(templateName: "TileSquarePeekImageAndText02", imageCount: 1, textCount: 2)
        {
        }

        public INotificationContentImage Image { get { return Images[0]; } }

        public INotificationContentText TextHeading { get { return TextFields[0]; } }
        public INotificationContentText TextBodyWrap { get { return TextFields[1]; } }
    }
}