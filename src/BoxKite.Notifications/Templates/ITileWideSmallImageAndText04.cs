namespace BoxKite.Notifications.Templates
{
    /// <summary>
    /// A wide tile template that displays an image and two text fields.
    /// </summary>
    public interface ITileWideSmallImageAndText04 : IWideTileNotificationContent
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