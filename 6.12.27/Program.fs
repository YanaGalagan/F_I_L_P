// Learn more about F# at http://fsharp.org
//Дан целочисленный массив. Необходимо осуществить циклический сдвиг элементов массива влево на одну позицию.
open System


let Left list =
    let rec L list h count =
        if count <> 0 then
            list @ [h]
        else
        match list with
        |[] -> list
        |h::t ->
            let newCount = count + 1
            L t h newCount 
    L list 0 0
[<EntryPoint>]
let main argv =
    printfn "Введите количество элементов списка:"
    let n = System.Convert.ToInt32(System.Console.ReadLine())
    printfn "Введите элементы списка:"
    let l= Program.readList n
    Left l|>Program.writeList|>ignore
    0 // return an r exit code
