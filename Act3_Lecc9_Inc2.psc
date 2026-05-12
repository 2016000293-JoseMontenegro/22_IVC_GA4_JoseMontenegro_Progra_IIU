Algoritmo Act3_Lecc9_Inc2
	Definir num, x, contador Como Entero
    
    Escribir "Ingrese un numero:"
    Leer num
    
    contador = 0
    
    Para x = 1 Hasta num Hacer
        Si num % x = 0 Entonces
            contador = contador + 1
        FinSi
    FinPara
    
    Si contador = 2 Entonces
        Escribir "Es numero primo"
    SiNo
        Escribir "No es numero primo"
    FinSi
FinAlgoritmo
