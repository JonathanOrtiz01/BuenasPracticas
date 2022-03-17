using System;

interface compararFechas
{
    void compararFechas(DateTime fechaTipoDate, DateTime ahora);
}
public class CompararFechas : compararFechas
{
    int tiempoCero = 0;
    int diferenciaMinutos;
    int diferenciaHoras;
    int diferenciaDias;
    int diferenciaMeses;
    public void compararFechas(DateTime fechaTipoDate, DateTime ahora)
    {
        //CompararFechas
        diferenciaMinutos = fechaTipoDate.Minute - ahora.Minute;
        diferenciaHoras = fechaTipoDate.Hour - ahora.Hour;
        diferenciaDias = fechaTipoDate.Day - ahora.Day;
        diferenciaMeses = fechaTipoDate.Month - ahora.Month;

        calcularMeses();
        calcularDias();

        if (diferenciaDias == tiempoCero && diferenciaMeses == tiempoCero)
        {
            calcularHoras();

            if (diferenciaHoras == tiempoCero)
            {
                calcularMinutos();
            }
        }
    }
    private void calcularMeses()
    {
        //Calcular meses
        if (diferenciaMeses > tiempoCero)
        {
            Console.WriteLine("Ocurrira en " + diferenciaMeses + " meses");
        }
        if (diferenciaMeses < tiempoCero)
        {
            Console.WriteLine("Ocurrio hace " + Math.Abs(diferenciaMeses) + " meses");
        }
    }
    private void calcularDias()
    {
        //Calcular dias
        if (diferenciaMeses == tiempoCero)
        {
            if (diferenciaDias > tiempoCero)
            {
                Console.WriteLine("Ocurrira en " + diferenciaDias + " dias");
            }
            if (diferenciaDias < tiempoCero)
            {
                Console.WriteLine("Ocurrio hace " + Math.Abs(diferenciaDias) + " dias");
            }
        }
    }
    private void calcularHoras()
    {
        //Calcular horas
        if (diferenciaHoras > tiempoCero)
        {
            Console.WriteLine("Ocurrira en " + diferenciaHoras + " horas");
        }
        if (diferenciaHoras < tiempoCero)
        {
            Console.WriteLine("Ocurrio hace " + Math.Abs(diferenciaHoras) + " horas");
        }
    }
    private void calcularMinutos()
    {
        //Calcular minutos
        if (diferenciaMinutos > tiempoCero)
        {
            Console.WriteLine("Ocurrira en " + diferenciaMinutos + " minutos");
        }
        if (diferenciaMinutos < tiempoCero)
        {
            Console.WriteLine("Ocurrio hace " + Math.Abs(diferenciaMinutos) + " minutos");
        }
    }
}