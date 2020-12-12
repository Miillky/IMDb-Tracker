namespace IMDbTrackerLibrary.Models.API {
    public class MovieDetails {
        public string Id { get; set; }
        public MovieTitle Title { get; set; }
        public MovieRatings Ratings { get; set; }
        public string[] Genres { get; set; }
        public string ReleaseDate { get; set; }
        public MoviePlotoutline PlotOutline { get; set; }
        public MoviePlotsummary PlotSummary { get; set; }
    }

    public class MovieTitle {
        public MovieImage Image { get; set; }
        public int RunningTimeInMinutes { get; set; }
        public string Title { get; set; }
        public string TitleType { get; set; }
        public int Year { get; set; }
    }

    public class MovieImage {
        public int Height { get; set; }
        public string Url { get; set; }
        public int Width { get; set; }
    }

    public class MovieRatings {
        public float Rating { get; set; }
        public int RatingCount { get; set; }
        public int TopRank { get; set; }
    }

    public class MoviePlotoutline {
        public string Text { get; set; }
    }

    public class MoviePlotsummary {
        public string Text { get; set; }
    }
}