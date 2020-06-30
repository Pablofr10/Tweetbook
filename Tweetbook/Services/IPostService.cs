﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Tweetbook.Domain;

namespace Tweetbook.Services
{
    public interface IPostService
    {
        Task<List<Post>> GetPostsAsync();
        Task<Post> GetPostByIdAsync(Guid postId);
        Task<bool> UpdatePostAsync(Post postToUpdate);
        Task<bool> CreatePostAsync(Post post);
        Task<bool> DeletePostAsync(Guid postId);
        Task<bool> UserOwnsPostAsync(Guid postId, string userId);

    }
}
