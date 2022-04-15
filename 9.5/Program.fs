// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp
// See the 'F# Tutorial' project for more help.

// Define a function to construct a message to print
module WinformsFs.Main

open System
open System.Windows.Forms

let forms = 
    let Form1 = new Form(Text = "Form" , Width = 400, Height = 300)
    Form1

let edits = 
    let Edit1 = new TextBox(Text="")
    let Edit2 = new TextBox(Top=50, Text="")
    (Edit1, Edit2)

let buttons =
    let button1 = new Button(Text="+", Top=100, Width=50, Height=50)
    let button2 = new Button(Text="-", Top=100, Left=50, Width=50, Height=50)
    let button3 = new Button(Text="*", Top=100, Left=100, Width=50, Height=50)
    let button4 = new Button(Text="/", Top=100, Left=150, Width=50, Height=50)
    (button1, button2, button3, button4)

[<EntryPoint; STAThread>]
let main argv =
    let Form1 = forms
    let Edit1, Edit2 = edits
    let button1, button2, button3, button4 = buttons
    
    Form1.Controls.Add(Edit1)
    Form1.Controls.Add(Edit2)
    Form1.Controls.Add(button1)
    Form1.Controls.Add(button2)
    Form1.Controls.Add(button3)
    Form1.Controls.Add(button4)

    let Summ_ = fun _ -> MessageBox.Show(string(int(Edit1.Text) + (int(Edit2.Text))), "Сумма") |>ignore
    let Minus_ = fun _ -> MessageBox.Show(string(int(Edit1.Text) - (int(Edit2.Text))), "Разность") |>ignore
    let Umnoj_ = fun _ -> MessageBox.Show(string(int(Edit1.Text) * (int(Edit2.Text))), "Умножение") |>ignore
    let Del_ = fun _ -> 
        try 
            let calculus = int(Edit1.Text)/ (int(Edit2.Text))
            MessageBox.Show(string(calculus), "Деление") |> ignore
        with ex -> (
            printfn "%A" ex;
            MessageBox.Show(ex.ToString(), "Div error:") |> ignore
            )

    let _ = button1.Click.Add(Summ_)
    let _ = button2.Click.Add(Minus_)
    let _ = button3.Click.Add(Umnoj_)
    let _ = button4.Click.Add(Del_)

    do Application.Run(Form1)
    0