type TimeOfDay = { hours: int; minutes: int; f: string }

let (.>.) x y =
    let {hours = h1; minutes = m1; f = f1 } = x
    let {hours = h2; minutes = m2; f = f2 } = y
    let x1 = if f1 = "AM" then (h1, m1) else (h1 + 12, m1)
    let y1 = if f2 = "AM" then (h2, m2) else (h2 + 12, m2)
    x1 > y1
    
    