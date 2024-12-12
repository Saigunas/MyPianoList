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
    public class StatusService : IStatusService
    {
        private readonly IStatusRepository _statusRepository;

        public StatusService(IStatusRepository statusRepository)
        {
            _statusRepository = statusRepository;
        }

        public async Task CreateAsync(Status status)
        {
            await _statusRepository.AddAsync(status);
            await _statusRepository.SaveAsync();
            return;
        }

        public async Task<Status> UpdateAsync(int id, Status status)
        {

            var isUpdated = await _statusRepository.UpdateAsync(id, status);
            if (!isUpdated)
            {
                throw new KeyNotFoundException();
            }

            await _statusRepository.SaveAsync();

            return status;
        }

        public async Task RemoveByIdAsync(int id)
        {
            await _statusRepository.RemoveByIdAsync(id);
            await _statusRepository.SaveAsync();
        }
    }
}
