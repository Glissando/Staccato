
function main()
    debug.log("Hello, world!")
    loader.loadScript("game","game")
    state.add("game","game")
    state.start("game")
    
end