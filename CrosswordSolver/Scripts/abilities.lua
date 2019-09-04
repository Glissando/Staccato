--TANK--
bash = {
    cost = 2,
    range = 2,
    name = "Strike",
    description = "Attacks an enemy with an attack that has a higher chance of stagger",
    use = function(player, target)
        player.atb = player.atb - atb;
        target.health = target.health - player.strength;
    end,
    canuse = function(player)
        return player.atb >= self.atb
    end
}

block = {

}

counter = {

}


--SUPPORT ABILITIES--
helping_hand = {
    cost = 1,
    range = 10,
    name = "Helping Hand",
    description = "Give one atb gauge to an ally and boost the damage of your next attack if it follows theirs.",
    use = function(player, target)
        target.damageModifier = target.damageModifier + 20
    end,
    canuse = function(player,target)
        if target.atb < 3 then
            if player.atb >= self.cost then
                return true
            end
        end
        return false
    end
}

haste = {
    cost = 2,
    range = 10,
    name = "Haste",
    description = "Increase the atb gauge recovery of an ally for a brief period.",
    use = function(player, target)
    
    end,
    canuse = function(player,target)

    end
}

slow = {
    cost = 2,
    range = 10,
    name = "Slow",
    description = "Decrease the atb gauge recovery of an enemy",
}

stop = {
    cost = 3,
    range = 10,
    name = "Stop",
    description = "Completely haults the recovery of an enemies atb, preventing further actions"
}

--Rogue--
trap = {
    cost = 2,
    range = 5,
    description = "Place a trap on an enemy, detonating on the next attack, increases stagger chance."
}

Steal = {
    cost = 1,
    range = 1,
    description = "Take an item from an enemy, has a chance to give an ATB gauge."
}

dodge = {

}

--Healing--
give = {

}

heal = {
    
}