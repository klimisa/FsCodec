namespace FsCodec.NewtonsoftJson

open System

[<AutoOpen>]
module ReflectionHelper =
    let TypesImplementing<'T> (assembly : System.Reflection.Assembly) : Type seq =
        Seq.empty

type TypeChecker (allowMaps: bool) =
    member this.EnumViolations(types : Type) : string seq =
        Seq.empty

