namespace BoxKite.Notifications.Templates
{
    /// <summary>
    /// A toast template that displays an image and a text field.
    /// </summary>
    public interface IToastImageAndText01 : IToastNotificationContent
    {
        /// <summary>
        /// The main image on the toast.
        /// </summary>
        INotificationContentImage Image { get; }

        /// <summary>
        /// A body text field.
        /// </summary>
        INotificationContentText TextBodyWrap { get; }
    }
}