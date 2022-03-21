// Learn more about F# at http://fsharp.org
//Дан целочисленный массив. Необходимо осуществить
//циклический сдвиг элементов массива влево на одну позицию.
open System
let  izmenenie list=
     match list with
     |[]->list
     |h::t -> t@[h]
[<EntryPoint>]

let main argv =
    printfn "Введите количество элементов списка:"
    let n = System.Convert.ToInt32(System.Console.ReadLine())
    printfn "Введите элементы списка:"
    Program.readList n|>izmenenie|>Program.writeList|>ignore
    0 // return an integer exit code
