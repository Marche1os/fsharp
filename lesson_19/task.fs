module lesson_19.task

let divide100 = fun y -> y / 100.0

let multiply = fun (n, x) -> float n * x: float  

let calcPercent = multiply >> divide100

// 20.3.1
let vat n x = if (n >= 0 && n <= 100) then calcPercent(n, x) + x else 0.0

// 20.3.2
let unvat n x = x / (1.0 + float n / 100.0)

// 20.3.3
let rec min f =
    let rec innerMin = function
        | (f, n) when f(n) = 0 -> n
        | (f, n) -> innerMin (f, n + 1)
    innerMin (f, 1)