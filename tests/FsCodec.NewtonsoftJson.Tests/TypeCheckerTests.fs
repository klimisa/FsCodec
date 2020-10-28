module FsCodec.NewtonsoftJson.Tests.TypeCheckerTests

open FsCodec.NewtonsoftJson
open Swensen.Unquote
open System
open Xunit

module Domain =
    type SampleType = { EnumSample: Enum }

[<Fact>]
let ``All contract types use simple tagged types`` () =
    let checker =
        FsCodec.NewtonsoftJson.TypeChecker(allowMaps = true) // or any other exceptions to the search

    let anoms =
        TypesImplementing<TypeShape.UnionContract.IUnionContract>(typeof<Domain.SampleType>.Assembly)
        |> Seq.collect checker.EnumViolations
        |> List.ofSeq

    test <@ [] = anoms @>
