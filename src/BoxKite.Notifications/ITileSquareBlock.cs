namespace BoxKite.Notifications
{
    /// <summary>
    /// A square tile template that displays two text captions.
    /// </summary>
    public interface ITileSquareBlock : ISquareTileNotificationContent
    {
        /// <summary>
        /// A large block text field.
        /// </summary>
        INotificationContentText TextBlock { get; }

        /// <summary>
        /// The description under the large block text field.
        /// </summary>
        INotificationContentText TextSubBlock { get; }
    }
}