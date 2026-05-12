Algoritmo Act2_Lecc15_Inc1
	Definir n, i, divisores, contPrimos Como Entero
    Definir sumaPrimos Como Entero
    
    contPrimos <- 0
    sumaPrimos <- 0
    
    Para n <- 2 Hasta 100 Hacer
        divisores <- 0
		
        Para i <- 1 Hasta n Hacer
            Si n % i = 0 Entonces
                divisores <- divisores + 1
            Fin Si
        Fin Para
        
        
        Si divisores = 2 Entonces
            contPrimos <- contPrimos + 1
            sumaPrimos <- sumaPrimos + n
        Fin Si
    Fin Para
    
    Escribir "Cantidad de números primos encontrados: ", contPrimos
    Escribir "La suma total de estos números es: ", sumaPrimos
FinAlgoritmo
