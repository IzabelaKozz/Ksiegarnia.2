using Ksiegarnia.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Ksiegarnia.Data;

namespace Ksiegarnia.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<User> User { get; set; }
        public new DbSet<Role> Roles { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Favorite> Favorites { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Dodaj rekordy książek
            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    BookId = 1,
                    Title = "Atomowe nawyki. Drobne zmiany, niezwykłe efekty",
                    Author = "James Clear",
                    Description = "To książka, która pomoże Ci uświadomić sobie, jaki mechanizm stoi za tego typu zachowaniami. Jej lektura uświadomi również, jak odróżniać dobre zwyczaje od tych szkodliwych. Autor prezentuje tu oryginalną, lecz popartą naukowymi dowodami metodę kształtowania dobrych przyzwyczajeń i wyzbywania się złych. W oparciu o najnowsze zdobycze nauk kognitywnych i behawioralnych James Clear stworzył jeden z pierwszych (jak sam pisze) modeli ludzkiego zachowania, w którym nawyki wynikają zarówno z bodźców zewnętrznych, jak i z wewnętrznych emocji.",
                    Price = 29.99M,
                    CoverImage = "1.jpg"
                },
                new Book
                {
                    BookId = 2,
                    Title = "Chłopki. Opowieść o naszych babkach",
                    Author = "Joanna Kuciel-Frydryszak",
                    Description = "To publikacja stanowiąca reportaż na temat życia wiejskich kobiet. Współczesny czytelnik może dzięki niemu zrozumieć, jak wiodło się jego babkom i prababkom oraz z jakimi problemami musiały się mierzyć. Książka przedstawia odbiorcy pracujące w pocie czoła gospodynie wiejskie, mamki, folwarczne wyrobnice, a także dziewczyny zatrudniające się w bogatszych gospodarstwach. Jak wynika z poszczególnych opowieści, ich największymi marzeniami były łóżka, wygodne buty czy edukacja. Każdej też zależało na posagu i dobrym wyjściu za mąż. Czytelnik zobaczy też, jak ogromnych wysiłków musiały dokonywać, by zapewnić wyżywienie całej swojej rodzinie. W publikacji pokazane zostają więc kobiety nieszanowane i wykorzystywane przez mężczyzn, nie tylko mężów, ale i ojców. Pomijane, podobnie jak ich potrzeby, dlatego też często niepotrafiące pisać ani czytać",
                    Price = 39.99M,
                    CoverImage = "2.jpg"
                },
                new Book
                {
                    BookId = 3,
                    Title = "Święta po sąsiedzku",
                    Author = "Anna Wolf",
                    Description = "Rose i Jason są sąsiadami, ale nie jest to dla nich powodem do radości. Wręcz przeciwnie: jeśli można powiedzieć, że cokolwiek ich łączy, to tylko wzajemna niechęć. Jason mieszka ze swoją babcią, Rose – z dziadkiem. Kiedy okazuje się, że starsi państwo bez ich wiedzy i zgody zaaranżowali Święta w gronie znajomych, młodzi muszą zakopać wojenny topór, ale czy na długo? Jedno jest pewne: to będzie najbardziej szalona i zaskakująca Gwiazdka w ich życiu.",
                    Price = 27.99M,
                    CoverImage = "3.jpg"
                },
                new Book
                {
                    BookId = 4,
                    Title = "Pokłosie. Opowieści z Kosodomu. Żniwa śmierci. Tom 3.5",
                    Author = "Neal Shusterman",
                    Description = "Ekscytujący i przerażający świat Kosodomu jest pełen opowieści, które czekają na odkrycie. Od kiedy Thunderhead roztoczył opiekę nad ludzkością, do czasu gdy kosiarz Goddard próbował wywrócić wszystko do góry nogami, minęły całe wieki. Ludzie żyli bez głodu, chorób i śmierci, a kosiarze kontrolowali liczebność populacji. Pokłosie. Opowieści z Kosodomu to zbiór opowiadań osadzonych w uniwersum Żniw śmierci. Kolejne historie nie tylko rozwijają fabułę trylogii, lecz także wyjaśniają genezę niektórych zdarzeń. Pojawiają się również nowi kosiarze! Neal Shusterman wraz z Davidem Yoonem, Jarrodem Shustermanem, Sofíą Lapuente, Michaelem H. Payne'em, Michelle Knowlden i Joelle Shusterman zabiorą was z powrotem do niezwykłego świata Żniw śmierci.",
                    Price = 52.49M,
                    CoverImage = "4.jpg"
                },
                new Book
                {
                    BookId = 5,
                    Title = "Na domowym froncie",
                    Author = "Kristin Hannah",
                    Description = "Ta powieść jest protestem przeciwko wysyłaniu amerykańskich żołnierzy na misje pokojowe, które w rzeczywistości o wiele więcej mają wspólnego z polityką niż z utrwalaniem pokoju. Kosztem jest śmierć wielu młodych ludzi i cierpienie ich rodzin. Wielu weteranów powraca z misji ciężko okaleczonych zarówno fizycznie jak i psychicznie. Hannah opisuje proces żołnierza cierpiącego na PTSD - Zespół Stresu Pourazowego.Młody człowiek skrzywiony przez przeżycia w Iraku zostaje skazany na wieloletnie więzienie za zabójstwo żony, nie doczekawszy się wcześniej psychologicznej pomocy ze strony władz wojskowych. A Jolene, główna bohaterka powieści, pilotka zestrzelonego helikoptera, po amputacji nogi ma problemy z odnalezieniem się w życiu, dodatkowo obwiniając się o śmierć przyjaciółki oraz Smitty'ego, dwudziestoletniego strzelca pokładowego z załogi jej helikoptera.",
                    Price = 34.99M,
                    CoverImage = "5.jpg"
                },
                new Book
                {
                    BookId = 6,
                    Title = "Wielka księga superskarbów. To, co naprawdę się liczy",
                    Author = "Susanna Isern & Rocio Bonilla ",
                    Description = "Co w życiu liczy się najbardziej? Na to pytanie odpowie dzieciom ta cudowna książeczka. To przepiękna propozycja dla najmłodszych ukazująca im, co naprawdę jest bezcenne. Lista tego, co w życiu jest najważniejsze, z pewnością okazałaby się bardzo długa. Ludzie mają różne wartości i na swój sposób postrzegają świat. Mimo to dobrze zastanowić się, czy na tej liście faktycznie znajduje się to, co powinno na niej być. Ta książka wyjaśni dzieciom, jak i również dorosłym, że w życiu są skarby piękniejsze niż rzeczy materialne.",
                    Price = 26.49M,
                    CoverImage = "6.jpg"
                },
                new Book
                {
                    BookId = 7,
                    Title = "Mapy. Obrazkowa podróż po lądach, morzach i kulturach świata. Edycja niebieska",
                    Author = "Aleksandra Mizielińska & Daniel Mizieliński  ",
                    Description = "Pozycja zawiera 51 ogromnych map, które ukazują piękno i różnorodność aż 42 krajów na 6 kontynentach. To niepowtarzalna okazja do zobaczenia gejzerów na Islandii, karawany na egipskiej pustyni, czy miasta Majów w Meksyku! Szczegóły, jakie mamy okazję poznać, pozwolą zatopić się w zupełnie innej kulturze i poznać jej różnorodność. Na co dzień trudno jest wyobrazić sobie, co dzieje się na drugim końcu ziemi. Tutaj jednak nie mamy tego problemu, gdyż wystarczy wybrać odpowiednią mapę i cieszyć się chwilą.",
                    Price = 42.99M,
                    CoverImage = "7.jpg"
                },
                new Book
                {
                    BookId = 8,
                    Title = "Pucio zostaje kucharzem, czyli o radości z jedzenia",
                    Author = "Marta Galewska-Kustra",
                    Description = "W tej części przygód Pucia i jego rodziny odwiedzamy razem z bohaterami restaurację Wesoła Marchewka. Dzieci są bardzo podekscytowane, przynajmniej do momentu, kiedy okazuje się, że makaron Pucia wygląda nie tak, jak w domu. Nie chce jeść, ale po chwili daje się namówić mamie i próbuje. Makaron jest smaczny! Pucio cieszy się, że spróbował. Po powrocie do domu cała rodzina angażuje się w przygotowywanie placuszków, które tata smaży potem na patelni. W książce znajduje się również przepis, dzięki któremu dzieci z pomocą rodziców będą mogły przygotować swoje własne placuszki.",
                    Price = 21.79M,
                    CoverImage = "8.jpg"
                },
                new Book
                {
                    BookId = 9,
                    Title = "Akademia Pana Kleksa. Pan Kleks. Tom 1",
                    Author = "Jan Brzechwa",
                    Description = "Ciężko uwierzyć w to, że pierwsze wydanie Akademii Pana Kleksa datuje się na rok 1946! Do dzisiaj bowiem jest to jedna z najchętniej czytanych powieści dla dzieci, nie tylko z tego powodu, że jest omawiana w szkole jako lektura. To wspaniała, pełna przygód opowieść o Adasiu Niezgódce i niezwykłej Akademii.",
                    Price = 23.99M,
                    CoverImage = "9.jpg"
                },
                new Book
                {
                    BookId = 10,
                    Title = "Świat Poli. Pytaj do woli",
                    Author = "Irena Mąsior Mili0nerka",
                    Description = "Książeczka skierowana jest do młodszych dzieci, a dzięki pięknym, barwnym ilustracjom z pewnością na dłużej zatrzyma uwagę nawet najbardziej niecierpliwego maluszka. Pokaźna ilość treści powoduje z kolei, że książeczka idealnie nadaje się np. do czytania przed snem. Poza ciekawą historią niesie też ze sobą sporą dawkę wiedzy o otaczającym nas świecie.",
                    Price = 34.99M,
                    CoverImage = "10.jpg"
                },
                new Book
                {
                    BookId = 11,
                    Title = "Lekcje chemii",
                    Author = "Bonnie Garmus",
                    Description = "iteracki debiut, obok którego nie można przejść obojętnie! Książka jest pełną humoru opowieścią o poważnych problemach kobiet w latach 50. XX wieku, kiedy to świat był opanowany przez mężczyzn. Bonnie Garmus napisała niezwykle śmieszną historię, która porusza ważny temat równouprawnienia płci. Książka jest znakomitą zachętą do rozpoczęcia dyskusji na temat status quo. Chociaż zagadnienie jest poważne, zostało przedstawione w sposób swobodny i humorystyczny, a charyzmatyczna Elizabeth Zott stanowi ikonę feminizmu.",
                    Price = 33.00M,
                    CoverImage = "11.jpg"
                },
                new Book
                {
                    BookId = 12,
                    Title = "Czuła przewodniczka. Kobieca droga do siebie",
                    Author = "Natalia de Barbaro",
                    Description = "Życie przynosi wiele nieoczekiwanych sytuacji i zrządzeń losu. Ani się obejrzysz, a okazuje się, że nie wiesz, jak się tu znalazłaś. Nie rozpoznajesz tego życia ani... samej siebie. Powrót do własnego ja, do prawdziwej siebie nie jest łatwy, a droga jest zazwyczaj wyboista. Ta książka została napisana właśnie po to, aby wesprzeć Cię w tej trudnej podróży. Autorka razem z czytelniczkami przebywa tę drogę, nadając książce bardzo osobisty charakter. Uczy, w jaki sposób odróżnić swoje prawdziwe potrzeby i pragnienia od poczucia obowiązku, pomaga wyzwolić się z toksycznych schematów i relacji. Ta książka da Ci realną siłę i sprawi, że inaczej spojrzysz na swoje życie. Książka będzie towarzyszyć Ci w podróży w głąb siebie i pomoże odnaleźć w sobie kobiecą mądrość.",
                    Price = 27.99M,
                    CoverImage = "12.jpg"
                },
                new Book
                {
                    BookId = 13,
                    Title = "Najbogatszy człowiek w Babilonie",
                    Author = "George Samuel Clason",
                    Description = "Książka szybko zyskała sławę jako jeden z najlepszych i najpraktyczniejszych poradników finansowych. Napisany z wielkim poczuciem humoru poradnik zawiera uniwersalne wskazówki, które sprawdzają się od tysięcy lat. Babilończycy wiedzieli, jak prowadzić swoje finanse, a ich mądrość w tym zakresie znajduje zastosowanie również we współczesnym świecie. Czytelnicy nie znajdą tutaj doraźnych wskazówek, lecz ogólne sposoby na to, aby stały dochód przekuł się w oszczędności i niwelację finansowych zobowiązań. Przypowieści osadzone w realiach starożytnego Babilonu działają na wyobraźnię i można je przenieść do dowolnej epoki, znajdując sposób na rozwiązanie swoich kłopotów finansowych.",
                    Price = 33.39m,
                    CoverImage = "13.jpg"
                },
                new Book
                {
                    BookId = 14,
                    Title = "Moje pierwsze literki",
                    Author = "Maria Zagnińska",
                    Description = "To ciekawa i praktyczna książeczka wspierająca naukę i ćwiczenie pisania literek dla dzieci, które właśnie zaczynają swoją edukacyjną przygodę! ozycja przede wszystkim przeznaczona została dla tych dzieci, które poznają świat liter i słów i zaczynają się go uczyć. Przy każdej z literek zamieszczony został wyraźny jej wzór, dodatkowo z przydatnymi strzałkami pokazującymi, jak zacząć pisać je prawidłowo. To znacznie ułatwia pracę dziecka i pomaga mu zrozumieć zasady, jakie obowiązują przy pisaniu. Ponadto przy niektórych symbolach znaleźć możemy barwne rysunki przedstawiające zwierzę, osobę lub rzecz, których nazwa rozpoczyna się na daną literę, natomiast przy innych można zatrzymać się na dłużej dzięki kolorowance czy ciekawym labiryncie.",
                    Price = 9.99M,
                    CoverImage = "14.jpg"
                }
                            // Dodaj więcej rekordów według potrzeb
                            );
        }

    }
    public interface IBookRepository
    {
        IEnumerable<Book> GetAllBooks();
        Book GetBookById(int bookId);
        void AddBook(Book book);
        void UpdateBook(Book book);
        void DeleteBook(int bookId);
        IEnumerable<Book> GetFavoriteBooks(int userId);
        void AddToFavorite(int userId, int bookId);
        void RemoveFromFavorite(int userId, int bookId);
    }
    public class BookRepository : IBookRepository
    {
        private readonly ApplicationDbContext _context;

        public BookRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return _context.Books.ToList();
        }

        public Book GetBookById(int bookId)
        {
            return _context.Books.FirstOrDefault(b => b.BookId == bookId);
        }

        public void AddBook(Book book)
        {
            try
            {
                _context.Books.Add(book);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                // Tutaj dodaj logowanie błędu, na przykład do konsoli
                Console.WriteLine($"Error adding book to the database: {ex.Message}");
                throw; // Rzuć błąd ponownie, aby informować o błędzie
            }
        }

        public void UpdateBook(Book book)
        {
            var existingBook = _context.Books.FirstOrDefault(b => b.BookId == book.BookId);

            if (existingBook != null)
            {
                // Aktualizuj tylko te właściwości, które powinny być aktualizowane
                existingBook.Title = book.Title;
                existingBook.Author = book.Author;
                existingBook.Description = book.Description;
                existingBook.Price = book.Price;

                // Jeśli zmienia się obraz okładki, zaktualizuj również tę informację
                if (!string.IsNullOrEmpty(book.CoverImage))
                {
                    existingBook.CoverImage = book.CoverImage;

                }

                _context.SaveChanges();
            }

        }

        public void DeleteBook(int bookId)
        {
            var bookToDelete = _context.Books.FirstOrDefault(b => b.BookId == bookId);
            if (bookToDelete != null)
            {
                _context.Books.Remove(bookToDelete);
                _context.SaveChanges();
            }
        }
        public IEnumerable<Book> GetFavoriteBooks(int userId)
        {
            return _context.Favorites
                .Where(f => f.UserId == userId)
                .Select(f => f.Book)
                .ToList();
        }

        public void AddToFavorite(int userId, int bookId)
        {
            var favorite = new Favorite { UserId = userId, BookId = bookId };
            _context.Favorites.Add(favorite);
            _context.SaveChanges();
        }

        public void RemoveFromFavorite(int userId, int bookId)
        {
            var favorite = _context.Favorites
                .SingleOrDefault(f => f.UserId == userId && f.BookId == bookId);

            if (favorite != null)
            {
                _context.Favorites.Remove(favorite);
                _context.SaveChanges();
            }
        }
    }

}