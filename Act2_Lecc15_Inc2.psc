Algoritmo Act2_Lecc15_Inc2
	Definir din, a, b, i como Entero
	Escribir "===CLASIFICACION DE BILLETES==="
	a = 0 
	b = 0 
	Para i = 1 Hasta 10 Hacer
		Escribir "Ingrese la denominación del billete ", i
		Leer din
		Si din == 100 Entonces
			a = a + 1
			b = b + 100
		Fin Si
	Fin Para
	
	Escribir "Cantidad de billetes de 100: ", a
	Escribir "billetes de 100: ", b
FinAlgoritmo
