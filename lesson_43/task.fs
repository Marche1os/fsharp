module lesson_43.task

// 43.3
let try_find key m =
    match (key, m) with
    | (k, map) when Map.containsKey k map -> Some(Map.find k map)
    | (k, map) -> None
    
let rec search (list, key) =
    match list with
    | (k, v) :: tail when k = key -> Some(v)
    | (k, v) :: tail -> search(tail, key)
    | [] -> None

let try_find2 key m = search (Map.toList m, key)

printfn "%A" (try_find2 1 Map[(1, "Mark"); (2, "Daria")])