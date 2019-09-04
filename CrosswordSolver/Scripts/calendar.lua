--Calendar object meant to be used to track the game's date and call events at specific times & dates.
function Calendar:new(o)
    o = o or {}
    o.minute = 0
    o.hour = 0
    o.day = 0
    o.month = 1
    o.year = 0
    o.events = {}
    setmetatable(o,mt)
    return o
end

mt = {
    update = function(dt)
        o.minute = o.minute + dt

        if o.minute >= 60 then
            o.minute = o.minute % 60
            o.hour = o.hour + 1
        end

        if o.hour == 24 then 
            o.hour = 0
            o.day = o.day + 1
        end

        if o.day == 31 then
            o.day = 0
            o.month = o.month + 1
        end

        if o.month == 13 then
            o.month = 1
            o.yeaer = o.year + 1
        end

        id = CalenderEvent.new(minute, hour, day, month, year).__tostring()

        if events[id] then
            events[id].onDate.Invoke()
        end
    end,    

    onDate = function(minute, hour, day, month, year, func)
        o = CalenderEvent.new(minute,hour,day,month,year)
        events[o.__tostring] = o
    end
}


function CalenderEvent:new(minute,hour,day,month,year, func)
    o = {}
    o.minute = 0
    o.hour = 0
    o.day = 0
    o.month = 1
    o.year = 0
    o.OnDate = game.add.Signal(func)
end

emt = {
    __tostring = function()
    
    end
}