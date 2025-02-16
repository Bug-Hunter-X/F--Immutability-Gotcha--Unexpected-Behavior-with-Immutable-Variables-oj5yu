let mutable x = 10
let mutable y = 20

let add x y = x + y

let mutable z = add x y

printfn "%d" z

x <- 100
y <- 200
z <- add x y //Reassign z to update with the new values of x and y

printfn "%d" z