using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryTP4
{
    class KodePos
    {
        private Dictionary<string, string> kodePosTable = new Dictionary<string, string>
        {
            {"Batununggal", "40266"},
            {"Kujangsari", "40287"},
            {"Mengger", "40267"},
            {"Wates", "40256"},
            {"Cijawura", "40287" },
            {"Jatisari", "40286"},
            {"Margasari", "40286"},
            {"Sekejati", "40286"},
            {"Kebonwaru", "40272"},
            {"Maleer", "40274"},
            {"Samoja", "40273"}
        };

        public string GetKodePos(string kelurahan)
        {
            if (kodePosTable.ContainsKey(kelurahan))
            {
                return $"Kode pos untuk kelurahan {kelurahan} adalah {kodePosTable[kelurahan]}";
            }
            else
            {
                return "Kode Pos dan Kota tidak Ditemukan";
            }
        }

    }
}
