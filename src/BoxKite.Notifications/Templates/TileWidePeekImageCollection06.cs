namespace BoxKite.Notifications.Templates
{
    internal class TileWidePeekImageCollection06 : TileWideBase, ITileWidePeekImageCollection06
    {
        public TileWidePeekImageCollection06()
            : base(templateName: "TileWidePeekImageCollection06", imageCount: 6, textCount: 1)
        {
        }

        public INotificationContentImage ImageMain { get { return Images[0]; } }
        public INotificationContentImage ImageSmallColumn1Row1 { get { return Images[1]; } }
        public INotificationContentImage ImageSmallColumn2Row1 { get { return Images[2]; } }
        public INotificationContentImage ImageSmallColumn1Row2 { get { return Images[3]; } }
        public INotificationContentImage ImageSmallColumn2Row2 { get { return Images[4]; } }
        public INotificationContentImage ImageSecondary { get { return Images[5]; } }

        public INotificationContentText TextHeadingWrap { get { return TextFields[0]; } }
    }
}