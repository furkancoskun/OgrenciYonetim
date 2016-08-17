using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public  class Okullar
    {
    [Key]
    public int OkulID { get; set; }
    public String Adi { get; set; }
    public static List<Okullar> GetRecords()
    {
        using (var db = new DbConnect() )
        {
            return db.Okullars.ToList();
        }
    }

}
