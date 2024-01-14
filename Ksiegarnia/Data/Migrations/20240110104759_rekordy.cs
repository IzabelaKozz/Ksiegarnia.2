using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ksiegarnia.Data.Migrations
{
    public partial class rekordy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "CartId", "CoverImage", "Description", "FavoriteId", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "James Clear", null, "1.jpg", "To książka, która pomoże Ci uświadomić sobie, jaki mechanizm stoi za tego typu zachowaniami. Jej lektura uświadomi również, jak odróżniać dobre zwyczaje od tych szkodliwych. Autor prezentuje tu oryginalną, lecz popartą naukowymi dowodami metodę kształtowania dobrych przyzwyczajeń i wyzbywania się złych. W oparciu o najnowsze zdobycze nauk kognitywnych i behawioralnych James Clear stworzył jeden z pierwszych (jak sam pisze) modeli ludzkiego zachowania, w którym nawyki wynikają zarówno z bodźców zewnętrznych, jak i z wewnętrznych emocji.", null, 29.99m, "Atomowe nawyki. Drobne zmiany, niezwykłe efekty" },
                    { 2, "Joanna Kuciel-Frydryszak", null, "2.jpg", "To publikacja stanowiąca reportaż na temat życia wiejskich kobiet. Współczesny czytelnik może dzięki niemu zrozumieć, jak wiodło się jego babkom i prababkom oraz z jakimi problemami musiały się mierzyć. Książka przedstawia odbiorcy pracujące w pocie czoła gospodynie wiejskie, mamki, folwarczne wyrobnice, a także dziewczyny zatrudniające się w bogatszych gospodarstwach. Jak wynika z poszczególnych opowieści, ich największymi marzeniami były łóżka, wygodne buty czy edukacja. Każdej też zależało na posagu i dobrym wyjściu za mąż. Czytelnik zobaczy też, jak ogromnych wysiłków musiały dokonywać, by zapewnić wyżywienie całej swojej rodzinie. W publikacji pokazane zostają więc kobiety nieszanowane i wykorzystywane przez mężczyzn, nie tylko mężów, ale i ojców. Pomijane, podobnie jak ich potrzeby, dlatego też często niepotrafiące pisać ani czytać", null, 39.99m, "Chłopki. Opowieść o naszych babkach" },
                    { 3, "Anna Wolf", null, "3.jpg", "Rose i Jason są sąsiadami, ale nie jest to dla nich powodem do radości. Wręcz przeciwnie: jeśli można powiedzieć, że cokolwiek ich łączy, to tylko wzajemna niechęć. Jason mieszka ze swoją babcią, Rose – z dziadkiem. Kiedy okazuje się, że starsi państwo bez ich wiedzy i zgody zaaranżowali Święta w gronie znajomych, młodzi muszą zakopać wojenny topór, ale czy na długo? Jedno jest pewne: to będzie najbardziej szalona i zaskakująca Gwiazdka w ich życiu.", null, 27.99m, "Święta po sąsiedzku" },
                    { 4, "Neal Shusterman", null, "4.jpg", "Ekscytujący i przerażający świat Kosodomu jest pełen opowieści, które czekają na odkrycie. Od kiedy Thunderhead roztoczył opiekę nad ludzkością, do czasu gdy kosiarz Goddard próbował wywrócić wszystko do góry nogami, minęły całe wieki. Ludzie żyli bez głodu, chorób i śmierci, a kosiarze kontrolowali liczebność populacji. Pokłosie. Opowieści z Kosodomu to zbiór opowiadań osadzonych w uniwersum Żniw śmierci. Kolejne historie nie tylko rozwijają fabułę trylogii, lecz także wyjaśniają genezę niektórych zdarzeń. Pojawiają się również nowi kosiarze! Neal Shusterman wraz z Davidem Yoonem, Jarrodem Shustermanem, Sofíą Lapuente, Michaelem H. Payne'em, Michelle Knowlden i Joelle Shusterman zabiorą was z powrotem do niezwykłego świata Żniw śmierci.", null, 52.49m, "Pokłosie. Opowieści z Kosodomu. Żniwa śmierci. Tom 3.5" },
                    { 5, "Kristin Hannah", null, "5.jpg", "Ta powieść jest protestem przeciwko wysyłaniu amerykańskich żołnierzy na misje pokojowe, które w rzeczywistości o wiele więcej mają wspólnego z polityką niż z utrwalaniem pokoju. Kosztem jest śmierć wielu młodych ludzi i cierpienie ich rodzin. Wielu weteranów powraca z misji ciężko okaleczonych zarówno fizycznie jak i psychicznie. Hannah opisuje proces żołnierza cierpiącego na PTSD - Zespół Stresu Pourazowego.Młody człowiek skrzywiony przez przeżycia w Iraku zostaje skazany na wieloletnie więzienie za zabójstwo żony, nie doczekawszy się wcześniej psychologicznej pomocy ze strony władz wojskowych. A Jolene, główna bohaterka powieści, pilotka zestrzelonego helikoptera, po amputacji nogi ma problemy z odnalezieniem się w życiu, dodatkowo obwiniając się o śmierć przyjaciółki oraz Smitty'ego, dwudziestoletniego strzelca pokładowego z załogi jej helikoptera.", null, 34.99m, "Na domowym froncie" },
                    { 6, "Susanna Isern & Rocio Bonilla ", null, "6.jpg", "Co w życiu liczy się najbardziej? Na to pytanie odpowie dzieciom ta cudowna książeczka. To przepiękna propozycja dla najmłodszych ukazująca im, co naprawdę jest bezcenne. Lista tego, co w życiu jest najważniejsze, z pewnością okazałaby się bardzo długa. Ludzie mają różne wartości i na swój sposób postrzegają świat. Mimo to dobrze zastanowić się, czy na tej liście faktycznie znajduje się to, co powinno na niej być. Ta książka wyjaśni dzieciom, jak i również dorosłym, że w życiu są skarby piękniejsze niż rzeczy materialne.", null, 26.49m, "Wielka księga superskarbów. To, co naprawdę się liczy" },
                    { 7, "Aleksandra Mizielińska & Daniel Mizieliński  ", null, "7.jpg", "Pozycja zawiera 51 ogromnych map, które ukazują piękno i różnorodność aż 42 krajów na 6 kontynentach. To niepowtarzalna okazja do zobaczenia gejzerów na Islandii, karawany na egipskiej pustyni, czy miasta Majów w Meksyku! Szczegóły, jakie mamy okazję poznać, pozwolą zatopić się w zupełnie innej kulturze i poznać jej różnorodność. Na co dzień trudno jest wyobrazić sobie, co dzieje się na drugim końcu ziemi. Tutaj jednak nie mamy tego problemu, gdyż wystarczy wybrać odpowiednią mapę i cieszyć się chwilą.", null, 42.99m, "Mapy. Obrazkowa podróż po lądach, morzach i kulturach świata. Edycja niebieska" },
                    { 8, "Marta Galewska-Kustra", null, "8.jpg", "W tej części przygód Pucia i jego rodziny odwiedzamy razem z bohaterami restaurację Wesoła Marchewka. Dzieci są bardzo podekscytowane, przynajmniej do momentu, kiedy okazuje się, że makaron Pucia wygląda nie tak, jak w domu. Nie chce jeść, ale po chwili daje się namówić mamie i próbuje. Makaron jest smaczny! Pucio cieszy się, że spróbował. Po powrocie do domu cała rodzina angażuje się w przygotowywanie placuszków, które tata smaży potem na patelni. W książce znajduje się również przepis, dzięki któremu dzieci z pomocą rodziców będą mogły przygotować swoje własne placuszki.", null, 21.79m, "Pucio zostaje kucharzem, czyli o radości z jedzenia" },
                    { 9, "Jan Brzechwa", null, "9.jpg", "Ciężko uwierzyć w to, że pierwsze wydanie Akademii Pana Kleksa datuje się na rok 1946! Do dzisiaj bowiem jest to jedna z najchętniej czytanych powieści dla dzieci, nie tylko z tego powodu, że jest omawiana w szkole jako lektura. To wspaniała, pełna przygód opowieść o Adasiu Niezgódce i niezwykłej Akademii.", null, 23.99m, "Akademia Pana Kleksa. Pan Kleks. Tom 1" },
                    { 10, "Irena Mąsior Mili0nerka", null, "10.jpg", "Książeczka skierowana jest do młodszych dzieci, a dzięki pięknym, barwnym ilustracjom z pewnością na dłużej zatrzyma uwagę nawet najbardziej niecierpliwego maluszka. Pokaźna ilość treści powoduje z kolei, że książeczka idealnie nadaje się np. do czytania przed snem. Poza ciekawą historią niesie też ze sobą sporą dawkę wiedzy o otaczającym nas świecie.", null, 34.99m, "Świat Poli. Pytaj do woli" },
                    { 11, "Bonnie Garmus", null, "11.jpg", "iteracki debiut, obok którego nie można przejść obojętnie! Książka jest pełną humoru opowieścią o poważnych problemach kobiet w latach 50. XX wieku, kiedy to świat był opanowany przez mężczyzn. Bonnie Garmus napisała niezwykle śmieszną historię, która porusza ważny temat równouprawnienia płci. Książka jest znakomitą zachętą do rozpoczęcia dyskusji na temat status quo. Chociaż zagadnienie jest poważne, zostało przedstawione w sposób swobodny i humorystyczny, a charyzmatyczna Elizabeth Zott stanowi ikonę feminizmu.", null, 33.00m, "Lekcje chemii" },
                    { 12, "Natalia de Barbaro", null, "12.jpg", "Życie przynosi wiele nieoczekiwanych sytuacji i zrządzeń losu. Ani się obejrzysz, a okazuje się, że nie wiesz, jak się tu znalazłaś. Nie rozpoznajesz tego życia ani... samej siebie. Powrót do własnego ja, do prawdziwej siebie nie jest łatwy, a droga jest zazwyczaj wyboista. Ta książka została napisana właśnie po to, aby wesprzeć Cię w tej trudnej podróży. Autorka razem z czytelniczkami przebywa tę drogę, nadając książce bardzo osobisty charakter. Uczy, w jaki sposób odróżnić swoje prawdziwe potrzeby i pragnienia od poczucia obowiązku, pomaga wyzwolić się z toksycznych schematów i relacji. Ta książka da Ci realną siłę i sprawi, że inaczej spojrzysz na swoje życie. Książka będzie towarzyszyć Ci w podróży w głąb siebie i pomoże odnaleźć w sobie kobiecą mądrość.", null, 27.99m, "Czuła przewodniczka. Kobieca droga do siebie" },
                    { 13, "George Samuel Clason", null, "13.jpg", "Książka szybko zyskała sławę jako jeden z najlepszych i najpraktyczniejszych poradników finansowych. Napisany z wielkim poczuciem humoru poradnik zawiera uniwersalne wskazówki, które sprawdzają się od tysięcy lat. Babilończycy wiedzieli, jak prowadzić swoje finanse, a ich mądrość w tym zakresie znajduje zastosowanie również we współczesnym świecie. Czytelnicy nie znajdą tutaj doraźnych wskazówek, lecz ogólne sposoby na to, aby stały dochód przekuł się w oszczędności i niwelację finansowych zobowiązań. Przypowieści osadzone w realiach starożytnego Babilonu działają na wyobraźnię i można je przenieść do dowolnej epoki, znajdując sposób na rozwiązanie swoich kłopotów finansowych.", null, 33.39m, "Najbogatszy człowiek w Babilonie" },
                    { 14, "Maria Zagnińska", null, "14.jpg", "To ciekawa i praktyczna książeczka wspierająca naukę i ćwiczenie pisania literek dla dzieci, które właśnie zaczynają swoją edukacyjną przygodę! ozycja przede wszystkim przeznaczona została dla tych dzieci, które poznają świat liter i słów i zaczynają się go uczyć. Przy każdej z literek zamieszczony został wyraźny jej wzór, dodatkowo z przydatnymi strzałkami pokazującymi, jak zacząć pisać je prawidłowo. To znacznie ułatwia pracę dziecka i pomaga mu zrozumieć zasady, jakie obowiązują przy pisaniu. Ponadto przy niektórych symbolach znaleźć możemy barwne rysunki przedstawiające zwierzę, osobę lub rzecz, których nazwa rozpoczyna się na daną literę, natomiast przy innych można zatrzymać się na dłużej dzięki kolorowance czy ciekawym labiryncie.", null, 9.99m, "Moje pierwsze literki" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 14);
        }
    }
}
