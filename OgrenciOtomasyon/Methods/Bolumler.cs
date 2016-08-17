using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Bolumler
    {
    [Key]
    public int ID { get; set; }
    public String BolumAdi { get; set; }

    public static List<Bolumler> GetRecords()
    {


       
        using (var db = new DbConnect())
        {
            return db.Bolumlers.ToList();
        }
    }


}
