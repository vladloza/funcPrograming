open System

let monets = [|1.0; 2.0; 5.0;|]

let rec lab2Func (m:float) (index:int) =
    if m < 0.0 || index < 0 then 0
    elif m = 0.0 || index = 0 then 1
    else lab2Func m (index - 1) + lab2Func (m - monets.[index]) index

let getLab2Result (m:float) = 
    lab2Func m 2

[<EntryPoint>]
let main argv =
    Console.WriteLine(getLab2Result 4.0)
    0
