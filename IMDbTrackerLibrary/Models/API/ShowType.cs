namespace IMDbTrackerLibrary.Models.API {

    public class ShowTypes {
        public ShowType[] Genres { get; set; }
    }

    public class ShowType {
        public string Description { get; set; }
        public string Endpoint { get; set; }
    }  
}
