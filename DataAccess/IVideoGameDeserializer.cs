public interface IVideoGameDeserializer
{
    List<VideoGames> DeserializeFrom(string fileName, string fileContents);
}