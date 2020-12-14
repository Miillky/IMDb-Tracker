namespace IMDbTrackerLibrary.Models.API {

    public class ShowSeason {
        public ShowSeasonEpisode[] Episodes { get; set; }
        public int Season { get; set; }
    }

    public class ShowSeasonEpisode {
        public int Episode { get; set; }
        public string Id { get; set; }
        public int Season { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
    }
}