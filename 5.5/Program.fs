// Learn more about F# at http://fsharp.org

open System
let sumCifr n = 
    let rec sumCifr1 n curSum = 
        if n = 0 then curSum
        else
            let n1 = n / 10
            let cifr = n % 10
            let newSum = curSum + cifr
            sumCifr1 n1 newSum
    sumCifr1 n 0

let sum_Cifr n=
    let rec sum acc n =
        if n=0 then acc 
        else sum (acc+n%10) (n/10)
    sum 0 n
[<EntryPoint>]
let main argv =
    let a=System.Convert.ToInt32(System.Console.ReadLine())
    let s:int=sumCifr a
    let sum:int=sum_Cifr a
    System.Console.WriteLine(s)
    System.Console.WriteLine(sum)
    0 // return an integer exit code
