namespace AkemiSwitcher
{
    class BuildInfo
    {
        public static string ServerName          = "RealistikOsu";
#if FALLBACK
        public static string StaticServerIP      = "173.249.42.180";
#endif
#if ONLINE_SERVERS
        public static string SwitcherServerList  = "https://old.ussr.pl/static/servers.json";
#endif
    }
}
