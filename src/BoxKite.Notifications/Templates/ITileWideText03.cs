namespace BoxKite.Notifications.Templates
{
    /// <summary>
    /// A wide tile template that displays a text field.
    /// </summary>
    public interface ITileWideText03 : IWideTileNotificationContent
    {
        /// <summary>
        /// A heading text field.
        /// </summary>
        INotificationContentText TextHeadingWrap { get; }
    }
}