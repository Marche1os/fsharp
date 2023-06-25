// 42.3
let rec allSubsets n k =
    if k = n then
        set[set [1..n]]
    else if k = 0 then
             Set.empty
    else
        let left = allSubsets(n-1) k
        let right = allSubsets (n - 1) (k - 1)
        let addNToSet subset = Set.add n subset
        Set.union (left) (Set.map addNToSet right)