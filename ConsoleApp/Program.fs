
open System
open OrderLibrary

[<EntryPoint>]
let main argv =
    1200.0
    |> OrderService.getPrice
    |> printfn "%f"

    800.0
    |> OrderService.getPrice
    |> printfn "%f"
    
    0 // return an integer exit code
