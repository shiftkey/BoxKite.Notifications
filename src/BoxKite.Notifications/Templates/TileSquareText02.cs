namespace BoxKite.Notifications.Templates
{
    internal class TileSquareText02 : TileSquareBase, ITileSquareText02
    {
        public TileSquareText02()
            : base(templateName: "TileSquareText02", imageCount: 0, textCount: 2)
        {
        }

        public INotificationContentText TextHeading { get { return TextFields[0]; } }
        public INotificationContentText TextBodyWrap { get { return TextFields[1]; } }
    }
}