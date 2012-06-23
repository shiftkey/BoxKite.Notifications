namespace BoxKite.Notifications
{
    /// <summary>
    /// A square tile template that displays an image.
    /// </summary>
    public interface ITileSquareImage : ISquareTileNotificationContent
    {
        /// <summary>
        /// The main image on the tile.
        /// </summary>
        INotificationContentImage Image { get; }
    }
}