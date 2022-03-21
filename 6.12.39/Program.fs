// Learn more about F# at http://fsharp.org
//Дан целочисленный массив. Необходимо вывести вначале его
//элементы с четными индексами, а затем - с нечетными.
open System

let chet list n predicate=
    let rec ch list n=
        match list with
        |[]-> 0
        |(h:int)::t->
           if predicate n then 
             System.Console.WriteLine(h) 
             let newN=n-1
             let newList=t
             ch newList newN
           else 
             let newN=n-1
             let newList=t
             ch newList newN
    ch list n     
 
[<EntryPoint>]
let main argv =
    printfn "Введите количество элементов списка:"
    let n = System.Convert.ToInt32(System.Console.ReadLine())
    printfn "Введите элементы списка:"
    let l=Program.readList n
    System.Console.WriteLine("")
    chet l n (fun x -> if x%2=0 then true else false)
    chet l n (fun x -> if x%2=1 then true else false)
    0 // return an integer exit code
