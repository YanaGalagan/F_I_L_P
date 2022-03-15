// Learn more about F# at http://fsharp.org

open System
//обход делителей числа с условием
let obxod n predicate func init=
    let rec obxod1 n func init b=
        if b=0 then init else
        let newInit= if n%b=0 && predicate b then func init b else init
        let newb=b-1
        obxod1 n func newInit newb 
    obxod1 n func init n

let rec nod n m=
    if n=0||m=0 then n+m 
    else
    let newn=if n>m then n%m else n
    let newm=if n<=m then m%n else m
    nod newn newm

//обход взаимно простых с условием 
let obrabotka n predicate func init=
    let rec obr n func init cand=
        if cand<=0 then init else
        let newInit= if nod n cand=1 && predicate cand then func init cand else init
        let newcand=cand-1
        obr n func newInit newcand
    obr n func init n
[<EntryPoint>]
let main argv =

    let a = System.Convert.ToInt32(System.Console.ReadLine())
    Console.WriteLine("Сумма нечётных делителей числа:{0}",obxod a (fun x -> x%2=1) (fun x y ->x+y) 0)
    Console.WriteLine("Произведение чётных чисел, взаимно простых с данным:{0}", obrabotka a (fun x->x%2=0) (fun x y->x*y) 1 )
    0 // return an integer exit code
