namespace BoxKite.Notifications
{
    internal class TileWideImage : TileWideBase, ITileWideImage
    {
        public TileWideImage()
            : base(templateName: "TileWideImage", imageCount: 1, textCount: 0)
        {
        }

        public INotificationContentImage Image { get { return Images[0]; } }
    }
}