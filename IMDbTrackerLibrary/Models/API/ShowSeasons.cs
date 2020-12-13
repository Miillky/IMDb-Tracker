namespace IMDbTrackerLibrary.Models.API {
    public class ShowSeasons {
        public SeasonEpisodes[] Episodes { get; set; }
    }

    public class SeasonEpisodes {
        public ShowEpisode[] Episodes { get; set; }
        public int Season { get; set; }
    }

    public class ShowEpisode {
        public int Episode { get; set; }
        public string Id { get; set; }
        public int Season { get; set; }
        public string Eitle { get; set; }
        public int Year { get; set; }
    }
}