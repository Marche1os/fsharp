module lesson_21.Closures

let multiplyBy number =
    (fun x -> x * number)
    
let timesTwo = multiplyBy 2
let timesThree = multiplyBy 3

printfn "%d" (timesTwo 5)
printfn "%d" (timesThree 5)

let pi = 3.14159
let circle r = 2.0 * pi * r

printfn "%f" (circle 2.0)
