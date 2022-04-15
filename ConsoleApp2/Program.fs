// Learn more about F# at http://fsharp.org

oopen System.Windows.Forms

let onButtonClick eventArgs =
    System.Diagnostics.Process.Start("https://spb.lindfors.ru/images/stories/virtuemart/product/nareznoy.jpg") |> ignore

let onBarChange (trackBar:TrackBar) (btn: Button) eventArgs =
    btn.Width <- 20 + trackBar.Value * 10

let initForm() =
    let form = new Form(Width= 400, Height = 300, Text = "F# Главная форма")
    let table = new TableLayoutPanel(ColumnCount = 1, RowCount = 2, Dock = DockStyle.Fill, AutoSize = true)
    
    table.RowStyles.Clear()
    table.RowStyles.Add(new RowStyle(sizeType = SizeType.Percent, Height = (float32)50.0)) |> ignore
    table.RowStyles.Add(new RowStyle(sizeType = SizeType.Percent, Height = (float32)50.0)) |> ignore
    
    let btn = new Button(Text = "Батон", Anchor = AnchorStyles.None, AutoSize = false, Width = 20)
    let trackBar = new TrackBar(Anchor = AnchorStyles.Top)
    btn.Click.Add onButtonClick
    trackBar.ValueChanged.Add (onBarChange trackBar btn)
    
    table.Controls.Add btn
    table.Controls.Add trackBar
    form.Controls.Add table
    
    form

[<EntryPoint>]
let main argv =
    let form = initForm()
    Application.Run(form)
    0