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

let Eler n func init =
    let rec El n func init cand=
        if cand<=0 then init
          else 
          let newInit=if nod n cand=1 then func init else init 
          let newCand=cand-1
          El n func newInit newCand
    El n func init n

[<EntryPoint>]
let main argv =
    let a=System.Convert.ToInt32(Console.ReadLine())
    System.Console.WriteLine ("Сумма чисел, взаимно простых с введенным:{0}",obrabotka a (fun x y -> x+y) 0)
    System.Console.WriteLine("Функция Эйлера от числа:{0}", Eler a (fun x  -> x + 1) 0)
    0 // return an integer exit code
