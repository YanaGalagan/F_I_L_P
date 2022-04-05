// Learn more about F# at http://fsharp.org
(*3
В порядке увеличения разницы между частотой наиболее часто
встречаемого символа в строке и частотой его появления в алфавите
4
В порядке увеличения квадратичного отклонения среднего веса
ASCII-кода символа строки от среднего веса ASCII-кода символа первой
строки*)

open System
let rec readStrings n strings=
    match n with 
    |0 -> strings
    |_ -> 
        let s = Console.ReadLine()
        let newStrings = strings @ [s]
        let n1 = n - 1
        readStrings n1 newStrings

let rec writeStringList = function
    |[] -> let z = System.Console.ReadKey()
           0
    | (head : string)::tail -> 
                      System.Console.WriteLine(head)
                      writeStringList tail
let rec writePairs list =
    match list with
    |[] -> 0
    |_->
        Console.Write ("({0},{1}) ",fst list.Head,snd list.Head)
        writePairs list.Tail

let rec writeFrequencedList = function
    |[] -> let z = System.Console.ReadKey()
           0
    | head::tail -> 
                      writePairs head 
                      Console.WriteLine " "
                      writeFrequencedList tail
//список кортежей буква и её частота в строке
let freqList (s:string) = 
    let charlist = Seq.toList (s.ToLower())
    let freq = List.countBy id charlist 
    let length = (String.length (String.filter (fun x-> x <> ' ') s)) 
    let otvet = List.map (fun (x:char,x1:int)  -> (x , (Convert.ToDouble x1 ) / (Convert.ToDouble length)) )freq
    otvet

//разность встречаемости букв в строке и алфавите
let Difference (frequedCharList: (string * ((char * float) list))) (alphabet:(char*float) list) =
    let difference = snd (List.maxBy (fun x-> snd x) (snd frequedCharList)) - snd (List.find (fun x -> (fst x) = (fst (List.maxBy (fun x-> snd x) (snd frequedCharList)))) alphabet)
    difference
    
let firstTask strings =
    let frequencyList = List.map (fun x -> freqList(x)) strings
    let bString = String.concat ("":string) (strings)
    let NoSpace = String.filter( fun x -> x <> ' ') bString
    let alphabet = freqList NoSpace    
    let PlusSymbol = List.map2(fun x y -> (x,y)) strings frequencyList 
    let SortedStrings = List.sortBy (fun x -> (Difference x alphabet) ) PlusSymbol
    writeStringList (List.map (fun x-> fst x )SortedStrings)




[<EntryPoint>]
let main argv =
    (*3
    В порядке увеличения разницы между частотой наиболее часто
    встречаемого символа в строке и частотой его появления в алфавите
    4
    В порядке увеличения квадратичного отклонения среднего веса
    ASCII-кода символа строки от среднего веса ASCII-кода символа первой
    строки*)
    
    let n = Console.ReadLine() |> Int32.Parse
    let strings = readStrings n []
    firstTask strings
    
    0  // return an integer exit code
