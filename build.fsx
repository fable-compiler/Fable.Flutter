#r "nuget: Fable.PublishUtils, 2.4.0"

open PublishUtils

let args =
    fsi.CommandLineArgs
    |> Array.skip 1
    |> List.ofArray

match args with
| IgnoreCase "publish"::_ ->
    pushFableNuget "src/Fable.Flutter/Fable.Flutter.fsproj" [] doNothing
    pushFableNuget "src/Elmish.Flutter/Elmish.Flutter.fsproj" [] doNothing
| _ -> ()
