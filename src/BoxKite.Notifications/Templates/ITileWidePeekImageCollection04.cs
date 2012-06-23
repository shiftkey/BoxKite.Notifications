namespace BoxKite.Notifications.Templates
{
    /// <summary>
    /// A wide tile template that displays five images - one main image,
    /// and four square images in a grid, then transitions to show a
    /// text field.
    /// </summary>
    public interface ITileWidePeekImageCollection04 : ITileWideImageCollection
    {
        /// <summary>
        /// A body text field.
        /// </summary>
        INotificationContentText TextBodyWrap { get; }
    }
}