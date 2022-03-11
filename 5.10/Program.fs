// Learn more about F# at http://fsharp.org

open System

let rec f9 n f init predicate = 
    if n = 0 then init
    else
        let cifr = n % 10
        let n1 = n / 10
        let acc = f init cifr
        if predicate cifr then f9 n1 f acc predicate
        else f9 n1 f init predicate

[<EntryPoint>]
let main argv =
    System.Console.WriteLine(f9 15 (fun x y -> x+y) 0 (fun x -> x%2=0))
    System.Console.WriteLine(f9 225 (fun x y -> x+y) 0 (fun x -> x%2=0))
    System.Console.WriteLine(f9 19248 (fun x y -> x+y) 0 (fun x -> x%2=0))
    0 // return an integer exit code