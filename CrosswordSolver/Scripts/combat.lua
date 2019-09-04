total_time = 0;

players = {}

function start()
    total_time = 0
end

function draw()

end

function update(dt)
    total_time = total_time + dt

    if(Input.iskeydown(Keys.ONE)) then
        ability = players[0].abilities[0]
        if player.ability.canuse() then
            player.ability.use()
        end
    end
end