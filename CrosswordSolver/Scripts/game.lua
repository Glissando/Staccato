
elapsed_time = 0

function start()
    Time.add(printMessage,5)
    
end

function draw()
    
end

function update(dt)

end

function printMessage()
    print("5 seconds has passed!")
    Time.add(printMessage, 5)
end

function shutdown()

end