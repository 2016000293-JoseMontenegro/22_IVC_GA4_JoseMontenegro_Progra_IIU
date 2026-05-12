Algoritmo Act3_Lecc15_Inc2
	Definir i, j, pri, par Como Entero
    Definir a Como Logico
    
    pri = 0
    par = 0
    
    Para i = 300 Hasta 1 Con Paso -1 Hacer
        
		
        Si i MOD 2 = 0 Entonces
            par = par + i
        FinSi
        
		
        a = Verdadero
        
        Si i <= 1 Entonces
            a <- Falso
        SiNo
            Para j <- 2 Hasta i - 1 Hacer
                Si i MOD j = 0 Entonces
                    a <- Falso
                FinSi
            FinPara
        FinSi
        
        Si a Entonces
            pri = pri + 1
        FinSi
        
    FinPara
    
    Escribir "Cantidad de números primos: ", pri
    Escribir "Suma de números pares: ", par
FinAlgoritmo
