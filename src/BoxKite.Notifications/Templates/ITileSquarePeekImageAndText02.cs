namespace BoxKite.Notifications.Templates
{
    /// <summary>
    /// A square tile template that displays an image, then transitions to show
    /// two text fields.
    /// </summary>
    public interface ITileSquarePeekImageAndText02 : ISquareTileNotificationContent
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