namespace WAIATime
{
    public class WAIATime : WAIA_Plugin.IWAIAPlugin
    {
        public string RunPlugin(string text, string[] parameter)
        {
            String language = parameter[0];
            return "translate the following text to " + language + " language. Die Zeit ist " + DateTime.Now.Hour + " uhr und" + DateTime.Now.Minute+" minuten. don't say that you are translating.";
        }
    }
}
