namespace BoxKite.Notifications.Templates
{
    /// <summary>
    /// A square tile template that displays a text field.
    /// </summary>
    public interface ITileSquareText04 : ISquareTileNotificationContent
    {
        /// <summary>
        /// A body text field.
        /// </summary>
        INotificationContentText TextBodyWrap { get; }
    }
}