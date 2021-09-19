using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static ExternalTestingUtility.Cheats.BlackOps3.Constants;
using static System.ExCallThreadType;

namespace ExternalTestingUtility.Cheats
{
    internal static class BlackOps3
    {
        internal static class Constants
        {
            public const ulong OFF_CBUF_ADDTEXT = 0x20EC8B0;
            public const ulong OFF_DVAR_SETFROMSTRINGBYNAME = 0x22C7F60;
        }


        private static ProcessEx __game;
        internal static ProcessEx Game
        {
            get
            {
                if (__game == null || __game.BaseProcess.HasExited)
                {
                    __game = "blackops3";
                    if (__game == null || __game.BaseProcess.HasExited)
                    {
                        throw new Exception("Black Ops 3 process not found.");
                    }
                    __game.SetDefaultCallType(XCTT_RIPHijack);
                }
                if (!__game.Handle)
                {
                    __game.OpenHandle(ProcessEx.PROCESS_ACCESS, true);
                }
                return __game;
            }
        }

        internal static void Cbuf_AddText(string serverText, int client = 0)
        {
            if (serverText == null) return;
            Game.Call<ulong>(Game[OFF_CBUF_ADDTEXT], client, serverText, 0L);
        }

        internal static void Dvar_SetFromStringByName(string dvarName, string _value, bool CreateIfMissing = true)
        {
            if (dvarName == null || _value == null) return;
            Game.Call<ulong>(Game[OFF_DVAR_SETFROMSTRINGBYNAME], dvarName, _value, CreateIfMissing);
        }
        internal static void DisableAmmo()
        {
            Dvar_SetFromStringByName("player_sustainAmmo", "0");
        }
        internal static void InfiniteAmmo()
        {
            Dvar_SetFromStringByName("player_sustainAmmo", "1");
        }
        internal static void ApplyHostDvars()
        {
            Dvar_SetFromStringByName("party_minPlayers", "1");
            Dvar_SetFromStringByName("lobbyDedicatedSearchSkip", "1");
            Dvar_SetFromStringByName("lobbySearchTeamSize", "1");
            Dvar_SetFromStringByName("lobbySearchSkip", "1");
            Dvar_SetFromStringByName("lobbyMergeDedicatedEnabled", "0");
            Dvar_SetFromStringByName("lobbyMergeEnabled", "0");
        }

        #region 
        #endregion
    }
}
