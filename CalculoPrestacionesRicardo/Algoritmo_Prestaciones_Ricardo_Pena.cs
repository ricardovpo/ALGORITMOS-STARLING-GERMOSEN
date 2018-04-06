using System;
using System.IO;
using System.Text;

namespace Algoritmo_Prestaciones_Ricardo_Pena
{
   public class main_class
   {
      static System.Random random_generator = new System.Random();
      public static void Main(string[] args)
      {
         string raptor_prompt_variable_zzyz;
         ?? anio_de_salida;
         ?? monto_a_pagar_vacaciones;
         ?? anios_hasta_1992;
         ?? pago_dias_por_meses_cesantia;
         ?? monto_a_pagar_cesantia;
         ?? monto_a_pagar_preaviso;
         ?? mes_de_entrada;
         ?? anio_de_entrada;
         ?? dias_a_pagar_cesantia_antes_1992;
         ?? calcular_vacaciones;
         ?? dias_de_vacaciones;
         ?? meses_laborados;
         ?? dias_a_pagar_meses_cesantia;
         ?? anios_laborados;
         ?? mes_de_salida;
         ?? dias_a_pagar_preaviso;
         ?? dia_de_salida;
         ?? calcular_salario_navidad;
         ?? monto_cesantia_antes_1992;
         ?? dias_a_pagar_anios_meses_cesantia;
         ?? dias_a_pagar_anios_cesantia;
         ?? pago_salario_navidad;
         ?? sueldo;
         ?? dias_laborados;
         ?? salario_diario;
         ?? nombre_persona;
         ?? calcular_preaviso;
         ?? periodo_de_pago;
         ?? total_a_recibir;
         ?? tipo_de_calculo;
         ?? calcular_cesantia;
         ?? dia_de_entrada;
      
         Nombre_Persona ="";
         Dia_de_entrada =0;
         Mes_de_entrada =0;
         Anio_de_entrada =0;
         Dia_de_salida =0;
         Mes_de_salida =0;
         Anio_de_salida =0;
         Sueldo =0;
         Periodo_de_pago ="";
         Tipo_de_Calculo ="";
         Calcular_Preaviso ="";
         Calcular_vacaciones ="";
         Calcular_cesantia ="";
         Calcular_Salario_Navidad ="";
         Dias_Laborados =0;
         Meses_Laborados =0;
         Anios_Laborados =0;
         Dias_a_Pagar_PREAVISO =0;
         Monto_a_pagar_PREAVISO =0;
         Pago_dias_por_meses_CESANTIA =0;
         MONTO_A_PAGAR_CESANTIA =0;
         Dias_a_Pagar_ANIOS_CESANTIA =0;
         Dias_a_Pagar_MESES_CESANTIA =0;
         Monto_Cesantia_antes_1992 =0;
         Anios_hasta_1992 =0;
         Dias_a_pagar_cesantia_antes_1992 =0;
         Pago_Salario_Navidad =0;
         Dias_de_vacaciones =0;
         Monto_a_pagar_VACACIONES =0;
         Total_a_Recibir =0;
         raptor_prompt_variable_zzyz ="Escriba el Nombre";
         Console.WriteLine(raptor_prompt_variable_zzyz);
         Nombre_Persona= Double.Parse(Console.ReadLine());
         raptor_prompt_variable_zzyz ="Escriba el dia de entrada:";
         Console.WriteLine(raptor_prompt_variable_zzyz);
         Dia_de_entrada= Double.Parse(Console.ReadLine());
         while (!(Dia_de_entrada<=31))
         {
            raptor_prompt_variable_zzyz ="Mensaje de Error; valor invalido: Digite Nuevamente";
            Console.WriteLine(raptor_prompt_variable_zzyz);
            Dia_de_entrada= Double.Parse(Console.ReadLine());
         }
         raptor_prompt_variable_zzyz ="Escriba el mes de entrada:";
         Console.WriteLine(raptor_prompt_variable_zzyz);
         Mes_de_entrada= Double.Parse(Console.ReadLine());
         if (Mes_de_entrada==2)
         {
            if (Dia_de_entrada>29)
            {
               raptor_prompt_variable_zzyz ="Mensaje de Error; valor invalido: Digite Nuevamente";
               Console.WriteLine(raptor_prompt_variable_zzyz);
               Dia_de_entrada= Double.Parse(Console.ReadLine());
            }
            else
            {
            }
         }
         else
         {
         }
         if (Mes_de_entrada==4)
         {
            if (Dia_de_entrada>30)
            {
               raptor_prompt_variable_zzyz ="Mensaje de Error; valor invalido: Digite Nuevamente";
               Console.WriteLine(raptor_prompt_variable_zzyz);
               Dia_de_entrada= Double.Parse(Console.ReadLine());
            }
            else
            {
            }
         }
         else
         {
         }
         if (Mes_de_entrada==6)
         {
            if (Dia_de_entrada>30)
            {
               raptor_prompt_variable_zzyz ="Mensaje de Error; valor invalido: Digite Nuevamente";
               Console.WriteLine(raptor_prompt_variable_zzyz);
               Dia_de_entrada= Double.Parse(Console.ReadLine());
            }
            else
            {
            }
         }
         else
         {
         }
         if (Mes_de_entrada==9)
         {
            if (Dia_de_entrada>30)
            {
               raptor_prompt_variable_zzyz ="Mensaje de Error; valor invalido: Digite Nuevamente";
               Console.WriteLine(raptor_prompt_variable_zzyz);
               Dia_de_entrada= Double.Parse(Console.ReadLine());
            }
            else
            {
            }
         }
         else
         {
         }
         if (Mes_de_entrada==11)
         {
            if (Dia_de_entrada>30)
            {
               raptor_prompt_variable_zzyz ="Mensaje de Error; valor invalido: Digite Nuevamente";
               Console.WriteLine(raptor_prompt_variable_zzyz);
               Dia_de_entrada= Double.Parse(Console.ReadLine());
            }
            else
            {
            }
         }
         else
         {
         }
         while (!(Mes_de_entrada<=12))
         {
            raptor_prompt_variable_zzyz ="Mensaje de Error; Mes invalido Digite Nuevamente";
            Console.WriteLine(raptor_prompt_variable_zzyz);
            Mes_de_entrada= Double.Parse(Console.ReadLine());
         }
         raptor_prompt_variable_zzyz ="Escriba_los cuatro digitos del_anio_de_entrada";
         Console.WriteLine(raptor_prompt_variable_zzyz);
         Anio_de_entrada= Double.Parse(Console.ReadLine());
         raptor_prompt_variable_zzyz ="Escriba el dia de salida:";
         Console.WriteLine(raptor_prompt_variable_zzyz);
         Dia_de_salida= Double.Parse(Console.ReadLine());
         while (!(Dia_de_salida<=31))
         {
            raptor_prompt_variable_zzyz ="Error; dia invalido: Escriba Nuevamente";
            Console.WriteLine(raptor_prompt_variable_zzyz);
            Dia_de_salida= Double.Parse(Console.ReadLine());
         }
         raptor_prompt_variable_zzyz ="Escriba_el_mes_de_salida";
         Console.WriteLine(raptor_prompt_variable_zzyz);
         Mes_de_salida= Double.Parse(Console.ReadLine());
         if (Mes_de_salida==2)
         {
            if (Dia_de_salida>29)
            {
               raptor_prompt_variable_zzyz ="Mensaje de Error; valor invalido: Digite Nuevamente";
               Console.WriteLine(raptor_prompt_variable_zzyz);
               Dia_de_salida= Double.Parse(Console.ReadLine());
            }
            else
            {
            }
         }
         else
         {
         }
         if (Mes_de_salida==4)
         {
            if (Dia_de_salida>30)
            {
               raptor_prompt_variable_zzyz ="Mensaje de Error; valor invalido: Digite Nuevamente";
               Console.WriteLine(raptor_prompt_variable_zzyz);
               Dia_de_salida= Double.Parse(Console.ReadLine());
            }
            else
            {
            }
         }
         else
         {
         }
         if (Mes_de_salida==6)
         {
            if (Dia_de_salida>30)
            {
               raptor_prompt_variable_zzyz ="Mensaje de Error; valor invalido: Digite Nuevamente";
               Console.WriteLine(raptor_prompt_variable_zzyz);
               Dia_de_salida= Double.Parse(Console.ReadLine());
            }
            else
            {
            }
         }
         else
         {
         }
         if (Mes_de_salida==9)
         {
            if (Dia_de_salida>30)
            {
               raptor_prompt_variable_zzyz ="Mensaje de Error; valor invalido: Digite Nuevamente";
               Console.WriteLine(raptor_prompt_variable_zzyz);
               Dia_de_salida= Double.Parse(Console.ReadLine());
            }
            else
            {
            }
         }
         else
         {
         }
         if (Mes_de_salida==11)
         {
            if (Dia_de_salida>30)
            {
               raptor_prompt_variable_zzyz ="Mensaje de Error; valor invalido: Digite Nuevamente";
               Console.WriteLine(raptor_prompt_variable_zzyz);
               Dia_de_salida= Double.Parse(Console.ReadLine());
            }
            else
            {
            }
         }
         else
         {
         }
         while (!(Mes_de_salida<=12))
         {
            raptor_prompt_variable_zzyz ="Error Digite nuevamente el mes de salida";
            Console.WriteLine(raptor_prompt_variable_zzyz);
            Mes_de_salida= Double.Parse(Console.ReadLine());
         }
         raptor_prompt_variable_zzyz ="Escriba_el_anio_de_salida_de 4_digitos:";
         Console.WriteLine(raptor_prompt_variable_zzyz);
         Anio_de_salida= Double.Parse(Console.ReadLine());
         Dias_Laborados =Dia_de_salida-Dia_de_entrada;
         Meses_Laborados =Mes_de_salida-Mes_de_entrada;
         Anios_Laborados =Anio_de_salida-Anio_de_entrada;
         raptor_prompt_variable_zzyz ="Digite el sueldo devengado durante el último año laborado:";
         Console.WriteLine(raptor_prompt_variable_zzyz);
         Sueldo= Double.Parse(Console.ReadLine());
         raptor_prompt_variable_zzyz ="Indique el tipo de cálculo: Ordinario o Intermitente";
         Console.WriteLine(raptor_prompt_variable_zzyz);
         Tipo_de_Calculo= Double.Parse(Console.ReadLine());
         if (Tipo_de_Calculo=="Ordinario")
         {
            raptor_prompt_variable_zzyz ="Indique el periodo de pago; Diario, Semanal, Quincenal o Mensual";
            Console.WriteLine(raptor_prompt_variable_zzyz);
            Periodo_de_pago= Double.Parse(Console.ReadLine());
            if (Periodo_de_pago=="Diario")
            {
               Sueldo =Sueldo*23,83;
            }
            else
            {
            }
            if (Periodo_de_pago=="Semanal")
            {
               Sueldo =Sueldo*4,33;
            }
            else
            {
            }
            if (Periodo_de_pago=="Quincenal")
            {
               Sueldo =Sueldo*2;
            }
            else
            {
            }
            if (Periodo_de_pago=="Mensual")
            {
               Sueldo =Sueldo;
            }
            else
            {
            }
            raptor_prompt_variable_zzyz ="¿Calcular Preaviso? Si/No";
            Console.WriteLine(raptor_prompt_variable_zzyz);
            Calcular_Preaviso= Double.Parse(Console.ReadLine());
            if (Calcular_Preaviso=="Si")
            {
               Salario_Diario =Sueldo/23,83;
               if (Anios_Laborados>=1)
               {
                  Dias_a_Pagar_PREAVISO =28;
               }
               else
               {
                  if (Meses_Laborados>=3 && Meses_Laborados<=5)
                  {
                     Dias_a_Pagar_PREAVISO =7;
                  }
                  else
                  {
                  }
                  if (Meses_Laborados>=6 && Meses_Laborados<=11)
                  {
                     Dias_a_Pagar_PREAVISO =14;
                  }
                  else
                  {
                  }
               }
               Monto_a_pagar_PREAVISO =Salario_Diario*Dias_a_Pagar_PREAVISO;
            }
            else
            {
            }
         }
         else
         {
            if (Tipo_de_Calculo=="Intermitente")
            {
               if (Periodo_de_pago=="Diario")
               {
                  Sueldo =Sueldo*26;
               }
               else
               {
               }
               if (Periodo_de_pago=="Semanal")
               {
                  Sueldo =Sueldo*4,33;
               }
               else
               {
               }
               if (Periodo_de_pago==" Quincenal")
               {
                  Sueldo =Sueldo*2;
               }
               else
               {
               }
               if (Periodo_de_pago=="Mensual")
               {
                  Sueldo =Sueldo;
               }
               else
               {
               }
            }
            else
            {
            }
            raptor_prompt_variable_zzyz ="Indique el periodo de pago; Diario, Semanal, Quincenal o Mensual";
            Console.WriteLine(raptor_prompt_variable_zzyz);
            Periodo_de_pago= Double.Parse(Console.ReadLine());
            raptor_prompt_variable_zzyz ="¿Calcular Preaviso?: Si/No";
            Console.WriteLine(raptor_prompt_variable_zzyz);
            Calcular_Preaviso= Double.Parse(Console.ReadLine());
            if (Calcular_Preaviso=="Si")
            {
               Salario_Diario =Sueldo/26;
               if (Anios_Laborados>=1)
               {
                  Dias_a_Pagar_PREAVISO =28;
               }
               else
               {
                  if (Meses_Laborados>=3 && Meses_Laborados<=5)
                  {
                     Dias_a_Pagar_PREAVISO =7;
                  }
                  else
                  {
                  }
                  if (Meses_Laborados>=6 && Meses_Laborados<=11)
                  {
                     Dias_a_Pagar_PREAVISO =14;
                  }
                  else
                  {
                  }
               }
               Monto_a_pagar_PREAVISO =Salario_Diario*Dias_a_Pagar_PREAVISO;
            }
            else
            {
            }
         }
         raptor_prompt_variable_zzyz ="¿Calcular Cesantía? Si/No";
         Console.WriteLine(raptor_prompt_variable_zzyz);
         Calcular_cesantia= Double.Parse(Console.ReadLine());
         if (Calcular_cesantia=="Si")
         {
            if (Anio_de_entrada<1992)
            {
               if (Mes_de_entrada<7)
               {
                  Anios_hasta_1992 =1992-Anio_de_entrada;
                  while (!(Anios_hasta_1992==0))
                  {
                     Anios_hasta_1992 =Anios_hasta_1992-1;
                     Dias_a_pagar_cesantia_antes_1992 =Dias_a_pagar_cesantia_antes_1992+15;
                  }
                  Monto_Cesantia_antes_1992 =Salario_Diario*Dias_a_pagar_cesantia_antes_1992;
               }
               else
               {
               }
            }
            else
            {
            }
            if (Anios_Laborados<1)
            {
               if (Meses_Laborados>=3 && Meses_Laborados<=5)
               {
                  Dias_a_Pagar_MESES_CESANTIA =6;
               }
               else
               {
               }
               if (Meses_Laborados>=6 && Meses_Laborados<=11)
               {
                  Dias_a_Pagar_MESES_CESANTIA =13;
               }
               else
               {
               }
            }
            else
            {
               if (Meses_Laborados>=3 && Meses_Laborados<=5)
               {
                  Dias_a_Pagar_MESES_CESANTIA =6;
               }
               else
               {
               }
               if (Meses_Laborados>=6 && Meses_Laborados<=11)
               {
                  Dias_a_Pagar_ANIOS_MESES_CESANTIA =13;
               }
               else
               {
               }
               if (Anios_Laborados<=5)
               {
                  while (!(Anios_Laborados==1))
                  {
                     Anios_Laborados =Anios_Laborados-1;
                     Dias_a_Pagar_ANIOS_CESANTIA =Dias_a_Pagar_ANIOS_CESANTIA+21;
                  }
               }
               else
               {
               }
               if (Anios_Laborados>5)
               {
                  while (!(Anios_Laborados==1))
                  {
                     Anios_Laborados =Anios_Laborados-1;
                     Dias_a_Pagar_ANIOS_CESANTIA =Dias_a_Pagar_ANIOS_CESANTIA+23;
                  }
               }
               else
               {
               }
            }
            MONTO_A_PAGAR_CESANTIA =(Dias_a_Pagar_ANIOS_CESANTIA+Dias_a_Pagar_MESES_CESANTIA)*Salario_Diario;
         }
         else
         {
         }
         raptor_prompt_variable_zzyz ="¿Calcular Vacaciones? Si/No";
         Console.WriteLine(raptor_prompt_variable_zzyz);
         Calcular_vacaciones= Double.Parse(Console.ReadLine());
         if (Calcular_vacaciones=="Si")
         {
            Anios_Laborados =Anio_de_salida-Anio_de_entrada;
            if (Anios_Laborados>=1)
            {
               Dias_de_vacaciones =14;
               if (Anios_Laborados>=5)
               {
                  Dias_de_vacaciones =18;
               }
               else
               {
               }
            }
            else
            {
               if (Meses_Laborados==5)
               {
                  Dias_de_vacaciones =6;
               }
               else
               {
               }
               if (Meses_Laborados==6)
               {
                  Dias_de_vacaciones =7;
               }
               else
               {
               }
               if (Meses_Laborados==7)
               {
                  Dias_de_vacaciones =8;
               }
               else
               {
               }
               if (Meses_Laborados==8)
               {
                  Dias_de_vacaciones =9;
               }
               else
               {
               }
               if (Meses_Laborados==9)
               {
                  Dias_de_vacaciones =10;
               }
               else
               {
               }
               if (Meses_Laborados==10)
               {
                  Dias_de_vacaciones =11;
               }
               else
               {
               }
               if (Meses_Laborados==11)
               {
                  Dias_de_vacaciones =12;
               }
               else
               {
               }
            }
            Monto_a_pagar_VACACIONES =Salario_Diario*Dias_de_vacaciones;
         }
         else
         {
         }
         raptor_prompt_variable_zzyz ="¿Incluir salario de navidad? Si/No";
         Console.WriteLine(raptor_prompt_variable_zzyz);
         Calcular_Salario_Navidad= Double.Parse(Console.ReadLine());
         if (Calcular_Salario_Navidad=="Si")
         {
            if (Meses_Laborados>=1)
            {
               if (Periodo_de_pago=="Diario")
               {
                  Sueldo =Sueldo*23,83;
               }
               else
               {
               }
               if (Periodo_de_pago=="Semanal")
               {
                  Sueldo =Sueldo*4,33;
               }
               else
               {
               }
               if (Periodo_de_pago=="Quincenal")
               {
                  Sueldo =Sueldo*2;
               }
               else
               {
               }
               if (Periodo_de_pago=="Mensual")
               {
                  Sueldo =Sueldo;
               }
               else
               {
               }
               Pago_Salario_Navidad =(Sueldo*Meses_Laborados)/12;
            }
            else
            {
            }
         }
         else
         {
         }
         Total_a_Recibir =Monto_a_pagar_PREAVISO+MONTO_A_PAGAR_CESANTIA+Monto_cesantia_antes_1992+Monto_a_pagar_VACACIONES+Pago_Salario_Navidad;
         Console.WriteLine(Nombre_Persona+Sueldo+Periodo_de_pago+Dias_Laborados+Meses_Laborados+Anios_Laborados+Monto_a_pagar_PREAVISO+MONTO_A_PAGAR_CESANTIA+Monto_cesantia_antes_1992+Monto_a_pagar_VACACIONES+Pago_Salario_Navidad);
         Console.WriteLine(Total_a_Recibir);
      }
   }
}
