namespace BoxKite.Notifications.Templates
{
    internal class TileWidePeekImageCollection04 : TileWideBase, ITileWidePeekImageCollection04
    {
        public TileWidePeekImageCollection04()
            : base(templateName: "TileWidePeekImageCollection04", imageCount: 5, textCount: 1)
        {
        }

        public INotificationContentImage ImageMain { get { return Images[0]; } }
        public INotificationContentImage ImageSmallColumn1Row1 { get { return Images[1]; } }
        public INotificationContentImage ImageSmallColumn2Row1 { get { return Images[2]; } }
        public INotificationContentImage ImageSmallColumn1Row2 { get { return Images[3]; } }
        public INotificationContentImage ImageSmallColumn2Row2 { get { return Images[4]; } }

        public INotificationContentText TextBodyWrap { get { return TextFields[0]; } }
    }
}