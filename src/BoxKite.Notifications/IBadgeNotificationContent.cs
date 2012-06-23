using Windows.UI.Notifications;

namespace BoxKite.Notifications
{
    /// <summary>
    /// Base badge notification content interface.
    /// </summary>
    public interface IBadgeNotificationContent : INotificationContent
    {
#if !WINRT_NOT_PRESENT
        /// <summary>
        /// Creates a WinRT BadgeNotification object based on the content.
        /// </summary>
        /// <returns>A WinRT BadgeNotification object based on the content.</returns>
        BadgeNotification CreateNotification();
#endif
    }
}