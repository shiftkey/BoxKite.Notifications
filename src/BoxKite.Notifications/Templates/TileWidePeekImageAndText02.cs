namespace BoxKite.Notifications.Templates
{
    internal class TileWidePeekImageAndText02 : TileWideBase, ITileWidePeekImageAndText02
    {
        public TileWidePeekImageAndText02()
            : base(templateName: "TileWidePeekImageAndText02", imageCount: 1, textCount: 5)
        {
        }

        public INotificationContentImage Image { get { return Images[0]; } }

        public INotificationContentText TextBody1 { get { return TextFields[0]; } }
        public INotificationContentText TextBody2 { get { return TextFields[1]; } }
        public INotificationContentText TextBody3 { get { return TextFields[2]; } }
        public INotificationContentText TextBody4 { get { return TextFields[3]; } }
        public INotificationContentText TextBody5 { get { return TextFields[4]; } }
    }
}