
function main()
    Debug.log("Hello, world!")
    Loader.loadScript("game","game")
    State.add("game","game")
    State.start("game")
    
end