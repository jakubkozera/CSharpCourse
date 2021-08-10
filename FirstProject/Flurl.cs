using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flurl.Http;

namespace FirstProject
{
    public class Flurl
    {
        public static async Task Main()
        {
            var posts = await "https://jsonplaceholder.typicode.com/posts"
                .GetAsync()
                .ReceiveJson<List<Post>>();

            var selectedPost = posts.First(p => p.Id == 30);
            Console.WriteLine(selectedPost.Title);
            Console.WriteLine(selectedPost.Body);

            selectedPost.Title = "test title";
            selectedPost.Body = "test body";

            Console.WriteLine(selectedPost.Title);
            Console.WriteLine(selectedPost.Body);

            var postResult = await "https://jsonplaceholder.typicode.com/posts"
                .WithHeaders(new
                {
                    header = "value",
                    header2 = "value2",
                    some_header = "some-value"
                }, true)
                .SetQueryParams(new
                {
                    postId = 1,
                    someValue = "value"
                })
                .PostJsonAsync(selectedPost);

            Console.WriteLine($"status code {postResult.StatusCode}");
        }
    }
}
