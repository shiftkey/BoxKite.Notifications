namespace BoxKite.Notifications.Templates
{
    /// <summary>
    /// A wide tile template that displays an image and a text caption.
    /// </summary>
    public interface ITileWideImageAndText01 : IWideTileNotificationContent
    {
        /// <summary>
        /// The main image on the tile.
        /// </summary>
        INotificationContentImage Image { get; }

        /// <summary>
        /// A caption for the image.
        /// </summary>
        INotificationContentText TextCaptionWrap { get; }
    }
}