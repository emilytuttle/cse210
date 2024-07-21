public class VideoList
{
    public List<Video> _videoList = new List<Video>();

    public void Display()
    {
        foreach (Video video in _videoList)
        {
            video.Display();
        }
    }
}