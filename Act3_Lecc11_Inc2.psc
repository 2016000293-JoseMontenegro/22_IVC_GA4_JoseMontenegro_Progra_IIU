Algoritmo Act3_Lecc11_Inc2
	Definir num, suma, i Como Entero
    suma = 0
    Escribir "Introduce números, para terminar escribe el 9."
	Repetir
		Escribir "Introduce un número: "
		Leer num
		Si num <> 9 Entonces
			suma = suma + num
		Fin Si
		
	Hasta Que num = 9
	Escribir "La Suma total es: ",suma
FinAlgoritmo
