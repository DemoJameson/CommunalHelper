using Celeste.Mod.CommunalHelper.DashStates;
using Monocle;
using MonoMod.ModInterop;
using System;

namespace Celeste.Mod.CommunalHelper {

    public static class ModExports {

        internal static void Initialize() {
            typeof(DashStates).ModInterop();
        }

        [ModExportName("CommunalHelper.DashStates")]
        public static class DashStates {

            #region DreamTunnel

            public static int GetDreamTunnelDashState() => DreamTunnelDash.StDreamTunnelDash;
            public static bool HasDreamTunnelDash() => DreamTunnelDash.HasDreamTunnelDash;

            public static Component DreamTunnelInteraction(Action<Player> onPlayerEnter, Action<Player> onPlayerExit)
                => new DreamTunnelInteraction(onPlayerEnter, onPlayerExit);

            #endregion

            #region Seeker

            public static bool HasSeekerDash() => SeekerDash.HasSeekerDash;
            public static bool IsSeekerDashAttacking() => SeekerDash.SeekerAttacking;

            #endregion

        }

    }
}