namespace BoxKite.Notifications
{
    internal class TileSquareImage : TileSquareBase, ITileSquareImage
    {
        public TileSquareImage()
            : base(templateName: "TileSquareImage", imageCount: 1, textCount: 0)
        {
        }

        public INotificationContentImage Image { get { return Images[0]; } }
    }
}