using Celeste.Mod.CommunalHelper.States;
using static Celeste.Mod.CommunalHelper.States.Elytra;

namespace Celeste.Mod.CommunalHelper.Triggers;

[CustomEntity("CommunalHelper/ConfigureElytraTrigger")]
public class ConfigureElytraTrigger : Trigger
{
    // elytra state
    private readonly bool allow, infinite;

    // elytra options
    private readonly bool disableElytraReverseVerticalMomentum;

    public ConfigureElytraTrigger(EntityData data, Vector2 offset)
        : base(data, offset)
    {
        allow = data.Bool("allow", false);
        infinite = data.Bool("infinite", false);

        disableElytraReverseVerticalMomentum = data.Bool("disableElytraReverseVerticalMomentum");
    }

    public override void OnEnter(Player player)
    {
        CommunalHelperModule.Session.CanDeployElytra = allow;
        player.SetInfiniteElytra(infinite);

        player.SetElytraConfiguration(new ElytraConfiguration()
        {
            disableElytraReverseVerticalMomentum = disableElytraReverseVerticalMomentum,
        });
    }
}
