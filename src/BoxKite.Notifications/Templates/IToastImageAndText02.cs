namespace BoxKite.Notifications.Templates
{
    /// <summary>
    /// A toast template that displays an image and two text fields.
    /// </summary>
    public interface IToastImageAndText02 : IToastNotificationContent
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
        INotificationContentText TextBodyWrap { get; }
    }
}