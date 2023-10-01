using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenT2
{
    internal class GestorMedicamento
    {

        List<Medicamento> listaMedicamentos = new List<Medicamento>();

        public GestorMedicamento()
        {
            CargaPrevia();
        }

        private void CargaPrevia()
        {

            listaMedicamentos.Add(new Medicamento("00001", "PARACETAMOL 1 g",100,1.0));
            listaMedicamentos.Add(new Medicamento("00002", "PARACETAMOL 500 mg", 100, 1.0));
            listaMedicamentos.Add(new Medicamento("00003", "IBUPROFENO 800 mg", 100, 1.0));
            listaMedicamentos.Add(new Medicamento("00004", "RANITIDINA 300 mg", 100, 1.0));
            listaMedicamentos.Add(new Medicamento("00005", "SERTRALINA 50 mg", 100, 1.0));
            listaMedicamentos.Add(new Medicamento("00006", "PREDNISONA 70", 100, 1.0));
            listaMedicamentos.Add(new Medicamento("00007", "SALBUTAMOL 2 mg/5 ml", 100, 1.0));
            listaMedicamentos.Add(new Medicamento("00008", "NAPROXENO 500 mg", 100, 1.0));
            listaMedicamentos.Add(new Medicamento("00009", "AMITRIPTILINA 25 mg", 100, 1.0));
            listaMedicamentos.Add(new Medicamento("00010", "AMOXICILINA 500 mg", 100, 1.0));
            listaMedicamentos.Add(new Medicamento("00011", "ATORVASTATINA 20mg", 100, 0.5));
        }
        


        public bool Registrar(Medicamento medicamento)
        {
            listaMedicamentos.Add(medicamento);
            return true;
        }


        public List<Medicamento> Listar()
        {
            return listaMedicamentos;
        }

        public Medicamento BuscarPorNombre(string v_nombre)
        {

            return listaMedicamentos
                .Find(medicamento => medicamento.Nombre.Equals(v_nombre , StringComparison.OrdinalIgnoreCase));
        }

    }
}
