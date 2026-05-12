Algoritmo Act3_Lecc11_Inc1
	Definir num1, num2, menor, mayor, suma, i Como Entero
    suma <- 0
    
    Escribir "Ingrese el primer número entero:"
    Leer num1
    Escribir "Ingrese el segundo número entero:"
    Leer num2
    
	
    Si num1 < num2 Entonces
        menor <- num1
        mayor <- num2
    Sino
        menor <- num2
        mayor <- num1
    Fin Si
    
	
    Para i <- menor Hasta mayor Hacer
        suma <- suma + i
    Fin Para
    
    Escribir "La suma de todos los enteros entre ", menor, " y ", mayor, " es: ", suma
FinAlgoritmo
