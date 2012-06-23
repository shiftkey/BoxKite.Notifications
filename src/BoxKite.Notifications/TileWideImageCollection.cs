namespace BoxKite.Notifications
{
    internal class TileWideImageCollection : TileWideBase, ITileWideImageCollection
    {
        public TileWideImageCollection()
            : base(templateName: "TileWideImageCollection", imageCount: 5, textCount: 0)
        {
        }

        public INotificationContentImage ImageMain { get { return Images[0]; } }
        public INotificationContentImage ImageSmallColumn1Row1 { get { return Images[1]; } }
        public INotificationContentImage ImageSmallColumn2Row1 { get { return Images[2]; } }
        public INotificationContentImage ImageSmallColumn1Row2 { get { return Images[3]; } }
        public INotificationContentImage ImageSmallColumn2Row2 { get { return Images[4]; } }
    }
}