namespace IMDbTrackerLibrary.Models.API {

    public class EpisodeDetails {
        public string Id { get; set; }
        public EpisodeTitle Title { get; set; }
        public EpisodeRatings Ratings { get; set; }
        public string[] Genres { get; set; }
        public string ReleaseDate { get; set; }
        public Plotoutline PlotOutline { get; set; }
        public EpisodeShow ParentTitle { get; set; }
    }

    public class EpisodeTitle {
        public int Episode { get; set; }
        public EpisodeImage Image { get; set; }
        public int RunningTimeInMinutes { get; set; }
        public int Season { get; set; }
        public int SeriesEndYear { get; set; }
        public int SeriesStartYear { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
    }

    public class EpisodeImage {
        public string Url { get; set; }
    }

    public class EpisodeRatings {
        public float Rating { get; set; }
    }

    public class Plotoutline {
        public string Text { get; set; }
    }

    public class EpisodeShow {
        public string Id { get; set; }
    }
}
