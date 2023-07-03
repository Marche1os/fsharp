let rec fact n =
    if n <= 1 then 1
    else n * fact (n - 1) 

// 49.5.1
let even_seq = Seq.initInfinite (fun i -> (i + 1) * 2)

// 49.5.2
let fac_seq = Seq.initInfinite (fun i -> fact i)

// 49.5.3
let seq_seq = Seq.initInfinite (fun i ->
    if i % 2 = 0 then
        (i / 2)
    else -((i + 1) / 2))

