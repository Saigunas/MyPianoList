using MyPianoList.Application.Interfaces;
using MyPianoList.Domain;
using MyPianoList.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPianoList.Application.Services
{
    public class PianoSheetTagService : IPianoSheetTagService
    {
        private readonly IPianoSheetTagRepository _pianoSheetTagRepository;

        public PianoSheetTagService(IPianoSheetTagRepository pianoSheetTagRepository)
        {
            _pianoSheetTagRepository = pianoSheetTagRepository;
        }

        public async Task SetPianoSheetTags(int pianoSheetId, IEnumerable<int> tagIds)
        {
            await _pianoSheetTagRepository.SetPianoSheetTags(pianoSheetId, tagIds);
        }
    }
}
