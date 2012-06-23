namespace BoxKite.Notifications.Templates
{
    /// <summary>
    /// A wide tile template that displays an image and a portion of a text field,
    /// then transitions to show all of the text field.
    /// </summary>
    public interface ITileWidePeekImageAndText01 : IWideTileNotificationContent
    {
        /// <summary>
        /// The main image on the tile.
        /// </summary>
        INotificationContentImage Image { get; }

        /// <summary>
        /// A body text field.
        /// </summary>
        INotificationContentText TextBodyWrap { get; }
    }
}