// Learn more about F# at http://fsharp.org
//1.3
(*Дан целочисленный массив и натуральный индекс (число, меньшее
размера массива). Необходимо определить является ли элемент по
указанному индексу глобальным максимумом.*)
open System
let rec readList n =
    Console.WriteLine("Введите элементы:")
    List.init(n) (fun index->Console.ReadLine()|>Int32.Parse)

let readData = 
    Console.WriteLine("Введите количество элементов:")
    let n=System.Convert.ToInt32(System.Console.ReadLine())
    readList n

let rec writelist list=
    List.iter(fun x->printfn "%O" x) list

let prov list n =
    if List.item n list = List.max list then true else false

[<EntryPoint>]
let main argv =
    let l=readData
    Console.WriteLine("Введите индекс:")
    let n=System.Convert.ToInt32(System.Console.ReadLine())
    prov l n|>Console.WriteLine
    0 // return an integer exit code
