open canopy

open runner

start firefox

let reset _ =
    let seed = new Oak.Controllers.SeedController()
    seed.PurgeDb() |> ignore
    seed.All() |> ignore
    () 

before(reset)

test(fun _ ->
    describe "hello world"
    url "http://localhost:3000/"
)

run()

quit()