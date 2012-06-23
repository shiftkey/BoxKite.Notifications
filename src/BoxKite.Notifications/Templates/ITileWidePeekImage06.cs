namespace BoxKite.Notifications.Templates
{
    /// <summary>
    /// A wide tile template that displays an image, then transitions to show
    /// another image and a text field.
    /// </summary>
    public interface ITileWidePeekImage06 : IWideTileNotificationContent
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
        INotificationContentText TextHeadingWrap { get; }
    }
}