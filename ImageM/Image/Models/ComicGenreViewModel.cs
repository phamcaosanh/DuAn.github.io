using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
namespace Image.Models
{
    public class ComicGenreViewModel
    {
        public List<Comics> Comics { get; set; }
        public SelectList Genres { get; set; }
        public string ComicGenre { get; set; }
        public string SearchString { get; set; }
    }
}