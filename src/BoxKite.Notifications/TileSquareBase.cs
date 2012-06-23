using System;
using System.Text;
using ISquareTileInternal = BoxKite.Notifications.ISquareTileInternal;

namespace BoxKite.Notifications
{
    internal class TileSquareBase : TileNotificationBase, ISquareTileInternal
    {
        public TileSquareBase(string templateName, int imageCount, int textCount)
            : base(templateName, imageCount, textCount)
        {
        }

        public override string GetContent()
        {
            StringBuilder builder = new StringBuilder(String.Empty);
            builder.AppendFormat("<tile><visual version='{0}'", Util.NOTIFICATION_CONTENT_VERSION);
            if (!String.IsNullOrWhiteSpace(Lang))
            {
                builder.AppendFormat(" lang='{0}'", Util.HttpEncode(Lang));
            }
            if (Branding != TileBranding.Logo)
            {
                builder.AppendFormat(" branding='{0}'", Branding.ToString().ToLowerInvariant());
            }
            if (!String.IsNullOrWhiteSpace(BaseUri))
            {
                builder.AppendFormat(" baseUri='{0}'", Util.HttpEncode(BaseUri));
            }
            builder.Append(">");
            builder.Append(SerializeBinding(Lang, BaseUri, Branding));
            builder.Append("</visual></tile>");
            return builder.ToString();
        }

        public string SerializeBinding(string globalLang, string globalBaseUri, TileBranding globalBranding)
        {
            StringBuilder bindingNode = new StringBuilder(String.Empty);
            bindingNode.AppendFormat("<binding template='{0}'", TemplateName);
            if (!String.IsNullOrWhiteSpace(Lang) && !Lang.Equals(globalLang))
            {
                bindingNode.AppendFormat(" lang='{0}'", Util.HttpEncode(Lang));
                globalLang = Lang;
            }
            if (Branding != TileBranding.Logo && Branding != globalBranding)
            {
                bindingNode.AppendFormat(" branding='{0}'", Branding.ToString().ToLowerInvariant());
            }
            if (!String.IsNullOrWhiteSpace(BaseUri) && !BaseUri.Equals(globalBaseUri))
            {
                bindingNode.AppendFormat(" baseUri='{0}'", Util.HttpEncode(BaseUri));
                globalBaseUri = BaseUri;
            }
            bindingNode.AppendFormat(">{0}</binding>", SerializeProperties(globalLang, globalBaseUri));

            return bindingNode.ToString();
        }
    }
}