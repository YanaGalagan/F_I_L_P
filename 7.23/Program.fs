// Learn more about F# at http://fsharp.org
(*1.23
Дан целочисленный массив. Необходимо найти два наименьших
элемента.*)
open System

[<EntryPoint>]
let main argv =
    let l=Program.readData
    let min=List.min l
    Console.WriteLine(" ")
    Console.WriteLine(min)
    Console.WriteLine(" ")
    let newl=List.filter (fun x -> x<>min) l
    Console.WriteLine(List.min newl)
    0 // return an integer exit code
