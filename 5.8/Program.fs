// Learn more about F# at http://fsharp.org

open System

let rec f7 n f init = 
    if n = 0 then init
    else 
        let cifr = n % 10
        let n1 = n / 10
        let acc = f init cifr
        f7 n1 f acc

[<EntryPoint>]
let main argv =
    let a=System.Convert.ToInt32(Console.ReadLine())
    System.Console.WriteLine(f7 a (fun x y -> x + y) 0)
    System.Console.WriteLine(f7 a (fun x y -> x * y) 1)
    System.Console.WriteLine(f7 a (fun x y -> if x > y then x else y) 0)
    System.Console.WriteLine(f7 a (fun x y -> if x < y then x else y) 10)
    0 // return an integer exit code
