﻿using MyPianoList.Application.Exceptions;
using MyPianoList.Application.Interfaces;
using MyPianoList.Domain;
using MyPianoList.Infrastructure.DTOs;
using MyPianoList.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPianoList.Application.Services
{
    public class PianoSheetService : IPianoSheetService
    {
        private readonly IPianoSheetRepository _pianoSheetRepository;

        public PianoSheetService(IPianoSheetRepository pianoSheetRepository)
        {
            _pianoSheetRepository = pianoSheetRepository;
        }
        public IEnumerable<PianoSheet> GetAll()
        {
            var pianoSheets = _pianoSheetRepository.GetAll();
            return pianoSheets;
        }


        public async Task<List<PianoSheetDetailsDto>> GetAllWithDetails(string userId)
        {
            var pianoSheets = await _pianoSheetRepository.GetPianoSheetsWithDetailsAsync(userId);
            if (pianoSheets == null)
            {
                throw new NoRowsReturnedException();
            }
            return pianoSheets;
        }

        public async Task<PianoSheet> GetByIdWithTagsAsync(int id)
        {
            var pianoSheets = await _pianoSheetRepository.GetByIdWithTagsAsync(id);
            if (pianoSheets == null)
            {
                throw new IdNotFoundException();
            }
            return pianoSheets;
        }


        public async Task<PianoSheet> GetByIdAsync(int id)
        {
            var pianoSheets = (await _pianoSheetRepository.GetByIdAsync(id));
            if (pianoSheets == null)
            {
                throw new IdNotFoundException();
            }
            return pianoSheets;
        }

        public async Task CreateAsync(PianoSheet pianoSheet)
        {
            await _pianoSheetRepository.AddAsync(pianoSheet);
            await _pianoSheetRepository.SaveAsync();
            return;
        }
        public async Task<PianoSheet> CreateAndSaveAsync(PianoSheet pianoSheet)
        {
            return await _pianoSheetRepository.AddAndSaveAsync(pianoSheet);
        }

        public async Task<PianoSheet> UpdateAsync(int id, PianoSheet pianoSheet)
        {

            var isUpdated = await _pianoSheetRepository.UpdateAsync(id, pianoSheet);
            if (!isUpdated)
            {
                throw new KeyNotFoundException();
            }

            await _pianoSheetRepository.SaveAsync();

            return pianoSheet;
        }

        public async Task RemoveByIdAsync(int id)
        {
            var isEntityRemoved = await _pianoSheetRepository.RemoveByIdAsync(id);
            if(!isEntityRemoved)
            {
                throw new FailedToRemoveRowsException();
            }
            await _pianoSheetRepository.SaveAsync();
        }
    }
}
