open canopy
open canopy.types
open runner

start firefox

let reset _ =
    let seed = new Oak.Controllers.SeedController()
    seed.PurgeDb() |> ignore
    seed.All() |> ignore
    () 

context("first test")

//before(reset)

test(fun _ ->
    describe "hello world"
    url "http://google.com/"
)

run()