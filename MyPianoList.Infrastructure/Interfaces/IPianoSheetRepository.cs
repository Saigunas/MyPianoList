using MyPianoList.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPianoList.Infrastructure.Interfaces
{
    public interface IPianoSheetRepository : IRepository<PianoSheet>
    {
    }
}
