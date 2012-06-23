namespace BoxKite.Notifications.Templates
{
    /// <summary>
    /// A wide tile template that displays five images - one main image,
    /// and four square images in a grid, then transitions to show an image
    /// and a text field.
    /// </summary>
    public interface ITileWidePeekImageCollection06 : ITileWideImageCollection
    {
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