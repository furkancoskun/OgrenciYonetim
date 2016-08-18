using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public  class Ogrenciler
    {
    [Key]
    public int OgrenciId { get; set; }
    public String Adi { get; set; }
    public String Soyadi { get; set; }
    public int OkulID { get; set; }
    public int BolumID { get; set; }

    [StringLength(11), Column(TypeName = "char")]
    public String  TelefonNo { get; set; }

    public String Mail { get; set; }
    public int SinifID { get; set; }
    public int EgitimID { get; set; }

    public static void Insert(Ogrenciler ogrenci)
    {
        using (var db = new DbConnect())
        {
            db.Ogrencilers.Add(ogrenci);
            db.SaveChanges();
        }
    }
    public static List<Ogrenciler> GetRecords()
    {
        using (var db= new DbConnect())
        {
         return   db.Ogrencilers.ToList();
            
        }
    }

 


}

