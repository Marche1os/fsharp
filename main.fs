// 48.4.1
let rec fibo1 n n1 n2 = 
    if n <= 0 then n2
    else fibo1 (n - 1) (n1 + n2) n1

// 48.4.2
let rec fibo2 n c = 
    if n <= 0 then c 0
    elif n = 1 then c 1
    else fibo2 (n - 1) (fun f -> fibo2 (n - 2) (fun f2 -> c (f + f2)))

// 48.4.3
let rec bigList n k =
    let rec buildList n acc =
      if n = 0 then k acc
      else buildList (n - 1) (1::acc)
    buildList n []