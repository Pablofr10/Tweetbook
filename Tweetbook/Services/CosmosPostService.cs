//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Cosmonaut;
//using Cosmonaut.Extensions;
//using Tweetbook.Domain;

//namespace Tweetbook.Services
//{
//    public class CosmosPostService : IPostService
//    {
//        private readonly ICosmosStore<CosmosPostDto> _cosmosStore;

//        public CosmosPostService(ICosmosStore<CosmosPostDto> cosmosStore)
//        {
//            _cosmosStore = cosmosStore;
//        }
//        public async Task<List<Post>> GetPostsAsync()
//        {
//            var posts = await _cosmosStore.Query().ToListAsync();
//            return posts.Select(x => new Post { Id = Guid.Parse(x.Id), Name = x.Name}).ToList();
//        }

//        public async Task<Post> GetPostByIdAsync(Guid postId)
//        {
//            var post = await _cosmosStore.FindAsync(postId.ToString(), postId.ToString());

//            return post == null ? null : new Post{ Id = Guid.Parse(post.Id), Name = post.Name};
//        }

//        public async Task<bool> UpdatePostAsync(Post postToUpdate)
//        {
//            var cosmosPost = new CosmosPostDto
//            {
//                Id = postToUpdate.Id.ToString(),
//                Name = postToUpdate.Name
//            };

//            var response = await _cosmosStore.UpdateAsync(cosmosPost);
//            return response.IsSuccess;
//        }

//        public async Task<bool> CreatePostAsync(Post post)
//        {
//            var cosmosPost = new CosmosPostDto
//            {
//                Id = Guid.NewGuid().ToString(),
//                Name = post.Name
//            };

//            var response = await _cosmosStore.AddAsync(cosmosPost);
//            post.Id = Guid.Parse(cosmosPost.Id);
//            return response.IsSuccess;
//        }

//        public async Task<bool> DeletePostAsync(Guid postId)
//        {
//            var response = await _cosmosStore.RemoveByIdAsync(postId.ToString(), postId.ToString());
//            return response.IsSuccess;
//        }
//    }
//}
