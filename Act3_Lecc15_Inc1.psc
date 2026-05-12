Algoritmo Act3_Lecc15_Inc1
	Definir i, multi, sum, par Como Entero
    
    sum <- 0
    par <- 0
    
    Para i = 1 Hasta 20 Con Paso 1 Hacer
        multi = i * 7
        sum = sum + multi
        
        Si multi MOD 2 = 0 Entonces
            par= par + 1
        FinSi
    FinPara
    
    Escribir "Sumatoria: ", sum
    Escribir "Cantidad de pares: ", par
FinAlgoritmo
