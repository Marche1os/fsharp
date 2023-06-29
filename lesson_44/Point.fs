module lesson_44.Point

open Point

let p1 = create(1.0, 1.0)
let p2 = create(2.0, 2.0)
let p3 = p1 .+. p2
printfn "%f" (getY p3)