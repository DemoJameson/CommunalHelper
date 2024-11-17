using Celeste.Mod.CommunalHelper.DashStates;
using static Celeste.Mod.CommunalHelper.DashStates.DreamTunnelDash;

namespace Celeste.Mod.CommunalHelper.Triggers;

[CustomEntity("CommunalHelper/ConfigureDreamTunnelDashTrigger")]
public class ConfigureDreamTunnelDashTrigger : Trigger
{
    private readonly DreamTunnelDashConfiguration options;

    public ConfigureDreamTunnelDashTrigger(EntityData data, Vector2 offset)
        : base(data, offset)
    {
        options = new DreamTunnelDashConfiguration()
        {
            allowRedirect = data.Bool("allowRedirect", false),
            allowSameDirectionRedirect = data.Bool("allowSameDirectionRedirect", false),
            sameDirectionSpeedMultiplier = data.Float("sameDirectionSpeedMultiplier", 1f),
            useEntryDirection = data.Bool("useEntryDirection", false),
            speedConfiguration = (SpeedConfiguration) data.Int("speedConfiguration", 0),
            customSpeed = data.Float("customSpeed", 0f),
        };
    }

    public override void OnEnter(Player player)
    {
        CommunalHelperModule.Session.CurrentDreamTunnelDashConfiguration = options;
    }
}
