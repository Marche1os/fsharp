module lesson_21.task

let curry (f: int * int -> int) (x: int) (y: int) =
    f(x, y)
    
let uncurry (f: int -> int -> int) (x: int, y: int): int =
    f x y