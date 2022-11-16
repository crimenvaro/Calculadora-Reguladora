using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DAL.Entidades;

namespace BLL.Logica
{
    public class BLL_Calculadora
    {
        public void Verificar_Operación(ref DAL_Calculadora Obj_Calcu_Dal)
        {
            Obj_Calcu_Dal.sObservacion = "";

            if (Regex.IsMatch(Obj_Calcu_Dal.sNumero1, @"[A-Za-z]") == true)
            {
                Obj_Calcu_Dal.sObservacion = "La primer expresion tiene una letra";
            }
            if (Regex.IsMatch(Obj_Calcu_Dal.sNumero1, @"\s") == true)
            {
                Obj_Calcu_Dal.sObservacion = "La primer expresion es un espacio en blanco";
            }
            if (Regex.IsMatch(Obj_Calcu_Dal.sNumero1, @"\W") == true)
            {
                Obj_Calcu_Dal.sObservacion = "La primer expresion tiene un simbolo";
            }
            if (Obj_Calcu_Dal.sNumero1 == "")
            {
                Obj_Calcu_Dal.sObservacion = "La primer expresion está vacia";
            }



            if (Regex.IsMatch(Obj_Calcu_Dal.sNumero2, @"[A-Za-z]") == true)
            {
                Obj_Calcu_Dal.sObservacion = "La segunda expresion tiene una letra";
            }
            if (Regex.IsMatch(Obj_Calcu_Dal.sNumero2, @"\s") == true)
            {
                Obj_Calcu_Dal.sObservacion = "La segunda expresion es un espacio en blanco";
            }
            if (Regex.IsMatch(Obj_Calcu_Dal.sNumero2, @"\W") == true)
            {
                Obj_Calcu_Dal.sObservacion = "La segunda expresion tiene un simbolo";
            }
            if (Obj_Calcu_Dal.sNumero2 == "")
            {
                Obj_Calcu_Dal.sObservacion = "La segunda expresion está vacia";
            }



            if (Regex.IsMatch(Obj_Calcu_Dal.sNumero1, @"[A-Za-z]") == true && Regex.IsMatch(Obj_Calcu_Dal.sNumero2, @"[A-Za-z]") == true)
            {
                Obj_Calcu_Dal.sObservacion = "Las 2 expresiones contienen letras";
            }
            if (Regex.IsMatch(Obj_Calcu_Dal.sNumero1, @"[A-Za-z]") == true && Regex.IsMatch(Obj_Calcu_Dal.sNumero2, @"\s") == true)
            {
                Obj_Calcu_Dal.sObservacion = "La primer expresion tiene una letra y La segunda expresion es un espacio en blanco";
            }
            if (Regex.IsMatch(Obj_Calcu_Dal.sNumero1, @"[A-Za-z]") == true && Regex.IsMatch(Obj_Calcu_Dal.sNumero2, @"\W") == true)
            {
                Obj_Calcu_Dal.sObservacion = "La primer expresion tiene una letra y La segunda expresion tiene un simbolo";
            }
            if (Regex.IsMatch(Obj_Calcu_Dal.sNumero1, @"[A-Za-z]") == true && Obj_Calcu_Dal.sNumero2 == "")
            {
                Obj_Calcu_Dal.sObservacion = "La primer expresion tiene una letra y La segunda expresion está vacia";
            }



            if (Regex.IsMatch(Obj_Calcu_Dal.sNumero1, @"\s") == true && Regex.IsMatch(Obj_Calcu_Dal.sNumero2, @"[A-Za-z]") == true)
            {
                Obj_Calcu_Dal.sObservacion = "La primer expresion es un espacio en blanco y La segunda expresion tiene una letra";
            }
            if (Regex.IsMatch(Obj_Calcu_Dal.sNumero1, @"\s") == true && Regex.IsMatch(Obj_Calcu_Dal.sNumero2, @"\s") == true)
            {
                Obj_Calcu_Dal.sObservacion = "Las 2 expresiones tienen el espacio en blanco";
            }
            if (Regex.IsMatch(Obj_Calcu_Dal.sNumero1, @"\s") == true && Regex.IsMatch(Obj_Calcu_Dal.sNumero2, @"\W") == true)
            {
                Obj_Calcu_Dal.sObservacion = "La primer expresion es un espacio en blanco y La segunda expresion tiene un simbolo";
            }
            if (Regex.IsMatch(Obj_Calcu_Dal.sNumero1, @"\s") == true && Obj_Calcu_Dal.sNumero2 == "")
            {
                Obj_Calcu_Dal.sObservacion = "La primer expresion es un espacio en blanco y La segunda expresion está vacia";
            }



            if (Regex.IsMatch(Obj_Calcu_Dal.sNumero1, @"\W") == true && Regex.IsMatch(Obj_Calcu_Dal.sNumero2, @"[A-Za-z]") == true)
            {
                Obj_Calcu_Dal.sObservacion = "La primer expresion tiene un simbolo y La segunda expresion tiene una letra";
            }
            if (Regex.IsMatch(Obj_Calcu_Dal.sNumero1, @"\W") == true && Regex.IsMatch(Obj_Calcu_Dal.sNumero2, @"\s") == true)
            {
                Obj_Calcu_Dal.sObservacion = "La primer expresion tiene un simbolo y La segunda expresion es un espacio en blanco";
            }
            if (Regex.IsMatch(Obj_Calcu_Dal.sNumero1, @"\W") == true && Regex.IsMatch(Obj_Calcu_Dal.sNumero2, @"\W") == true)
            {
                Obj_Calcu_Dal.sObservacion = "Las 2 expresiones tienen son simbolos";
            }
            if (Regex.IsMatch(Obj_Calcu_Dal.sNumero1, @"\W") == true && Obj_Calcu_Dal.sNumero2 == "")
            {
                Obj_Calcu_Dal.sObservacion = "La primer expresion tiene un simbolo y La segunda expresion está vacia";
            }



            if (Obj_Calcu_Dal.sNumero1 == "" && Regex.IsMatch(Obj_Calcu_Dal.sNumero2, @"[A-Za-z]") == true)
            {
                Obj_Calcu_Dal.sObservacion = "La primer expresion está vacia y La segunda expresion tiene una letra";
            }
            if (Obj_Calcu_Dal.sNumero1 == "" && Regex.IsMatch(Obj_Calcu_Dal.sNumero2, @"\s") == true)
            {
                Obj_Calcu_Dal.sObservacion = "La primer expresion está vacia y La segunda expresion es un espacio en blanco";
            }
            if (Obj_Calcu_Dal.sNumero1 == "" && Regex.IsMatch(Obj_Calcu_Dal.sNumero2, @"\W") == true)
            {
                Obj_Calcu_Dal.sObservacion = "La primer expresion está vacia y La segunda expresion tiene un simbolo";
            }
            if (Obj_Calcu_Dal.sNumero1 == "" && Obj_Calcu_Dal.sNumero2 == "")
            {
                Obj_Calcu_Dal.sObservacion = "Las 2 expresiones estan vacias";
            }
        }
    }
}
