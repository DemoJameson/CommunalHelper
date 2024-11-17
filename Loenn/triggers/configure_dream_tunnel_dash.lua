return {
    name = "CommunalHelper/ConfigureDreamTunnelDashTrigger",
    placements = {
        {
            name = "trigger",
            data = {
                allowRedirect = false,
                allowSameDirectionRedirect = false,
                sameDirectionSpeedMultiplier = 1,
                useEntryDirection = false,
                speedConfiguration = 0,
                customSpeed = 0,
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
