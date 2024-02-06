using System;

namespace StackOverflowProject.ViewModels
{
    public class PostDetailViewModel
    {
        public string PostType { get; set; } // Type of post: "Question" or "Answer"
        public string DayOfWeek { get; set; } // Day of the week
        public int TotalPosts { get; set; } // Total number of posts
        public int TotalUpvotes { get; set; } // Total number of upvotes
        public int TotalDownvotes { get; set; } // Total number of downvotes
        public double AvgUpvoteDownvoteRatio { get; set; } // Average upvote to downvote ratio

        // Constructor
        public PostDetailViewModel(string postType, string dayOfWeek, int totalPosts, int totalUpvotes, int totalDownvotes, double avgUpvoteDownvoteRatio)
        {
            PostType = postType;
            DayOfWeek = dayOfWeek;
            TotalPosts = totalPosts;
            TotalUpvotes = totalUpvotes;
            TotalDownvotes = totalDownvotes;
            AvgUpvoteDownvoteRatio = avgUpvoteDownvoteRatio;
        }
    }
}
