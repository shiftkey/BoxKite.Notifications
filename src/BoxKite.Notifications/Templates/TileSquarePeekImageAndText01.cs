namespace BoxKite.Notifications.Templates
{
    internal class TileSquarePeekImageAndText01 : TileSquareBase, ITileSquarePeekImageAndText01
    {
        public TileSquarePeekImageAndText01()
            : base(templateName: "TileSquarePeekImageAndText01", imageCount: 1, textCount: 4)
        {
        }

        public INotificationContentImage Image { get { return Images[0]; } }

        public INotificationContentText TextHeading { get { return TextFields[0]; } }
        public INotificationContentText TextBody1 { get { return TextFields[1]; } }
        public INotificationContentText TextBody2 { get { return TextFields[2]; } }
        public INotificationContentText TextBody3 { get { return TextFields[3]; } }
    }
}