// 40.1
let rec sum (p, xs) =
    let rec loop p list acc =
        match list with
        | [] -> acc
        | head :: tail when p head -> loop p tail acc + head
        | head :: tail -> loop p tail acc
    loop p xs 0

// 40.2.1
let rec count (xs, n) =
    let rec loop list n count =
        match list with
        | [] -> count
        | head :: tail when head > n -> count
        | head :: tail when head = n -> loop tail n count + 1
        | head :: tail when head <> n -> loop tail n count
    loop xs n 0

// 40.2.2
let rec insert (xs, n) =
    match xs with
    | [] -> [n]
    | head::tail when n <= head -> n :: xs
    | head::tail -> head :: (insert (tail, n))

// 40.2.3
let rec intersect (xs1, xs2) =
    match xs1, xs2 with
    | [], _|_, [] -> []
    | head1::tail1, head2::tail2 when head1 = head2 -> head1::(intersect (tail1, tail2))
    | head1::tail1, head2::tail2 when head1 < head2 -> intersect (tail1, xs2)
    | head1::tail1, head2::tail2 -> intersect (xs1, tail2)
        
// 40.2.4
let rec plus (xs1, xs2) =
    match xs1, xs2 with
    | ([], []) | ([], _) | (_, []) -> xs1 @ xs2
    | head1::tail1, head2::tail2 when head1 > head2 -> head2 :: plus(head1::tail1, tail2)
    | head1::tail1, head2::tail2 when head1 < head2 -> head2 :: plus(tail1, head2::tail2)
    | head1::tail1, head2::tail2 when head1 = head2 -> [head1; head2] @ plus(tail1, tail2)
    
// 40.2.5
let rec minus (xs1, xs2) =
    let rec contains list el =
        match list with
        | [] -> false
        | head::tail -> if head = el then true else contains tail el
    
    let rec delete list el =
        match list with
        | [] -> []
        | head::tail -> if head = el then tail else delete tail el
        
    match xs1 with
    | [] -> []
    | head::tail ->
        if contains xs2 head then
            minus (tail, delete xs2 head)
        else
            head::minus (tail, xs2)

// 40.3.1
let rec smallest list =
    let rec inner = function
        | (least, []) -> Some least
        | (least, head::tail) when head < least -> inner(head, tail)
        | (least, head::tail) -> inner(least, tail)
    match list with
    | [] -> None
    | head::tail -> inner(head, tail)

// 40.3.2
let rec delete (n, xs) =
    match xs with
    | [] -> []
    | head::tail when head = n -> tail
    | head::tail -> head :: delete(n, tail)

// 40.3.3
let rec sort xs =
    let rec loop (list, res) =
        let el = smallest list
        if el.IsSome then
            loop(delete(el.Value, list), res @ [el.Value])
        else
            res
    loop (xs, [])

let rec reverseList list =
    match list with
    | [] -> []
    | head::tail -> (reverseList tail) @ [head]

let rec mapping f list =
    match list with
    | [] -> []
    | head::tail -> (f head) :: (mapping f tail)

// 40.4
let rec revrev list =
    let reversedLists = reverseList list
    mapping reverseList reversedLists
