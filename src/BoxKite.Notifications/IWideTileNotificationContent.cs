namespace BoxKite.Notifications
{
    /// <summary>
    /// Base wide tile notification content interface.
    /// </summary>
    public interface IWideTileNotificationContent : ITileNotificationContent
    {
        /// <summary>
        /// Corresponding square tile notification content should be a part of every wide tile notification.
        /// </summary>
        ISquareTileNotificationContent SquareContent { get; set; }

        /// <summary>
        /// Whether square tile notification content needs to be added to pass
        /// validation.  Square content is required by default.
        /// </summary>
        bool RequireSquareContent { get; set; }
    }
}