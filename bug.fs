let mutable x = 10
let mutable y = 20

let add x y = x + y

let z = add x y

printfn "%d" z

x <- 100
y <- 200

printfn "%d" z //This will still print 30 because z is not a mutable variable. To update z, we need to re-assign it to the new values of x and y