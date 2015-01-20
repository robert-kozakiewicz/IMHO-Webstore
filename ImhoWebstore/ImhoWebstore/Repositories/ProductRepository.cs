using ImhoWebstore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ImhoWebstore.Repositories
{
    public class ProductRepository
    {
        public IEnumerable<Product> GetProducts()
        {
            return new List<Product>()
            {
                new Product(){ 
                    Id = 1, 
                    Name = "Stoicyzm", 
                    Category =  "Filozofia",
                    ImageUrl = "stoicyzm.jpg",
                    Description = "Stoicyzm stworzył kompletny system filozoficzny, który w teorii bytu był monistyczny, zasadniczo materialistyczny i deterministyczny, a w teorii poznania skłaniał się ku empiryzmowi, ale najbardziej jest znany ze swojej części etycznej. Etyka stoicka, która większości ludzi kojarzy się ze słowem \"stoicyzm\", opiera się na zasadzie osiągania szczęścia przez wewnętrzną dyscyplinę moralną, sumienne spełnianie tych obowiązków, które spadają na nas naturalną koleją rzeczy, oraz odcięcia swoich emocji od zdarzeń zewnętrznych, czyli utrzymywania stanu spokojnego szczęścia niezależnie od zewnętrznych warunków. W cenę pakietu wchodzi: dokładna definicja stoicyzmu, dzieła przedstawicieli stoicyzmu, 10GB nagrań wypowiedzi specjalistów stoicyzmu, rozmowa na chacie z prawdziwym stoikiem."
                },
                new Product(){ 
                    Id = 2, 
                    Name = "Liberalizm", 
                    Category = "Polityka",
                    ImageUrl = "liber.jpg",
                    Description = "Liberalizm (łac. liberalis – wolnościowy, od łac. liber – wolny) – ideologia i kierunek polityczny, według którego wolność jest nadrzędną wartością, ma charakter indywidualistyczny i przeciwstawia się kolektywizmowi. Innymi wartościami cenionymi przez liberałów są wartości demokratyczne, wolności i prawa obywatelskie czy własność prywatna i wolny rynek. W skład pakietu wchodzi: 5GB nagrań zwolenników poglądu, 10 cytatów, 10 anegdot i rozmowa z liberałem na forum."
                },
                new Product(){ 
                    Id = 3, 
                    Name = "Epikureizm", 
                    Category =  "Filozofia",
                    ImageUrl = "epikur.jpg",
                    Description = "Epikureizm - nakazuje człowiekowi wierzyć świadectwu zmysłów, cieszyć się życiem i korzystać z jego radości. „ Dobro to przyjemność-, czyli brak bólu” wg wyznawców tego nurtu. Epikurejczycy odrzucają wiarę w siły pozaziemskie, głoszą pochwałę życia na ziemi. Nazwa pochodzi od twórcy - Epikur, żyjącego na przełomie III i II w. p.n.e. Nie należy jednak mylić tego nurtu z hedonizmem, który rozwinął się później i preferował skrajna chęć użycia wszelkich możliwości rozkoszy.W cenę pakietu wchodzi: dokładna definicja epikureizmu, dzieła przedstawicieli epikureizmu, 10GB nagrań wypowiedzi specjalistów epikureizmu, rozmowa na chacie z prawdziwym epikurem. "
                },
                new Product(){ 
                    Id = 4, 
                    Name = "Socjalizm", 
                    Category =  "Polityka",
                    ImageUrl = "socjal.jpg",
                    Description = "Socjalizm (łac. societas – wspólnota) – 1. wieloznaczne pojęcie, odnoszące się do ideologii politycznej wywodzącej się z utopijnej filozofii politycznej rozwijanej w latach 30. i 40. XIX wieku we Francji lub 2. doktryna gospodarcza postulująca upowszechnienia świadczeń socjalnych i poddania gospodarki kontroli społecznej (poprzez instytucje państwowe, samorządowe, korporacyjne lub spółdzielcze). Częścią wspólną wszystkich odmian socjalizmu jest (częściowe lub całkowite) odrzucenie idei kapitalizmu oraz promowanie idei sprawiedliwości społecznej. W skład pakietu wchodzi: 5GB nagrań zwolenników poglądu, 10 cytatów, 10 anegdot i rozmowa z socjalistą na forum."
                },
                new Product(){ 
                    Id = 5, 
                    Name = "Deizm", 
                    Category =  "Religia",
                    ImageUrl = "deizm.jpg",
                    Description = "Deizm – nurt religijno-filozoficzny, którego cechą wspólną jest przekonanie, że racjonalnie można uzasadnić istnienie jedynie Boga bezosobowego, będącego konstruktorem świata rozumianego jako mechanizm oraz źródłem praw, według których ten mechanizm świata działa. Tak rozumiany Bóg nie ingeruje w raz ustanowione prawa. Deizm nie jest zwartym systemem ani szkołą filozoficzną. Rozpowszechnił się głównie w Europie, a także w Ameryce Północnej. W skład pakietu wchodzi: 20 wideo i gratis."
                },
                new Product(){ 
                    Id = 6, 
                    Name = "Teizm", 
                    Category =  "Religia",
                    ImageUrl = "teizm.jpg",
                    Description = "Teizm (gr. θεoς „bóg”) – wiara w istnienie Boga, bogów lub bogiń, którzy są osobami ingerującymi w losy świata lub jest on ich dziełem; czuwającymi nad biegiem wydarzeń lub podtrzymującymi świat w istnieniu oraz pogląd filozoficzno-religijny głoszący, że tacy bogowie istnieją. W skład pakietu wchodzi: 20 wideo i gratis."
                },
            };
        }
    }
}