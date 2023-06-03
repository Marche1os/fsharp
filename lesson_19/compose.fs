module lesson_19.compose

let f = fun y -> y - 5
let g = fun z -> z * z * z
let h = f << g //<< realize composition of functions. both params are functions

printfn "%d" (h 2) //2*2*2 -5 = 3

let h2 = ((fun y -> y - 5) << (fun z -> z * z * z)) 2

let h3 = f >> g // (2 - 5) * 3 * 3 * 3 = -27

printfn "%d" (h3 2)

