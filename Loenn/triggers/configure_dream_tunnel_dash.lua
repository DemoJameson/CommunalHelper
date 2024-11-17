return {
    name = "CommunalHelper/ConfigureDreamTunnelDashTrigger",
    placements = {
        {
            name = "configureDreamTunnelDash",
            data = {
                allowRedirect = false,
                allowSameDirRedirect = false,
                sameDirectionSpeedMultiplier = 1,
                useEntryDir = false,
                speedConfiguration = 0,
                customSpeed = 0,
                allowDashCancels = false,
            }
        }
    },
    fieldInformation = {
        speedConfiguration = {
            options = {
                ["Default"] = 0,
                ["Never Slow Down"] = 1,
                ["Use Custom Speed"] = 2,
            },
            editable = false,
        }
    }
}
