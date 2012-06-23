namespace BoxKite.Notifications.Templates
{
    /// <summary>
    /// A toast template that displays two text fields.
    /// </summary>
    public interface IToastText03 : IToastNotificationContent
    {
        /// <summary>
        /// A heading text field.
        /// </summary>
        INotificationContentText TextHeadingWrap { get; }

        /// <summary>
        /// A body text field.
        /// </summary>
        INotificationContentText TextBody { get; }
    }
}