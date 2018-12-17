open System

let labFunc (A:float) (B:float) (C:float) = 
    (1.0 - B) / (1.0 + B)+ abs((C - 2.0 * A) / C ** 2.0)

[<EntryPoint>]
let main argv =
    Console.WriteLine(labFunc 1.0 2.0 3.0)
    0