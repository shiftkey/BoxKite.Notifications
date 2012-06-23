namespace BoxKite.Notifications.Templates
{
    internal class TileSquareText03 : TileSquareBase, ITileSquareText03
    {
        public TileSquareText03()
            : base(templateName: "TileSquareText03", imageCount: 0, textCount: 4)
        {
        }

        public INotificationContentText TextBody1 { get { return TextFields[0]; } }
        public INotificationContentText TextBody2 { get { return TextFields[1]; } }
        public INotificationContentText TextBody3 { get { return TextFields[2]; } }
        public INotificationContentText TextBody4 { get { return TextFields[3]; } }
    }
}