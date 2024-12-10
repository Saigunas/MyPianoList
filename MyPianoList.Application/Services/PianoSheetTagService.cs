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
        public IEnumerable<PianoSheetTag> GetAll()
        {
            var pianoSheetTags = _pianoSheetTagRepository.GetAll();
            return pianoSheetTags;
        }

        public async Task<PianoSheetTag> GetByIdAsync(int id)
        {
            var task = (await _pianoSheetTagRepository.GetByIdAsync(id));
            if (task == null)
            {
                throw new KeyNotFoundException();
            }
            return task;
        }

        public async Task CreateAsync(PianoSheetTag pianoSheetTag)
        {
            await _pianoSheetTagRepository.AddAsync(pianoSheetTag);
            await _pianoSheetTagRepository.SaveAsync();
            return;
        }

        public async Task<PianoSheetTag> UpdateAsync(int id, PianoSheetTag pianoSheetTag)
        {

            var isUpdated = await _pianoSheetTagRepository.UpdateAsync(id, pianoSheetTag);
            if (!isUpdated)
            {
                throw new KeyNotFoundException();
            }

            await _pianoSheetTagRepository.SaveAsync();

            return pianoSheetTag;
        }

        public async Task RemoveByIdAsync(int id)
        {
            await _pianoSheetTagRepository.RemoveByIdAsync(id);
            await _pianoSheetTagRepository.SaveAsync();
        }
    }
}
