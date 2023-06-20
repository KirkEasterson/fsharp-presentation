module Structs

[<Struct>]
type Point2D(x: float, y: float) =
    member this.X = x
    member this.Y = y

    member this.Distance() = sqrt (this.X ** 2 + this.Y ** 2)


[<Struct>]
type Point3D(x: float, y: float, z: float) =
    member this.X = x
    member this.Y = y
    member this.Z = z

    member this.Distance() =
        sqrt (this.X ** 2 + this.Y ** 2 + this.Z ** 2)

let run args =

    let point2d = new Point2D(1, 2)
    printfn "%f" (point2d.Distance())

    let point3d = new Point3D(1, 2, 3)
    printfn "%f" (point3d.Distance())
    let point3d = new Point3D(1, 2, 3)
    printfn "%f" (point3d.Distance())
