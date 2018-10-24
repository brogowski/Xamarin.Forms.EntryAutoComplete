using EntryAutoComplete.iOS.Renderers;

namespace EntryAutoComplete.iOS
{
    public static class Config
    {
        public static void Init()
        {
            new ShadowedFrameRenderer();
            new BorderlessEntryRenderer();
        }
    }
}