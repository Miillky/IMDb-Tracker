namespace IMDbTrackerLibrary.Models.API {
    public class ShowDetails {
        public string Id { get; set; }
        public ShowImage Image { get; set; }
        public int TunningTimeInMinutes { get; set; }
        public string NextEpisode { get; set; }
        public int NumberOfEpisodes { get; set; }
        public int SeriesEndYear { get; set; }
        public int SeriesStartYear { get; set; }
        public string Title { get; set; }
        public string TitleType { get; set; }
        public int Year { get; set; }
    }

    public class ShowImage {
        public int Height { get; set; }
        public string Id { get; set; }
        public string Url { get; set; }
        public int Width { get; set; }
    }
}
