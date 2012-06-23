using System;
using Windows.Data.Xml.Dom;
using Windows.UI.Notifications;

namespace BoxKite.Notifications
{
    internal abstract class TileNotificationBase : NotificationBase
    {
        protected TileNotificationBase(string templateName, int imageCount, int textCount)
            : base(templateName, imageCount, textCount)
        {
        }

        private TileBranding branding = TileBranding.Logo;
        public TileBranding Branding
        {
            get { return branding; }
            set
            {
                if (!Enum.IsDefined(typeof(TileBranding), value))
                {
                    throw new ArgumentOutOfRangeException("value");
                }
                branding = value;
            }
        }

        public TileNotification CreateNotification()
        {
            var xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(GetContent());
            return new TileNotification(xmlDoc);
        }
    }
}