namespace BoxKite.Notifications
{
    internal interface ISquareTileInternal
    {
        string SerializeBinding(string globalLang, string globalBaseUri, TileBranding globalBranding, bool globalAddImageQuery);
    }
}