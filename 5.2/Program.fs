

open System
let D a b c = Math.Sqrt(b*b-4.0*a*c)
let x1 a b D = ((-b)+D)/(2.0*a)
let x2 a b D = ((-b)-D)/(2.0*a)


[<EntryPoint>]
let main argv =
    let a=System.Convert.ToDouble(System.Console.ReadLine())
    let b=System.Convert.ToDouble(System.Console.ReadLine())
    let c=System.Convert.ToDouble(System.Console.ReadLine())

    let Diskr:float = D a b c 
    let X_1:float= x1 a b Diskr
    let X_2:float= x2 a b Diskr

    System.Console.WriteLine(X_1)
    System.Console.WriteLine(X_2)

    0 
