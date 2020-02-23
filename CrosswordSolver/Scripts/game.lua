
elapsed_time = 0

function start()
    time.add(printMessage,5)
    
end

function draw()
    
end

function update(dt)

end

function printMessage()
    print("5 seconds has passed!")
    time.add(printMessage, 5)
end

function shutdown()

end