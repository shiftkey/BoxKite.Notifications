namespace BoxKite.Notifications.Templates
{
    /// <summary>
    /// A wide tile template that displays an image and a text field.
    /// </summary>
    public interface ITileWideSmallImageAndText01 : IWideTileNotificationContent
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