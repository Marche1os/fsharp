// 42.3
let rec allSubsets n k =
    match (n, k) with
    | (_, 0) -> set[Set.empty]
    | (n, k) when n < k -> Set.empty
    | (n, k) ->
        let left = allSubsets(n-1) k
        let right = allSubsets (n - 1) (k - 1)
        let addNToSet subset = Set.add n subset
        Set.union (left) (Set.map addNToSet right)
        