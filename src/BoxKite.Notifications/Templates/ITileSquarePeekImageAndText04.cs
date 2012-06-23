namespace BoxKite.Notifications.Templates
{
    /// <summary>
    /// A square tile template that displays an image, then transitions to 
    /// show a text field.
    /// </summary>
    public interface ITileSquarePeekImageAndText04 : ISquareTileNotificationContent
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