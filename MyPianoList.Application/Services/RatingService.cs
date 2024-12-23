﻿using Microsoft.Identity.Client;
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
    public class RatingService : IRatingService
    {
        private readonly IRatingRepository _ratingRepository;

        public RatingService(IRatingRepository ratingRepository)
        {
            _ratingRepository = ratingRepository;
        }

        public async Task CreateAsync(Rating rating)
        {
            await _ratingRepository.AddAsync(rating);
            await _ratingRepository.SaveAsync();
            return;
        }

        public async Task<Rating> UpdateAsync(int id, Rating rating)
        {

            var isUpdated = await _ratingRepository.UpdateAsync(id, rating);
            if (!isUpdated)
            {
                throw new KeyNotFoundException();
            }

            await _ratingRepository.SaveAsync();

            return rating;
        }

        public async Task RemoveByIdAsync(int id)
        {
            await _ratingRepository.RemoveByIdAsync(id);
            await _ratingRepository.SaveAsync();
        }

        public async Task<double> GetTotalLikeDislikeRatioAsync()
        {
            return await _ratingRepository.GetTotalLikeDislikeRatioAsync();
        }

        public async Task<double> GetMaxLikeDislikeRatioAsync()
        {
            return await _ratingRepository.GetMaxLikeDislikeRatioAsync();
        }
        
    }
}
