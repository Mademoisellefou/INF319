main = do
    putStrLn "Introduzca un numero"
    num1 <- getLine
    let n1 = read num1 :: Double
    putStrLn "Introduzca un numero"
    num2 <- getLine
    let n2 = read num2 :: Double
    putStrLn "Suma"
    print (n1 + n2)
    putStrLn "Resta"
    print (n1 - n2)
    putStrLn "Mutiplicacion"
    print (n1 * n2)
    putStrLn "Division"
    print (n1 / n2)

    