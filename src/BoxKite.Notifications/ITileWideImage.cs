namespace BoxKite.Notifications
{
    /// <summary>
    /// A wide tile template that displays an image.
    /// </summary>
    public interface ITileWideImage : IWideTileNotificationContent
    {
        /// <summary>
        /// The main image on the tile.
        /// </summary>
        INotificationContentImage Image { get; }
    }
}