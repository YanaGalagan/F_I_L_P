
open System
open System.Windows
open System.Windows.Controls
open System.Windows.Markup


let mwXaml = """
<Window 
xmlns='http://schemas.microsoft.com/winfx/2006/xaml/presentation'
 xmlns:x='http://schemas.microsoft.com/winfx/2006/xaml'
 xmlns:d='http://schemas.microsoft.com/expression/blend/2008' xmlns:mc='http://schemas.openxmlformats.org/markup-compatibility/2006' mc:Ignorable='d'
 Title='F# WPF' Height='145.845' Width='307.196'>
    <Grid Height='117' VerticalAlignment='Top'>
        <Grid.ColumnDefinitions>
            <ColumnDefinition Width='3*' />
            <ColumnDefinition Width='0*'/>
            <ColumnDefinition Width='0*'/>
            <ColumnDefinition Width='41*'/>
            <ColumnDefinition Width='0' />
            <ColumnDefinition Width='0'/>
            <ColumnDefinition Width='211'/>
        </Grid.ColumnDefinitions>
        <GroupBox Header='Операции&#xD;&#xA;' Height='117' HorizontalAlignment='Left' x:Name='groupBox2' VerticalAlignment='Top' 
Width='299' Grid.ColumnSpan='7'>
            <Button Content='Выход' Height='23' HorizontalAlignment='Left' Margin='199,55,-2,0' x:Name='exit' VerticalAlignment='Top' Width='90' 
/>
        </GroupBox>
        <TextBox x:Name='x1' HorizontalAlignment='Left' Height='23' TextWrapping='Wrap' Text='' VerticalAlignment='Top' Width='73' Margin='0,27,0,0' Grid.Column='1' Grid.ColumnSpan='3'/>
        <TextBox x:Name='x2' HorizontalAlignment='Left' Height='23' TextWrapping='Wrap' VerticalAlignment='Top' Width='73' Margin='1,27,0,0' Grid.Column='4' Grid.ColumnSpan='3'/>
        <Button Content='+' Height='23' HorizontalAlignment='Left' Margin='0,89,0,0' x:Name='sum' VerticalAlignment='Top' Width='19' 
Grid.Column='3' FontSize='14' 
/>
        <Button Content='-' Height='23' HorizontalAlignment='Left' Margin='24,89,0,0' x:Name='sub' VerticalAlignment='Top' Width='19' 
            Grid.Column='3' FontSize='14' 
/>
        <Button Content='*' Height='23' HorizontalAlignment='Left' Margin='48,89,0,0' x:Name='prod' VerticalAlignment='Top' Width='19' 
            Grid.Column='3' FontSize='14' 
/>
        <Button Content='/' Height='23' HorizontalAlignment='Left' Margin='72,89,0,0' x:Name='div' VerticalAlignment='Top' Width='19' 
            Grid.Column='3' FontSize='14' Grid.ColumnSpan='4' 
/>
    </Grid>
</Window>
"""


let getWindow(mwXaml) =
    let xamlObj=XamlReader.Parse(mwXaml)
    xamlObj :?> Window

let win = getWindow(mwXaml)

let sum = win.FindName("sum") :?> Button
let sub = win.FindName("sub") :?> Button
let prod = win.FindName("prod") :?> Button
let div = win.FindName("div") :?> Button
let exit = win.FindName("exit") :?> Button
let x1 = win.FindName("x1") :?>TextBox
let x2 = win.FindName("x2") :?>TextBox



let operate func =
    fun _ -> (
        try 
            let res = (double)x1.Text |> func <| (double)x2.Text
            MessageBox.Show(string res) |> ignore
        with ex ->
            printfn "%A" ex
            MessageBox.Show(ex.ToString()) |> ignore
        )
sum.Click.Add(operate (fun a b -> a + b))
sub.Click.Add(operate (fun a b -> a - b))
prod.Click.Add(operate (fun a b -> a * b))
div.Click.Add(operate (fun a b -> a / b))


//[<STAThread>] 
//ignore <| (new Application()).Run win 
[<EntryPoint;STAThread>]
let main argv =
    ignore <| (new Application()).Run win
    0