module Records

type Point2D =
    { X: float
      Y: float }

    static member Default = { X = 0; Y = 0 }
    member this.Distance() = sqrt (this.X ** 2 + this.Y ** 2)

type Point3D =
    { X: float
      Y: float
      Z: float }

    member this.Distance() =
        sqrt (this.X ** 2 + this.Y ** 2 + this.Z ** 2)

// using default values; this is preferred over attaching defaults to the Record
let defaultPoint3D = { X = 0; Y = 0; Z = 0 }


// discriminated union
type Point =
    | P2d of Point2D
    | P3d of Point3D

let PointDistance (point: Point) =
    match point with
    | P2d p -> p.Distance()
    | P3d p -> p.Distance()


type Number =
    | Float of float
    | Int of int
    | Int32 of int32

let addOneNum (x: Number) : Number =
    match x with
    | Float f -> Float (f + 1.0)
    | Int i -> Int (i + 1)
    | Int32 i -> Int32 (i + 1)


let run args =

    // using a default member
    let point2D1 = Point2D.Default
    // point2D1.X <- 2 // how to assign a value
    point2D1.Distance() |> printfn "distance for 2d point: %f"

    // using a manually defined default
    let point3D1 = { defaultPoint3D with X = 7; Z = -5 }
    point3D1.Distance() |> printfn "distance for 3d point: %f"

    // using discriminated unions
    let point1 = P2d { X = 4; Y = -1 }
    let point2 = P3d { X = 2; Y = 1; Z = 6 }

    PointDistance point1
    |> printfn "the distance for point1 is %f"

    PointDistance point2
    |> printfn "the distance for point2 is %f"

    // well known discriminated unions are:
    //    - Option
    //    - Result
