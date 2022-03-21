// Learn more about F# at http://fsharp.org
//Дан целочисленный массив и интервал a..b. Необходимо найти
//сумму элементов, значение которых попадает в этот интервал.
open System
let Sum (a,b) list init= 
    let rec InInt list (a,b) sum = 
        match list with
        |[]->sum
        |h::tail-> 
            let newSum = 
                if h>a && h<b then sum+h
                else sum
            InInt tail (a,b) newSum
    InInt list (a,b) 0
[<EntryPoint>]
let main argv =
    printfn "Введите количество элементов списка:"
    let n = System.Convert.ToInt32(System.Console.ReadLine())
    printfn "Введите элементы списка:"
    let l=Program.readList n
    Console.WriteLine("Введите границы интервала")
    let interval = (Convert.ToInt32(Console.ReadLine()),Convert.ToInt32(Console.ReadLine()))
    printfn "Сумма элементов:"
    System.Console.WriteLine(Sum interval l 0)
    0 // return an integer exit code
