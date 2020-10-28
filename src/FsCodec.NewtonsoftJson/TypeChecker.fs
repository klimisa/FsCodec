namespace FsCodec.NewtonsoftJson

open System
open System.Linq

[<AutoOpen>]
module TypeCheckerHelpers =
    let TypesImplementing<'T> (assembly : System.Reflection.Assembly) : Type seq =
        assembly.GetTypes()
        |> Seq.filter (fun t -> typeof<'T>.IsAssignableFrom(t))
        |> Seq.filter (fun t  -> not t.IsAbstract)

type TypeChecker (allowMaps: bool) =
    member this.EnumViolations(t : Type) : string seq =
       Seq.empty

