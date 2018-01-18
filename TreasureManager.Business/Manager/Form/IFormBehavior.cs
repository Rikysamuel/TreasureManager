using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreasureManager.Business.Manager.Form
{
    public interface IFormBehavior
    {
        void ExportToCSv(string fileName);
    }
}
