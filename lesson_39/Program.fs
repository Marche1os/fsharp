// 39.1
let rec rmodd list =
    match list with
    | [] -> []
    | [_] -> []
    | x::y::t -> y :: (rmodd t)
    

// 39.2
let rec del_even list =
    match list with
    | [] -> []
    | head::tail when (head % 2 = 0) -> (del_even tail)
    | head :: tail -> head :: del_even tail 
    

// 39.3
let rec multiplicity x xs =
    match xs with
    | [] -> 0
    | head::tail when head = x -> 1 + (multiplicity x tail)
    | head::tail -> multiplicity x tail

// 39.4
let rec split = function
    | [] -> ([], [])
    | [x] -> ([x], [])
    | head::middle::tail ->
        let (x1, x2) = split tail
        (head::x1, middle::x2)

exception SizesDoesNotMatchException

// 39.5
let rec zip (xs1,xs2) =
    match (xs1, xs2) with
    | ([], []) -> []
    | ([], _) | (_, []) -> raise SizesDoesNotMatchException
    | (head1 :: tail1, head2 :: tail2) -> (head1, head2) :: zip (tail1, tail2)
