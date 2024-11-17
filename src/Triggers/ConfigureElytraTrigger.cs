using Celeste.Mod.CommunalHelper.States;
using static Celeste.Mod.CommunalHelper.States.Elytra;

namespace Celeste.Mod.CommunalHelper.Triggers;

[CustomEntity("CommunalHelper/ConfigureElytraTrigger")]
public class ConfigureElytraTrigger : Trigger
{
    private readonly bool allow, infinite;

    private readonly ElytraConfiguration options;

    public ConfigureElytraTrigger(EntityData data, Vector2 offset)
        : base(data, offset)
    {
        allow = data.Bool("allow", false);
        infinite = data.Bool("infinite", false);

        options = new ElytraConfiguration()
        {
            disableElytraReverseVerticalMomentum = data.Bool("disableElytraReverseVerticalMomentum"),
        };
    }

    public override void OnEnter(Player player)
    {
        CommunalHelperModule.Session.CanDeployElytra = allow;
        player.SetInfiniteElytra(infinite);
        player.SetElytraConfiguration(options);
    }
}
