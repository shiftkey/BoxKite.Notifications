namespace BoxKite.Notifications.Templates
{
    /// <summary>
    /// A wide tile template that displays five images - one main image,
    /// and four square images in a grid, then transitions to show two
    /// text fields.
    /// </summary>
    public interface ITileWidePeekImageCollection01 : ITileWideImageCollection
    {
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