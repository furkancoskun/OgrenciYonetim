using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciOtomasyon.Methods
{
    public class KatılımID
    {
        [Key]
        public int KatilimID { get; set; }
        public int EgitimID { get; set; }
        public int OgrenciID { get; set; }
        public int Hafta { get; set; }
        public bool KatilimDurumu { get; set; }


        public static void Insert(KatılımID Katılım)
        {
            using (var db = new DbConnect())
            {
                db.Katılıms.Add(Katılım);
                db.SaveChanges();
            }
        }
    }
}
