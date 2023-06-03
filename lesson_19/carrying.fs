module lesson_19.carrying

let f x = fun y -> y - x
let minus10 = f 10

printfn "%d" (f 2 3) //1
printfn "%d" (f 10 12) //2
printfn "%d" (minus10 12) //2


//compact expression
let fC x y = y - x
let minus10C = f 10
printfn "%d" (minus10 12) //2