using Celeste.Mod.CommunalHelper.Entities;
using Celeste.Mod.CommunalHelper.States;
using System.Collections.Generic;
using static Celeste.Mod.CommunalHelper.Entities.StationBlockTrack;
using static Celeste.Mod.CommunalHelper.DashStates.DreamTunnelDash;

namespace Celeste.Mod.CommunalHelper;

public class CommunalHelperSession : EverestModuleSession
{
    public SortedSet<string> SummitGems { get; set; }

    public TrackSwitchState TrackInitialState = TrackSwitchState.On;

    public TrackMoveMode TrackInitialMoveMode = TrackMoveMode.ForwardForce;

    public bool CassetteJumpFix = false;

    public HashSet<RedlessBerry.Info> RedlessBerries { get; set; } = new();

    public bool PlayerWasTired { get; set; } = false;

    // used by expiring dash refills
    public double ExpiringDashRemainingTime { get; set; }
    public float ExpiringDashFlashThreshold { get; set; }

    public bool CanDeployElytra { get; set; }
    public Elytra.ElytraConfiguration CurrentElytraConfiguration { get; set; } = Elytra.DefaultElytraConfiguration;

    public DreamTunnelDashConfiguration CurrentDreamTunnelDashConfiguration { get; set; } = DefaultDreamTunnelDashConfiguration;

    internal float PrevGasTimer { get; set; }
    public float GasTimer { get; set; }

    // This breaks with PlayerVisualModifier as the object type, so I'm going to use this with knownModifiers everywhere.
    public string VisualAddition { get; set; }
    public bool OshiroBsideTimer { get; set; } = false;

    public CommunalHelperSession()
    {
        SummitGems = new SortedSet<string>(StringComparer.InvariantCulture);
    }
}

