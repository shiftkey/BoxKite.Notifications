namespace BoxKite.Notifications.Templates
{
    /// <summary>
    /// A wide tile template that displays an image, then transitions to show
    /// two text fields.
    /// </summary>
    public interface ITileWidePeekImage01 : IWideTileNotificationContent
    {
        /// <summary>
        /// The main image on the tile.
        /// </summary>
        INotificationContentImage Image { get; }

        /// <summary>
        /// A heading text field.
        /// </summary>
        INotificationContentText TextHeading { get; }

        /// <summary>
        /// A body text field.
        /// </summary>
        INotificationContentText TextBodyWrap { get; }
    }
}