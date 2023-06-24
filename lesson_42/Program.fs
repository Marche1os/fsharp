// 42.3
let rec allSubsets n k =
    if k = n then
        [Set.ofSeq [1..n]]
    else if k = 0 then
             [Set.empty]
    else
        let left = allSubsets(n-1) k
        let right = left |> List.map(fun x -> x.Add n)
        left @ right
   