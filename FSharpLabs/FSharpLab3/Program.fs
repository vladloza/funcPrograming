open System

let p = 0.001

let hordFunc x = 
    cos x - x

let func (x:float) =
    cos x

let rec loop (n:float) (b:float) =
    Console.WriteLine(n - func n)
    if n < b then
        if abs(n - func n) > p then
            loop (n + 0.001) b
        else n
    else nan

let rec hordLoop (prev:float) (curr:float) (next:float) =
    let newA:float = curr - hordFunc(curr) * (prev - curr) / (hordFunc(prev) - hordFunc(curr));
    Console.WriteLine(newA - next)
    if abs(newA - next) > p then
        hordLoop curr next newA
    else newA

let getByHord a b =
    hordLoop a b 0.0

[<EntryPoint>]
let main argv =
    Console.WriteLine("Iterations: ")
    Console.WriteLine("\nResult: " + (loop 0.0 10.0).ToString() + "\n")
    Console.WriteLine("Hords: ")
    Console.WriteLine("\nResult: " + (getByHord -1.0 10.0).ToString())
    0
