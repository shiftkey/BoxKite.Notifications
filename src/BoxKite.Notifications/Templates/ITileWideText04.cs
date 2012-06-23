namespace BoxKite.Notifications.Templates
{
    /// <summary>
    /// A wide tile template that displays a text field.
    /// </summary>
    public interface ITileWideText04 : IWideTileNotificationContent
    {
        /// <summary>
        /// A body text field.
        /// </summary>
        INotificationContentText TextBodyWrap { get; }
    }
}