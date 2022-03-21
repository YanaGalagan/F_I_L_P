// Learn more about F# at http://fsharp.org
//Дан целочисленный массив и натуральный индекс (число, меньшее размера массива). Необходимо определить является ли элемент по
//указанному индексу глобальным максимумом.
open System
let glob list =
    let rec g list max= 
        match list with
        |[]->max
        |h::t-> 
               let newMax=if h>max then h else max
               let newList=t
               g newList newMax
    g list list.Head

let Poisk list n max=
    let rec p list n init=
        match list with
        |[]-> init
        |h::t ->
           if n<>1 then 
             let newList= t
             let newn=n-1
             p newList newn init
              else 
                   if h = max then init=true 
                   else init=false
    p list n true

[<EntryPoint>]
let main argv =
    printfn "Введите количество элементов списка:"
    let n = System.Convert.ToInt32(System.Console.ReadLine())
    printfn "Введите индекс:"
    let k = System.Convert.ToInt32(System.Console.ReadLine())
    printfn "Введите элементы списка:"
    let l=Program.readList n
    let max=glob l
    System.Console.WriteLine(Poisk l k max)
    0 // return an integer exit code
