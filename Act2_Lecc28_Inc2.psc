Algoritmo Act2_Lecc28_Inc2
	Definir opc, totBoletos Como Entero
    Definir totDinero Como Real
    
    totBoletos <- 0
    totDinero <- 0
    opc = 1
    
    Escribir "--- Sistema de Ventas: Rueda de la Fortuna ---"
    
    Mientras opc <> 0 Hacer
        Escribir "Seleccione tipo de boleto:"
        Escribir "1. Adulto ($15)"
        Escribir "2. Niño ($10)"
        Escribir "0. Cerrar caja y ver totales"
        Leer opc
        
        Segun opc Hacer
            1:
                totBoletos <- totBoletos + 1
                totDinero <- totDinero + 15
                Escribir "Boleto de adulto registrado."
            2:
                totBoletos <- totBoletos + 1
                totDinero <- totDinero + 10
                Escribir "Boleto de niño registrado."
            0:
                Escribir "Cerrando sistema..."
            De Otro Modo:
                Escribir "Opción no válida."
        Fin Segun
        
        Escribir "Estado actual: ", totBoletos, " boletos vendidos. Total: $", totDinero
        Escribir "--------------------------------------------"
    Fin Mientras
    
    Escribir "REPORTE FINAL:"
    Escribir "Total de boletos vendidos: ", totBoletos
    Escribir "Total de dinero cobrado: ", totDinero
FinAlgoritmo
