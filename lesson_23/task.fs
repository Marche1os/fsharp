module lesson_23.task

let rebalance coopers =
    let (tempSilver, outCoopers) =
        if coopers / 12 > 0 then (coopers / 12, coopers % 12)
        else (0, coopers)
    let (outGold, outSilver) =
        if tempSilver / 20 > 0 then (tempSilver / 20, tempSilver % 20)
        else (0, tempSilver)
    (outGold, outSilver, outCoopers)

let sumMoneyAndGetCoopers a b =
    let (a1, a2, a3) = a
    let (b1, b2, b3) = b
    let goldToSilver = (a1 + b1) * 20
    let silverToCooper = ((a2 + b2) + goldToSilver) * 12
    (a3 + b3) + silverToCooper

// 23.4.1
let (.+.) x y =
    let coopers = sumMoneyAndGetCoopers x y
    rebalance coopers
    
let (.-.) x y =
    let (x1, x2, x3) = x
    let (y1, y2, y3) = y
    (x1, x2, x3) .+. (-y1, -y2, -y3)

// 23.4.2
let (.+) x y =
    let (a, b) = x
    let (c, d) = y
    (a + c, b + d)
    
let (.-) x y =
    let (c, d) = y
    x .+ (-c, -d)

let (.*) x y =
    let (a, b) = x
    let (c, d) = y
    let x1 = (a * c) - (b * d)
    let x2 = (b * c) + (a * d)
    (x1, x2)

let (./) x y =
    let (a, b) = y
    x .* (a / (a*a + b*b), -b / (a*a + b*b))