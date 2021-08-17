namespace Minimal.Controls

open Elmish.WPF

module TestControl =
    type Model =
        {
            Count: int
            SomeParam: string
        }

    type Msg =
        | Increment
        | Decrement
        
    let init someParam =
        {
            Count = 0
            SomeParam = someParam
        }

    let update msg m =
        match msg with
        | Increment -> { m with Count = m.Count + 1 }
        | Decrement -> { m with Count = m.Count - 1 }

    let bindings() =
        [
            "SomeParam" |> Binding.oneWay(fun m -> m.SomeParam)
            "Count" |> Binding.oneWay (fun m -> m.Count)
            "Increment" |> Binding.cmd Increment
            "Decrement" |> Binding.cmd Decrement
        ]

    let initWithControl control someParam =
        Program.mkSimpleWpf (fun () -> init someParam) update bindings
        |> Program.startElmishLoop ElmConfig.Default control