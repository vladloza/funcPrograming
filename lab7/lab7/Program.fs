// Learn more about F# at http://fsharp.org

open System
open System.Collections.Generic

let memoize f =
    let dict = new System.Collections.Generic.Dictionary<_,_>()
    fun n ->
        match dict.TryGetValue(n) with
        | (true, v) -> v
        | _ ->
            let temp = f(n)
            dict.Add(n, temp)
            Console.WriteLine("add to dict: " + temp.ToString())
            temp

let rec fib = memoize(fun n ->
    if n = 0 then 0
    elif n = 1 then 1
    else fib (n - 1) + fib (n - 2))

[<EntryPoint>]
let main argv =
    fib 20

    0
