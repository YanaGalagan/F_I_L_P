// Learn more about F# at http://fsharp.org
(*3 Для введенного числа N построить список неповторяющихся кортежей
(a,b), таких, что существует пара (x,y): X*Y=N, НОД(X,Y)=d, a=X/d, b=Y/d .*)
open System
let rec nod n m=
    if n=0||m=0 then n+m 
    else
    let newn=if n>m then n%m else n
    let newm=if n<=m then m%n else m
    nod newn newm

let rec writelist list=
    match list with
    |[]->0
    |_-> Console.WriteLine("({0},{1})", fst list.Head, snd list.Head)
         writelist list.Tail


[<EntryPoint>]
let main argv =
    let n= System.Convert.ToInt32(System.Console.ReadLine())
    let n1=n/2 
    let n2=n1+1
    let l1=[1..n]
    let l2=[1..n]
    let New=List.allPairs l1 l2
    let filtr=List.filter (fun x-> fst x * snd x=n) New
    let otv = List.map (fun x->(fst x / nod (fst x) (snd x)),(snd x /nod (fst x) (snd x))) filtr
    writelist otv
    
    0 // return an integer exit code
