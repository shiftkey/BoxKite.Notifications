using System;

namespace BoxKite.Notifications.Templates
{
    internal sealed class ToastAudio : IToastAudio
    {
        public ToastAudioContent Content
        {
            get { return m_Content; }
            set
            {
                if (!Enum.IsDefined(typeof(ToastAudioContent), value))
                {
                    throw new ArgumentOutOfRangeException("value");
                }
                m_Content = value;
            }
        }

        public bool Loop { get; set; }

        private ToastAudioContent m_Content = ToastAudioContent.Default;

        public ToastAudio()
        {
            Loop = false;
        }
    }
}