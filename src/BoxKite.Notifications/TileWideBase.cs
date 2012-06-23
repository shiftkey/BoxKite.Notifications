using System;
using System.Text;

namespace BoxKite.Notifications
{
    internal class TileWideBase : TileNotificationBase
    {
        public TileWideBase(string templateName, int imageCount, int textCount)
            : base(templateName, imageCount, textCount)
        {
        }

        public ISquareTileNotificationContent SquareContent
        {
            get { return m_SquareContent; }
            set { m_SquareContent = value; }
        }

        public bool RequireSquareContent
        {
            get { return m_RequireSquareContent; }
            set { m_RequireSquareContent = value; }
        }

        public override string GetContent()
        {
            if (RequireSquareContent && SquareContent == null)
            {
                throw new NotificationContentValidationException(
                    "Square tile content should be included with each wide tile. " +
                    "If this behavior is undesired, use the RequireSquareContent property.");
            }

            StringBuilder visualNode = new StringBuilder(String.Empty);
            visualNode.AppendFormat("<visual version='{0}'", Util.NOTIFICATION_CONTENT_VERSION);
            if (!String.IsNullOrWhiteSpace(Lang))
            {
                visualNode.AppendFormat(" lang='{0}'", Util.HttpEncode(Lang));
            }
            if (Branding != TileBranding.Logo)
            {
                visualNode.AppendFormat(" branding='{0}'", Branding.ToString().ToLowerInvariant());
            }
            if (!String.IsNullOrWhiteSpace(BaseUri))
            {
                visualNode.AppendFormat(" baseUri='{0}'", Util.HttpEncode(BaseUri));
            }
            visualNode.Append(">");

            StringBuilder builder = new StringBuilder(String.Empty);
            builder.AppendFormat("<tile>{0}<binding template='{1}'>{2}</binding>", visualNode, TemplateName, SerializeProperties(Lang, BaseUri));
            if (SquareContent != null)
            {
                ISquareTileInternal squareBase = SquareContent as ISquareTileInternal;
                if (squareBase == null)
                {
                    throw new NotificationContentValidationException("The provided square tile content class is unsupported.");
                }
                builder.Append(squareBase.SerializeBinding(Lang, BaseUri, Branding));
            }
            builder.Append("</visual></tile>");

            return builder.ToString();
        }

        private ISquareTileNotificationContent m_SquareContent = null;
        private bool m_RequireSquareContent = true;
    }
}