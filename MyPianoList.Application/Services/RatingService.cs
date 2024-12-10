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
    public class TagService : ITagService
    {
        private readonly ITagRepository _tagRepository;

        public TagService(ITagRepository tagRepository)
        {
            _tagRepository = tagRepository;
        }
        public IEnumerable<Tag> GetAll()
        {
            var tags = _tagRepository.GetAll();
            return tags;
        }

        public async Task<Tag> GetByIdAsync(int id)
        {
            var task = (await _tagRepository.GetByIdAsync(id));
            if (task == null)
            {
                throw new KeyNotFoundException();
            }
            return task;
        }

        public async Task CreateAsync(Tag tag)
        {
            await _tagRepository.AddAsync(tag);
            await _tagRepository.SaveAsync();
            return;
        }

        public async Task<Tag> UpdateAsync(int id, Tag tag)
        {

            var isUpdated = await _tagRepository.UpdateAsync(id, tag);
            if (!isUpdated)
            {
                throw new KeyNotFoundException();
            }

            await _tagRepository.SaveAsync();

            return tag;
        }

        public async Task RemoveByIdAsync(int id)
        {
            await _tagRepository.RemoveByIdAsync(id);
            await _tagRepository.SaveAsync();
        }
    }
}
