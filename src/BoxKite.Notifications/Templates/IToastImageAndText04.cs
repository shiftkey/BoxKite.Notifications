namespace BoxKite.Notifications.Templates
{
    /// <summary>
    /// A toast template that displays an image and three text fields.
    /// </summary>
    public interface IToastImageAndText04 : IToastNotificationContent
    {
        /// <summary>
        /// The main image on the toast.
        /// </summary>
        INotificationContentImage Image { get; }

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