namespace BoxKite.Notifications.Templates
{
    /// <summary>
    /// A toast template that displays three text fields.
    /// </summary>
    public interface IToastText04 : IToastNotificationContent
    {
        /// <summary>
        /// A heading text field.
        /// </summary>
        INotificationContentText TextHeading { get; }

        /// <summary>
        /// A body text field.
        /// </summary>
        INotificationContentText TextBody1 { get; }

        /// <summary>
        /// A body text field.
        /// </summary>
        INotificationContentText TextBody2 { get; }
    }
}