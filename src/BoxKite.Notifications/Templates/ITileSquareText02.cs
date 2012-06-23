namespace BoxKite.Notifications.Templates
{
    /// <summary>
    /// A square tile template that displays two text fields.
    /// </summary>
    public interface ITileSquareText02 : ISquareTileNotificationContent
    {
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