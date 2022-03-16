// Learn more about F# at http://fsharp.org

open System
// максимальный простой делитель числа
let proverka_prostota a=
    let rec prost a cand=
      if cand=0 then false
         else 
         if cand=1 then true else
            if a%cand=0 then false
             else
             let newcand=cand-1
             prost a newcand
    prost a (a-1)

let max_prost_delit a  =
    let rec max a init cand=
        if cand<=0 then init else
           let newInit= if proverka_prostota cand && a%cand=0 && cand>init then cand else init
           let newCand=cand-1
           max a newInit newCand
    max a 1 a
//произведение цифр числа, не делящихся на 5
let proizvedenienotmod5 a =
    let rec pr a init =
        if a=0 then init else
           let newInit = if (a%10)%5<>0 then init*(a%10) else init
           let newCand=a/10
           pr newCand newInit 
    pr a 1 
//Найти НОД максимального нечетного непростого делителя
//числа и прозведения цифр данного числа.
let rec nod n m=
    if n=0||m=0 then n+m 
    else
    let newn=if n>m then n%m else n
    let newm=if n<=m then m%n else m
    nod newn newm

let proizvedenie a =
    let rec p a init=
        if a=0 then init else
           let newinit=init*(a%10)
           let newa=a/10
           p newa newinit
    p a 1

let max_nechet_neprost a =
    let rec max1 a init cand=
        if cand=0 then init else
           let newInit=if a%cand=0 && cand%2=1 && not(proverka_prostota a) && cand>init then cand else init
           let newCand=cand-1
           max1 a newInit newCand
    max1 a 0 a

let nod12 a = nod (proizvedenie a) (max_nechet_neprost a)

let vibor=function
    | 1-> max_prost_delit
    | 2-> proizvedenienotmod5
    | 3-> nod12
    | _->nod12
    
[<EntryPoint>]
let main argv =
    let a = (Console.ReadLine() |> Int32.Parse, Console.ReadLine() |> Int32.Parse)
    let result = vibor (fst a) (snd a)
    System.Console.WriteLine(result)
    0 // return an integer exit code
