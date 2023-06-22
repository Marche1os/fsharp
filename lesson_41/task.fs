module lesson_41.task

// 41.4.1
let list_filter f xs =
    List.foldBack (fun head acc ->
        if f head then head :: acc else acc) xs []
        
// 41.4.2
let sum (p, xs) =
    List.foldBack (fun head acc ->
        if p head then head + acc else acc) xs 0

let rec reverseList list =
    match list with
    | [] -> []
    | head::tail -> (reverseList tail) @ [head] 

// 41.4.3
let revrev lol =
    List.fold (fun head tail -> reverseList tail::head) [] lol