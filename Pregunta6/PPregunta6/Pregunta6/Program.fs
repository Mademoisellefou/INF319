
// Nombre: Estevez Camata Melany
open System 
[<EntryPoint>]
let main argv = 
    let suma a b = a + b
    let resta a b = a - b
    let multi a b = a * b
    let division a b = a / b
    Console.WriteLine("========================")
    Console.WriteLine("Calculador Basico\nIngrese un numero")
    let num1=Convert.ToDouble(Console.ReadLine())
    Console.WriteLine("Ingrese un numero")
    let num2=Convert.ToDouble(Console.ReadLine())
    Console.WriteLine("Calculando ...")
    Console.WriteLine("La Suma es :")
    Console.WriteLine(suma num1 num2)
    Console.WriteLine("La Resta es :")
    Console.WriteLine(resta num1 num2)
    Console.WriteLine("La Multiplicacion es :")
    Console.WriteLine(multi num1 num2)
    Console.WriteLine("La Division es :")
    Console.WriteLine(division num1 num2)
    Console.WriteLine("========================")
    let tecla=Console.ReadKey()
    0

    