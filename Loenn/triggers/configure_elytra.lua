return {
    name = "CommunalHelper/ConfigureElytraTrigger",
    ignoredFields = {
        "_name", "_id", "_type", "infinite"
    },
    placements = {
        {
            name = "yes",
            data = {
                allow = true,
                infinite = false,
                disableElytraReverseVerticalMomentum = false,
            }
        },
        {
            name = "yes_infinite",
            data = {
                allow = true,
                infinite = true,
                disableElytraReverseVerticalMomentum = false,
            }
        },
        {
            name = "no",
            data = {
                allow = false,
                infinite = false,
                disableElytraReverseVerticalMomentum = false,
            }
        }
    }
}
