namespace TestApp
{
    class User
    {
        private readonly string userID;
        private readonly string userPW;

        public User(string userID, string userPW)
        {
            this.userID = userID; //상수처리
            this.userPW = userPW; //상수처리
        }
        public void Print()
        {
            Console.WriteLine(this.userID);
            Console.WriteLine(this.userPW);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string uID = "abc";
            string uPW = "abc";

            User user = new User(uID, uPW);

            user.Print();
        }
    }
}
