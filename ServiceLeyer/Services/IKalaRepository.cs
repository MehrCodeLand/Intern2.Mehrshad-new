using DataLeyer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLeyer.Services
{
    public interface IKalaRepository
    {
        KalaEditVm FindKala(int kalaID);
        int EditKala(KalaEditVm kalaEdit);
    }
}
