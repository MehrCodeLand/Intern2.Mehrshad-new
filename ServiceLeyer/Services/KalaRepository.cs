using DataLeyer.MyDbContext;
using DataLeyer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLeyer.Services
{
    public class KalaRepository : IKalaRepository
    {

        public KalaEditVm FindKala( int kalaID)
        {
            using( var db = new MyDb())
            {
                var resultKala = db.Kalas.FirstOrDefault(x => x.KalaID == kalaID);
                if(resultKala != null)
                {
                    return new KalaEditVm()
                    {
                        KalaID = kalaID,
                        SerialNumber = resultKala.SerialNumber,
                        Name = resultKala.Name,
                        CategoryID = (int)resultKala.CategoryID
                    };
                }
            }

            return null;
        }

        public int EditKala( KalaEditVm kalaEdit)
        {
            using( var db = new MyDb())
            {
                var kala = db.Kalas.FirstOrDefault(x => x.KalaID ==kalaEdit.KalaID);

                kala.SerialNumber = kalaEdit.SerialNumber;
                kala.Name = kalaEdit.Name;
                kala.CategoryID = kalaEdit.CategoryID;

                db.SaveChanges();

                return 100;
            }
            return -100 ;
        }
    }
}
