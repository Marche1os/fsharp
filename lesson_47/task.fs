module lesson_47.task
// 47.4.1
let f n =
    let i = ref 1
    let res = ref 1
    while ! i < n + 1 do
        res := ! res * ! i
        i := ! i + 1
    ! res

// 47.4.2
let fibo n =
    let mutable seq = [0; 1]
    let mutable i = 2
    while i <= n do
        let a = seq.[i - 1]
        let b = seq.[i - 2]
        seq <- seq @ [a + b]
        i <- i + 1
    seq.[n]