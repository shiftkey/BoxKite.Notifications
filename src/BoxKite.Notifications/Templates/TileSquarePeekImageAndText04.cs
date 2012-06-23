namespace BoxKite.Notifications.Templates
{
    internal class TileSquarePeekImageAndText04 : TileSquareBase, ITileSquarePeekImageAndText04
    {
        public TileSquarePeekImageAndText04()
            : base(templateName: "TileSquarePeekImageAndText04", imageCount: 1, textCount: 1)
        {
        }

        public INotificationContentImage Image { get { return Images[0]; } }

        public INotificationContentText TextBodyWrap { get { return TextFields[0]; } }
    }
}