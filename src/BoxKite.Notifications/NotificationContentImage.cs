namespace BoxKite.Notifications
{
    internal sealed class NotificationContentImage : INotificationContentImage
    {
        public string Src
        {
            get { return m_Src; }
            set { m_Src = value; }
        }

        public string Alt
        {
            get { return m_Alt; }
            set { m_Alt = value; }
        }

        public bool AddImageQuery
        {
            get
            {
                if (m_AddImageQueryNullable == null || m_AddImageQueryNullable.Value == false)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            set { m_AddImageQueryNullable = value; }
        }

        public bool? AddImageQueryNullable
        {
            get { return m_AddImageQueryNullable; }
            set { m_AddImageQueryNullable = value; }
        }

        private string m_Src;
        private string m_Alt;
        private bool? m_AddImageQueryNullable;
    }
}