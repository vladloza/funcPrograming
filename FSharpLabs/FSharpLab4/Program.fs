open System
open System.Linq

let matrix = [
              [ 1.0; 7.0; 2.0 ];
              [ 1.0; 3.0; 5.0 ];
              [ 2.0; 9.0; 1.0 ];
             ]

let rec getMatrixDiagonals length i =
    if i < length then
        Console.Write(matrix.[i].[i].ToString() + " ")
        getMatrixDiagonals length (i+1)

[<EntryPoint>]
let main argv =
    getMatrixDiagonals matrix.Length 0
    0