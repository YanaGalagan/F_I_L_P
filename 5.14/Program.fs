// Learn more about F# at http://fsharp.org

open System
let obxod n func init=
    let rec obxod1 n func init b=
        if b=0 then init else
        let newInit= if n%b=0 then func init b else init
        let newb=b-1
        obxod1 n func newInit newb 
    obxod1 n func init n
[<EntryPoint>]
let main argv =
    let a=System.Convert.ToInt32(System.Console.ReadLine())
    System.Console.WriteLine("Сумма делителей числа:{0}", obxod a (fun x y -> x+y ) 0)
    0 // return an integer exit code
