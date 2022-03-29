// Learn more about F# at http://fsharp.org
(*1.13
Дан целочисленный массив. Необходимо разместить элементы,
расположенные до минимального, в конце массива.*)
open System

[<EntryPoint>]
let main argv =
    let l=Program.readData
    let m=List.min l
    let ind= List.findIndex (fun x -> x=m) l
    let index=List.indexed l
    let List1=l.[0..(ind-1)]
    let List2=l.[ind..List.length l]
    Program.writelist(List2@List1)
    0 // return an integer exit code
