﻿namespace AutoTagger.Contract
{
    using System.Collections.Generic;

    public interface IImage
    {
        IEnumerable<string> MachineTags { get; set; }

        IEnumerable<string> HumanoidTags { get; set; }

        int Id { get; set; }

        string ImageId { get; set; }

        string ImageUrl { get; set; }

        string InstaUrl { get; set; }

        int Likes { get; set; }

        int Follower { get; set; }

        int Comments { get; set; }
    }
}