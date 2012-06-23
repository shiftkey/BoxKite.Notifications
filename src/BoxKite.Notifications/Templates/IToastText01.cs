namespace BoxKite.Notifications.Templates
{
    /// <summary>
    /// A toast template that displays a text fields.
    /// </summary>
    public interface IToastText01 : IToastNotificationContent
    {
        /// <summary>
        /// A body text field.
        /// </summary>
        INotificationContentText TextBodyWrap { get; }
    }
}