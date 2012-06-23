namespace BoxKite.Notifications.Templates
{
    internal class TileSquareText01 : TileSquareBase, ITileSquareText01
    {
        public TileSquareText01()
            : base(templateName: "TileSquareText01", imageCount: 0, textCount: 4)
        {
        }

        public INotificationContentText TextHeading { get { return TextFields[0]; } }
        public INotificationContentText TextBody1 { get { return TextFields[1]; } }
        public INotificationContentText TextBody2 { get { return TextFields[2]; } }
        public INotificationContentText TextBody3 { get { return TextFields[3]; } }
    }
}