namespace BoxKite.Notifications.Templates
{
    /// <summary>
    /// A wide tile template that displays ten text fields - two columns
    /// of five text fields.
    /// </summary>
    public interface ITileWideText11 : IWideTileNotificationContent
    {
        /// <summary>
        /// A text field displayed in a column and row.
        /// </summary>
        INotificationContentText TextPrefixColumn1Row1 { get; }

        /// <summary>
        /// A text field displayed in a column and row.
        /// </summary>
        INotificationContentText TextColumn2Row1 { get; }

        /// <summary>
        /// A text field displayed in a column and row.
        /// </summary>
        INotificationContentText TextPrefixColumn1Row2 { get; }

        /// <summary>
        /// A text field displayed in a column and row.
        /// </summary>
        INotificationContentText TextColumn2Row2 { get; }

        /// <summary>
        /// A text field displayed in a column and row.
        /// </summary>
        INotificationContentText TextPrefixColumn1Row3 { get; }

        /// <summary>
        /// A text field displayed in a column and row.
        /// </summary>
        INotificationContentText TextColumn2Row3 { get; }

        /// <summary>
        /// A text field displayed in a column and row.
        /// </summary>
        INotificationContentText TextPrefixColumn1Row4 { get; }

        /// <summary>
        /// A text field displayed in a column and row.
        /// </summary>
        INotificationContentText TextColumn2Row4 { get; }

        /// <summary>
        /// A text field displayed in a column and row.
        /// </summary>
        INotificationContentText TextPrefixColumn1Row5 { get; }

        /// <summary>
        /// A text field displayed in a column and row.
        /// </summary>
        INotificationContentText TextColumn2Row5 { get; }
    }
}