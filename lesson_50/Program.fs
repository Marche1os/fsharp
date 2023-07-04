// 50.2.1
let fac_seq = seq {
    let mutable acc = 1
    for i in 0..System.Int32.MaxValue do
        if i = 0 then yield 1
        else 
            acc <- acc * (i)
            yield acc
}

// 50.2.2
let seq_seq = seq {
    for i in 0..System.Int32.MaxValue do
        if i % 2 = 0 then
            yield (i  / 2)
        else
            yield ((i + 1) / 2) * (-1)
}