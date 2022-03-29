// Learn more about F# at http://fsharp.org
(*1.43
Дан целочисленный массив. Необходимо найти количество
минимальных элементов.*)
open System

[<EntryPoint>]
let main argv =
    let l=Program.readData
    let min=List.min l
    let newL=List.filter (fun x->x=min) l
    System.Console.WriteLine(List.length newL)
    0 // return an integer exit code
