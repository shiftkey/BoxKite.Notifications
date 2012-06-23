namespace BoxKite.Notifications.Templates
{
    /// <summary>
    /// A wide tile template that displays an image, then transitions to show
    /// a text field.
    /// </summary>
    public interface ITileWidePeekImage03 : IWideTileNotificationContent
    {
        /// <summary>
        /// The main image on the tile.
        /// </summary>
        INotificationContentImage Image { get; }

        /// <summary>
        /// A heading text field.
        /// </summary>
        INotificationContentText TextHeadingWrap { get; }
    }
}