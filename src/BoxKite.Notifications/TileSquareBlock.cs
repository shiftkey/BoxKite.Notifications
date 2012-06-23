namespace BoxKite.Notifications
{
    internal class TileSquareBlock : TileSquareBase, ITileSquareBlock
    {
        public TileSquareBlock()
            : base(templateName: "TileSquareBlock", imageCount: 0, textCount: 2)
        {
        }

        public INotificationContentText TextBlock { get { return TextFields[0]; } }
        public INotificationContentText TextSubBlock { get { return TextFields[1]; } }
    }
}