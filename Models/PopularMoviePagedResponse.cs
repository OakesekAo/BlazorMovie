namespace BlazorMovie.Models
{
    public class PopularMoviePagedResponse
    {
        public int page { get; set; }
        public PopularMovie[] results { get; set; }
        public int total_pages { get; set; }
        public int total_results { get; set; }


    }
}
