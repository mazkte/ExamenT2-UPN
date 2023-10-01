using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio
{
    internal class GestorMedicamento
    {

        List<Medicamento> v_listaMedicamentos = new List<Medicamento>();

        public GestorMedicamento()
        {
            CargaPrevia();
        }

        private void CargaPrevia()
        {

            v_listaMedicamentos.Add(new Medicamento("1001", "PARACETAMOL 1 g",100,1.0));
            v_listaMedicamentos.Add(new Medicamento("1002", "PARACETAMOL 500 mg", 100, 1.0));
            v_listaMedicamentos.Add(new Medicamento("1003", "IBUPROFENO 800 mg", 100, 1.0));
            v_listaMedicamentos.Add(new Medicamento("1004", "RANITIDINA 300 mg", 100, 1.0));
            v_listaMedicamentos.Add(new Medicamento("1005", "SERTRALINA 50 mg", 100, 1.0));
            v_listaMedicamentos.Add(new Medicamento("1006", "PREDNISONA 70", 100, 1.0));
            v_listaMedicamentos.Add(new Medicamento("1007", "SALBUTAMOL 2 mg/5 ml", 100, 1.0));
            v_listaMedicamentos.Add(new Medicamento("1008", "NAPROXENO 500 mg", 100, 1.0));
            v_listaMedicamentos.Add(new Medicamento("1009", "AMITRIPTILINA 25 mg", 100, 1.0));
            v_listaMedicamentos.Add(new Medicamento("1010", "AMOXICILINA 500 mg", 100, 1.0));
            v_listaMedicamentos.Add(new Medicamento("1011", "ATORVASTATINA 20mg", 100, 0.5));
            v_listaMedicamentos.Add(new Medicamento("1012", "PARACETAMOL 1 g", 100, 1.0));
            v_listaMedicamentos.Add(new Medicamento("1013", "PARACETAMOL 500 mg", 100, 1.0));
            v_listaMedicamentos.Add(new Medicamento("1014", "IBUPROFENO 800 mg", 100, 1.0));
            v_listaMedicamentos.Add(new Medicamento("1015", "RANITIDINA 300 mg", 100, 1.0));
            v_listaMedicamentos.Add(new Medicamento("1016", "SERTRALINA 50 mg", 100, 1.0));
            v_listaMedicamentos.Add(new Medicamento("1017", "PREDNISONA 70", 100, 1.0));
            v_listaMedicamentos.Add(new Medicamento("1017", "SALBUTAMOL 2 mg/5 ml", 100, 1.0));
            v_listaMedicamentos.Add(new Medicamento("1019", "NAPROXENO 500 mg", 100, 1.0));
            v_listaMedicamentos.Add(new Medicamento("1020", "AMITRIPTILINA 25 mg", 100, 1.0));
            v_listaMedicamentos.Add(new Medicamento("1021", "AMOXICILINA 500 mg", 100, 1.0));
            v_listaMedicamentos.Add(new Medicamento("1022", "ATORVASTATINA 20mg", 100, 0.5));
        }
        


        public bool Registrar(Medicamento medicamento)
        {
            v_listaMedicamentos.Add(medicamento);
            return true;
        }


        public Medicamento[] Listar()
        {
            return v_listaMedicamentos.ToArray();
        }

        public Medicamento[] BuscarPorNombre(string v_nombre)
        {

           List<Medicamento> v_med_encontrados = new List<Medicamento>();


           foreach (Medicamento v_med in v_listaMedicamentos)
            {
                if (v_med.Nombre.Contains(v_nombre.ToUpper()))
                {
                    v_med_encontrados.Add(v_med);
                }
            }

            return v_med_encontrados.ToArray();
        }

        public Medicamento[] OrdenarPorNombre()
        {

            Medicamento[] v_sortedArray = v_listaMedicamentos.ToArray();

            Medicamento aux;

            for (int i = 1; i < v_sortedArray.Length; i++)
            {
                for (int j = v_sortedArray.Length - 1; j >= i; j--)
                {
                    if (v_sortedArray[j - 1].Nombre.CompareTo(v_sortedArray[j]. Nombre) == 1)
                    {
                        aux = v_sortedArray[j - 1];
                        v_sortedArray[j - 1] = v_sortedArray[j];
                        v_sortedArray[j] =  aux;
                    }
                }
            }

            return v_sortedArray;
        }

        public Medicamento BuscarPorCodigo(string v_codigo)
        {

            List<Medicamento> v_med_encontrados = new List<Medicamento>();


            foreach (Medicamento v_med in v_listaMedicamentos)
            {
                if (v_med.Codigo.Equals(v_codigo, StringComparison.OrdinalIgnoreCase))
                {
                    v_med_encontrados.Add(v_med);
                    return v_med;
                }
            }

            return default(Medicamento);
        }

        public bool Eliminar(Medicamento medicamento)
        {
            return v_listaMedicamentos.Remove(medicamento);
                
        }
    }
}
