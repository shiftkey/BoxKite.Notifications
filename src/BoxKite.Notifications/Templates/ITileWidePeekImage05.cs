namespace BoxKite.Notifications.Templates
{
    /// <summary>
    /// A wide tile template that displays an image, then transitions to show
    /// another image and two text fields.
    /// </summary>
    public interface ITileWidePeekImage05 : IWideTileNotificationContent
    {
        /// <summary>
        /// The main image on the tile.
        /// </summary>
        INotificationContentImage ImageMain { get; }

        /// <summary>
        /// The secondary image on the tile.
        /// </summary>
        INotificationContentImage ImageSecondary { get; }

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