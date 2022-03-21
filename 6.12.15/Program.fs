// Learn more about F# at http://fsharp.org
//Дан целочисленный массив и натуральный индекс (число, меньшее размера массива). Необходимо определить является ли элемент по
//указанному индексу локальным минимумом.
open System

let Poisk list n=
    let rec p list n npred init=
        match list with
        |[]-> init
        |h::t ->
           if n<>1 then 
             let newList= t
             let newPred= h
             let newn=n-1
             p newList newn newPred init
              else 
                   if npred>h && h<t.Head then init=true 
                   else init=false
    p list n list.Head true

[<EntryPoint>]
let main argv =
    printfn "Введите количество элементов списка:"
    let n = System.Convert.ToInt32(System.Console.ReadLine())
    printfn "Введите индекс искомого элемента:"
    let k = System.Convert.ToInt32(System.Console.ReadLine())
    printfn "Введите элементы списка:"
    let sp= Program.readList n
    System.Console.WriteLine(Poisk sp k)
    
    0 // return an integer exit code
