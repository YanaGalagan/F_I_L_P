// Learn more about F# at http://fsharp.org

open System

let rec nod n m=
    if n=0||m=0 then n+m 
    else
    let newn=if n>m then n%m else n
    let newm=if n<=m then m%n else m
    nod newn newm

let obrabotka n func init=
    let rec obr n func init cand=
        if cand<=0 then init else
        let newInit= if nod n cand=1 then func init cand else init
        let newcand=cand-1
        obr n func newInit newcand
    obr n func init n

[<EntryPoint>]
let main argv =
    System.Console.WriteLine (obrabotka (System.Convert.ToInt32(Console.ReadLine())) (fun x y -> x+y) 0)
    0 // return an integer exit code
