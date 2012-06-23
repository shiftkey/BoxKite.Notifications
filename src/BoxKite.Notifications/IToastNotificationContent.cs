using Windows.UI.Notifications;

namespace BoxKite.Notifications
{
    /// <summary>
    /// Base toast notification content interface.
    /// </summary>
    public interface IToastNotificationContent : INotificationContent
    {
        /// <summary>
        /// Whether strict validation should be applied when the Xml or notification object is created,
        /// and when some of the properties are assigned.
        /// </summary>
        bool StrictValidation { get; set; }

        /// <summary>
        /// The language of the content being displayed.  The language should be specified using the
        /// abbreviated language code as defined by BCP 47.
        /// </summary>
        string Lang { get; set; }

        /// <summary>
        /// The BaseUri that should be used for image locations.  Relative image locations use this
        /// field as their base Uri.  The BaseUri must begin with http://, https://, ms-appx:///, or 
        /// ms-appdata:///local/.
        /// </summary>
        string BaseUri { get; set; }

        /// <summary>
        /// The launch parameter passed into the metro application when the toast is activated.
        /// </summary>
        string Launch { get; set; }

        /// <summary>
        /// The audio that should be played when the toast is displayed.
        /// </summary>
        IToastAudio Audio { get; }

        /// <summary>
        /// The length that the toast should be displayed on screen.
        /// </summary>
        ToastDuration Duration { get; set; }

#if !WINRT_NOT_PRESENT
        /// <summary>
        /// Creates a WinRT ToastNotification object based on the content.
        /// </summary>
        /// <returns>A WinRT ToastNotification object based on the content.</returns>
        ToastNotification CreateNotification();
#endif
    }
}