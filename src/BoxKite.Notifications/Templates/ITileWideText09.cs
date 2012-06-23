namespace BoxKite.Notifications.Templates
{
    /// <summary>
    /// A wide tile template that displays two text fields.
    /// </summary>
    public interface ITileWideText09 : IWideTileNotificationContent
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