//PSeInt
Algoritmo Act1_Lecc11_Inc1
	Definir cajonesOcupados, capacidadTotal, opc Como Entero
	capacidadTotal = 10
	cajonesOcupados = 0
	Repetir
		Escribir "------SISTEMA DE ACCESO------"
		Escribir "Cajones Ocupados: ",cajonesOcupados, " / ", capacidadTotal
		Escribir "Cajones Disponibles: ",capacidadTotal - cajonesOcupados
		Escribir "Presiones [1] para ingresar un auto o presione [0] para salir del sistema"
		leer opc
		
		Si opc = 1 Entonces
			cajonesOcupados = cajonesOcupados+1
			Escribir "Ticket Impreso. ¡BIENVENIDO!"
		SiNo
			Si opc <> 0 Entonces
				Escribir "Opción no Válida"
			FinSi
		Fin Si
		Escribir "-----------------------------"
	Hasta Que cajonesOcupados>=capacidadTotal o opc=0
	Si cajonesOcupados >= capacidadTotal Entonces
		Escribir "AVISO: Estacionamiento Lleno"
		Escribir "No se permite más ingresos"
	FinSi
	
	Escribir "Cerrando el sistema de monitoreo"
FinAlgoritmo
