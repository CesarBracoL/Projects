namespace DesignPattern.Proxy
{
    public class Subject :ISubject
    {
        public string Request()
        {
            return "Subject Request : " + "Choose left door\n";
        }
    }
}