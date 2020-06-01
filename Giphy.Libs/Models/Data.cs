using System;
using System.Runtime.Serialization;

namespace Giphy.Libs.Models
{
    [DataContract]
    public class Data
    {
        [DataMember(Name = "bitly_gif_url")]
        public string BitlyGifUrl { get; set; }
    }
}