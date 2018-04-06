using System;
using System.IO;
using System.Text;

namespace Proyecto Aprobado Estudiantes que presentan examen de fisica RICARDO PEÑA
{
   public class main_class
   {
      static System.Random random_generator = new System.Random();
      public static void Main(string[] args)
      {
         string raptor_prompt_variable_zzyz;
         ?? contador;
         ?? calcular_calificaciones;
         ?? cantidad_estudiantes;
         ?? cantidad_estudiantes_calificacion_80_a_mas;
         ?? contador_de_estudiantes;
         ?? cantidad_estudiantes_calificacion_menor_50;
         ?? cantidad_estudiantes_calificacion_de70_menorque_80;
         ?? posicion_en_arreglo;
         ?? calificación_obtenida;
         ?? cantidad_estudiantes_calificacion_mayor_50_y_menor_que_80;
         ??[] arreglo = new ??[??+1];
      
         Cantidad_estudiantes =0;
         contador_de_estudiantes =0;
         Calcular_calificaciones =0;
         Calificación_Obtenida =0;
         Cantidad_estudiantes_calificacion_menor_50 =0;
         Posicion_en_arreglo =0;
         Contador =0;
         Cantidad_estudiantes_calificacion_mayor_50_y_menor_que_80 =0;
         Cantidad_estudiantes_calificacion_de70_menorque_80 =0;
         Cantidad_estudiantes_calificacion_80_a_mas =0;
         raptor_prompt_variable_zzyz ="Digite la cantidad de estudiantes";
         Console.WriteLine(raptor_prompt_variable_zzyz);
         contador_de_estudiantes= Double.Parse(Console.ReadLine());
         Cantidad_estudiantes =1;
         Console.WriteLine(contador_de_estudiantes);
         while (!(Cantidad_estudiantes>contador_de_estudiantes))
         {
            raptor_prompt_variable_zzyz ="Inserte la calificacion el estudiante No."+Cantidad_estudiantes;
            Console.WriteLine(raptor_prompt_variable_zzyz);
            Calificación_Obtenida= Double.Parse(Console.ReadLine());
            Posicion_en_arreglo =Cantidad_estudiantes;
            Arreglo[Posicion_en_arreglo] = Calificación_Obtenida;
            Cantidad_estudiantes =Cantidad_estudiantes+1;
         }
         raptor_prompt_variable_zzyz ="Revisar calificaciones: Si/No";
         Console.WriteLine(raptor_prompt_variable_zzyz);
         Calcular_calificaciones= Double.Parse(Console.ReadLine());
         if (Calcular_calificaciones=="Si")
         {
            Cantidad_estudiantes =1;
            while (!(Cantidad_estudiantes>contador_de_estudiantes))
            {
               Posicion_en_arreglo =Cantidad_estudiantes;
               Calificación_Obtenida =Arreglo(Posicion_en_arreglo);
               if (Calificación_Obtenida>50)
               {
               }
               else
               {
                  cantidad_estudiantes_calificacion_menor_50 =cantidad_estudiantes_calificacion_menor_50+1;
               }
               if (Calificación_Obtenida==80)
               {
                  Calificación_Obtenida =Calificación_Obtenida+1;
               }
               else
               {
               }
               if (Calificación_Obtenida>80)
               {
                  cantidad_estudiantes_calificacion_80_a_mas =cantidad_estudiantes_calificacion_80_a_mas+1;
               }
               else
               {
               }
               if (Calificación_Obtenida>50)
               {
                  if (Calificación_Obtenida<80)
                  {
                     Cantidad_estudiantes_calificacion_mayor_50_y_menor_que_80 =Cantidad_estudiantes_calificacion_mayor_50_y_menor_que_80+1;
                  }
                  else
                  {
                  }
               }
               else
               {
               }
               if (Calificación_Obtenida==70)
               {
                  Calificación_Obtenida =Calificación_Obtenida+1;
               }
               else
               {
               }
               if (Calificación_Obtenida>70)
               {
                  if (Calificación_Obtenida<80)
                  {
                     Cantidad_estudiantes_calificacion_de70_menorque_80 =Cantidad_estudiantes_calificacion_de70_menorque_80+1;
                  }
                  else
                  {
                  }
               }
               else
               {
               }
               Cantidad_estudiantes =Cantidad_estudiantes+1;
            }
         }
         else
         {
            if (Calcular_calificaciones=="No")
            {
            }
            else
            {
            }
         }
         Console.WriteLine(cantidad_estudiantes_calificacion_menor_50);
         Console.WriteLine(cantidad_estudiantes_calificacion_80_a_mas);
         Console.WriteLine(Cantidad_estudiantes_calificacion_mayor_50_y_menor_que_80);
         Console.WriteLine(Cantidad_estudiantes_calificacion_de70_menorque_80);
      }
   }
}
