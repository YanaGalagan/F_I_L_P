// Learn more about F# at http://fsharp.org

open System
// максимальный простой делитель числа
let prov a=
    let rec prost a cand=
      if cand=0 then false
         else 
         if cand=1 then true else
            if a%cand=0 then false
             else
             let newcand=cand-1
             prost a newcand
    prost a (a-1)

let maxdelit a init =
    let rec max a init cand=
        if cand<=0 then init else
           let newInit= if prov cand && a%cand=0 && cand>init then cand else init
           let newCand=cand-1
           max a newInit newCand
    max a init a
//произведение цифр числа, не делящихся на 5
let proizved a init=
    let rec pr a init =
        if a=0 then init else
           let newInit = if (a%10)%5<>0 then init*(a%10) else init
           let newCand=a/10
           pr newCand newInit 
    pr a init 
//Найти НОД максимального нечетного непростого делителя
//числа и прозведения цифр данного числа.
let rec nod n m=
    if n=0||m=0 then n+m 
    else
    let newn=if n>m then n%m else n
    let newm=if n<=m then m%n else m
    nod newn newm

let pr a init=
    let rec p a init=
        if a=0 then init else
           let newinit=init*(a%10)
           let newa=a/10
           p newa newinit
    p a init

let max a init=
    let rec max1 a init cand=
        if cand=0 then init else
           let newInit=if a%cand=0 && cand%2=1 && not(prov a) && cand>init then cand else init
           let newCand=cand-1
           max1 a newInit newCand
    max1 a init a
[<EntryPoint>]
let main argv =
    let a=System.Convert.ToInt32(System.Console.ReadLine())
    System.Console.WriteLine("Максимальный простой делитель числа:{0}",maxdelit a 0)
    System.Console.WriteLine("Произведение цифр числа, не кратных 5:{0}",proizved a 1)
    System.Console.WriteLine("(1)Произведение цифр числа:{0}",pr a 1)
    System.Console.WriteLine("(2)Максимальный нечетный непростой делитель:{0}",max a 1)
    System.Console.WriteLine("НОД (1) и (2):{0}",nod (pr a 1) (max a 1) )
    
    0 // return an integer exit code
