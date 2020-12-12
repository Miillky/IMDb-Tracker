namespace IMDbTrackerLibrary.Models.API {

    public class MovieTypes {
        public MovieType[] Genres { get; set; }
    }

    public class MovieType {
        public string Description { get; set; }
        public string Endpoint { get; set; }
    }  
}
