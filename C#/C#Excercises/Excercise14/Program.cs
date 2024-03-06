namespace Excercise14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.bookName = "De Men Phieu Luu Ky";
            book.bookAuthorName = "To Hoai";
            book.toString();
            Book book2 = new Book("Tat den","Ngo tat to");
            book2.toString();
        }
        public struct Book
        {
            public string bookName { get; set; }
            public string bookAuthorName { get; set; }

            public Book()
            {

            }
            public Book(string bookName, string bookAuthorName)
            {
                this.bookName = bookName;
                this.bookAuthorName = bookAuthorName;
            }
            public void toString()
            {
                Console.WriteLine("Ten sach : {0} \nTen tac gia : {1}",bookName,bookAuthorName);
            }
        }
    }
}
