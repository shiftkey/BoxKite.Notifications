namespace BoxKite.Notifications
{
    /// <summary>
    /// A wide tile template that displays five images - one main image,
    /// and four square images in a grid.
    /// </summary>
    public interface ITileWideImageCollection : IWideTileNotificationContent
    {
        /// <summary>
        /// The main image on the tile.
        /// </summary>
        INotificationContentImage ImageMain { get; }

        /// <summary>
        /// A small square image on the tile.
        /// </summary>
        INotificationContentImage ImageSmallColumn1Row1 { get; }

        /// <summary>
        /// A small square image on the tile.
        /// </summary>
        INotificationContentImage ImageSmallColumn2Row1 { get; }

        /// <summary>
        /// A small square image on the tile.
        /// </summary>
        INotificationContentImage ImageSmallColumn1Row2 { get; }

        /// <summary>
        /// A small square image on the tile.
        /// </summary>
        INotificationContentImage ImageSmallColumn2Row2 { get; }
    }
}