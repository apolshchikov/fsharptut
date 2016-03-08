let negate (x: int) = x * -1
let square x = x * x
let print x = printfn "%d" x

let squareNegateThenPrint x = print(negate(square x))
squareNegateThenPrint 5