using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Egitimler
    {
    [Key]
    public int EgitimID { get; set; }
    [StringLength(50)]
    public String EgitimAdi { get; set; }
    [StringLength(50)]
    public String EgitimKonu { get; set; }
    [StringLength(50)]
    public String Egitmen { get; set; }
    public int Sure { get; set; }
    public DateTime Baslangic { get; set; }
    public DateTime Bitis { get; set; }
    [StringLength(50)]
    public String Turu { get; set; }

    public static List<Egitimler> GetRecords()
    {
        using (var db = new DbConnect())
        {
            return db.Egitimlers.ToList();
        }
    }

    public static void Insert(Egitimler egitim)
    {
        using (var db = new DbConnect())
        {
            db.Egitimlers.Add(egitim);
            db.SaveChanges();

        

        }
    }



}
