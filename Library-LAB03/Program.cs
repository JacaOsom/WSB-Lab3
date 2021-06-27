using System;

namespace Library_LAB03
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Library lib = new Library("Warszawa ul. Ulicka 2");
            Catalog cat1 = new Catalog("Informatyka");
            Catalog cat2 = new Catalog("Mechanika");
            Catalog cat3 = new Catalog("Fantastyka");
            Catalog cat4 = new Catalog("Motoryzacja");

            lib.AddTheCatalog(cat1);
            lib.AddTheCatalog(cat2);
            lib.AddTheCatalog(cat3);
            lib.AddTheCatalog(cat4);

            var RCM = new Author("Robert C.", "Martin", "American");
            var b1 = new Book("Czysty kod. Podręcznik dobrego programisty", 978835478, "Helion", 2010, 424, RCM);

            var AnSap = new Author("Andrzej", "Sapkowski", "Polish");
            var b2 = new Book("Ostatnie Życzenie", 978837578, "Supernowa Warszawa", 2011, 286, AnSap);

            var StSzel = new Author("Stanisław", "Szelichowski", "Polish");
            var b3 = new Book("Motoryzacja w Polsce", 978831234, "Fenix", 2018, 224, StSzel);

            var JKR = new Author("Joanne", "Rowling", "British");
            var b4 = new Book("Harry Potter i Insygnia Śmierci", 978836689, "Media Rodzina", 2016, 782, JKR);

            var JanMi = new Author("Jan", "Misiak", "Polish");
            var b5 = new Book("Mechanika techniczna. Tom I", 978831239, "Wydawnictwo Naukowe PWN", 2017, 295, JanMi);

            var mg1 = new Magazine("Programista. Projektowanie interfejsów C++.", 285358, "Magazyn programistów", 2021, 2);

            var mg2 = new Magazine("Auto Motor i Sport", 63017229, "Czasopisma krajowe", 2021, 6);

            var mg3 = new Magazine("Auto Świat Classic", 11999232, "Czasopisma krajowe", 2021, 2);

            lib.AddThePosition(b1, "Informatyka");
            lib.AddThePosition(b2, "Fantastyka");
            lib.AddThePosition(b3, "Mechanika");
            lib.AddThePosition(b4, "Fantastyka");
            lib.AddThePosition(b5, "Mechanika");
            lib.AddThePosition(mg1, "Informatyka");
            lib.AddThePosition(mg2, "Motoryzacja");
            lib.AddThePosition(mg3, "Motoryzacja");

            Librarian L1 = new Librarian("Marian", "Kowalski", "01.07.2016", 3500);
            Librarian L2 = new Librarian("Jan", "Nowak", "15.04.2018", 2900);

            lib.AddTheLibrarian(L1);
            lib.AddTheLibrarian(L2);
            lib.WriteOutAllLibrarians();

            Console.WriteLine("\nPlease press ENTER\n");
            Console.ReadKey();

            lib.WriteOutAllPositions();

            Console.WriteLine("\nPlease press ENTER\n");
            Console.ReadKey();

            cat2.FindPositionByTitle("Mechanika techniczna. Tom I");
            lib.FindPositionByTitle("Ostatnie Życzenie");

            lib.FindPositionByID(63017229);

            cat3.FindPositionByID(978836689);

            Console.WriteLine("\nPlease press ENTER\n");
            Console.ReadKey();

            cat1.FindPosition("Czysty kod. Podręcznik dobrego programisty", "", "", "");

        }
    }
}
