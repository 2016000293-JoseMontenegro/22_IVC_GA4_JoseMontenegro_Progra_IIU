Algoritmo Act1_Lecc9_Inc1
	Definir pesoManz, pesoTot, Manz Como Entero
	pesoTot = 0
	pesoManz = 0 
	Manz = 0	
	Mientras pesoTot<= 1000 Hacer
		Escribir "Ingrese el peso de la manzana en gramos: "
		Leer pesoManz
		
		Si pesoManz>=180 y pesoManz<=200 Entonces
			pesoTot = pesoTot+pesoManz
			Manz = Manz+1
			
			Escribir "LLevas: ",pesoTot, " g"
		SiNo
			Escribir "Manzana Inválida"
		Fin Si
	Fin Mientras
	
	Escribir "Ya tienes 1 kg o más de manzanas"
	Escribir "Total de Manzanas: ",Manz
FinAlgoritmo
