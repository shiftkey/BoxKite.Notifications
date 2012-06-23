namespace BoxKite.Notifications
{
    /// <summary>
    /// A type contained by the tile and toast notification content objects that
    /// represents an image in a template.
    /// </summary>
    public interface INotificationContentImage
    {
        /// <summary>
        /// The location of the image.  Relative image paths use the BaseUri provided in the containing
        /// notification object.  If no BaseUri is provided, paths are relative to ms-appx:///.
        /// Only png and jpg images are supported.  Images must be 800x800 pixels or less, and smaller than
        /// 150 kB in size.
        /// </summary>
        string Src { get; set; }

        /// <summary>
        /// Alt text that describes the image.
        /// </summary>
        string Alt { get; set; }
    }
}