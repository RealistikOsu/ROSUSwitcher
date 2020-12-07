namespace AkemiSwitcher
{
    class BuildInfo
    {
        public static string ServerName          = "RealistikOsu";
#if FALLBACK
        public static string StaticServerIP      = "95.179.225.194";
#endif
#if ONLINE_SERVERS
        public static string SwitcherServerList  = "https://old.ussr.pl/static/servers.json";
#endif
    }
}
