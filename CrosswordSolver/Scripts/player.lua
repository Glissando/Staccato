--Holds the player object utilized in the game and combat states
player = {
    name = "player",
    x = 0,
    y = 0,
    intelligence = 5,
    wisdom = 5,
    strength = 5,
    dexterity = 5,
    charisma = 5,
    stamina = 5,
    atb = 0,
    onAttack = {},
    onDeath = {}

}

function player:update(dt)
    atb = atb + dt * dexterity
end