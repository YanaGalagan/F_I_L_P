// Learn more about F# at http://fsharp.org
(*1.33
Дан целочисленный массив. Проверить, чередуются ли в нем
положительные и отрицательные числа.*)
open System

let prov list=
    let rec p list =
        if List.length list >2 then 
          if (List.item 0 list)*(List.item 1 list)<0 then true else false
          p list.[1..List.length list]
        else if (List.item 0 list)*(List.item 1 list)<0 then true else false
    p list 

[<EntryPoint>]
let main argv =
    Program.readData|>prov|>Console.WriteLine
    0 // return an integer exit code
