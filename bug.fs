let mutable x = 10
let mutable y = 20
let mutable z = 30

let add x y = x + y

let result = add x y
printfn "%d" result

x <- 100
y <- 200
z <- 300

let result2 = add x y
printfn "%d" result2