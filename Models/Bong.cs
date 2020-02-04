using System;
using System.Text.Json.Serialization;

namespace BackendProject.Models
{
    public class Bong
    {
        public int Id { get; set; }

        public DateTime Created  { get; set; }
        public BongDetails BongDetails { get; set; }
    }
}