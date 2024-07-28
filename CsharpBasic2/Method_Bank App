namespace Code68
{
    class BankAccout
    {
        //멤버 (잔고)
        private double balance = 0;

        //메소드 1 예금하다
        public void Deposit(double money)
        {
            balance += money;
        }
        //메소드 2. 인출하다
        public void WithDraw(double money)
        {
            balance -= money;
        }
        //메소드 3. 잔고확인 
        public double Check()
        {
            return balance;
        }  

        /*
         public void Check()
        {
            cw ("잔고확인" + balance)
        }
         
         */
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            BankAccout account = new BankAccout();
            //50000원 입금
            account.Deposit(50000); //멤버가 프라이빗이여서 복사가 안될것 같지만 디파짓 메소드 내에서 실행되므로 지장이 없음 


            //30000원 인출 
            account.WithDraw(30000);

            //잔고 확인 20000만원 있음이 확인 됨 
            Console.WriteLine("잔고는 " + account.Check());
            //account.Check();
        }
    }
}
