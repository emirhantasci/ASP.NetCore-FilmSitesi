using Microsoft.AspNetCore.Mvc;
using SinemaAppWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SinemaAppWeb.Data
{
    public class MovieRepository
    {
        private static List<Movie> _movies = null; //_movies isimli boş bir liste oluşturduk.
        static MovieRepository()
        {
            _movies = new List<Movie>()
            {
                new Movie(){ Id=1, Name="Parasite", Description="Sınıfsal çatışmayı anlatan bir film. Birçok dalda ödüle layık görüldü ve dünya genelinde milyonlarca izlendi.", Yonetmen= "Bong Joon-Ho", Oyuncular="Cho Yeo-jeong, Park So-dam, Choi Woo-shik, Jeong Ji-so, Lee Sun-gyun", ImageUrl="parasite.jpg", CategoryId=1},
                new Movie(){ Id=2, Name="Cinayet Süsü", Description="Ali Atay tarafından yönetilen ve Feyyaz Yiğit-Ali Atay ikilisinin senaristliğini üstlendiği bu film güldürürken çok güzel bir son ile aynı zamanda düşündürüyor.", Yonetmen="Ali Atay", Oyuncular="Feyyaz Yiğit, Binnur Kaya, Cengiz Bozkurt, Mehmet Özgür, Mert Denizmen, Uğur Yücel", ImageUrl="cinayetsusu.jpg", CategoryId=4},
                new Movie(){ Id=3, Name="Aile Arasında", Description="Daha önce Avrupa Yakası eserinde yan yana gelen Gülse Birsel-Engin Günaydın ikilisi ve Gülse Birsel'in diğer dizilerinde oynattığı pekçok oyuncu bu filmde yer alıyor. Bir evliliğin sona ermesiyle başlayan hikaye gayet sürükleyici ve komik.", Yonetmen="Ozan Açıktan" , Oyuncular="Engin Günaydın, Gülse Birsel, Demet Evgar, Su Kutlu, Fatih Artman,  Erdal Özyağcılar", ImageUrl="ailearasinda.jpg", CategoryId=4},
                new Movie(){ Id=4, Name="Marslı", Description="Mars'a bir operasyona gönderilen NASA astronotlarından birinin kaza geçirmesiyle öldü sanılıp Mars'ta bırakılması ile başlayan olaylarda astronot aslında ölmüyor. Mars'ta yaklaşık 600 sol yaşayan astronot aç kalmamak, oksijensiz kalmamak için pekçok şeyle mücadele ediyor. Bu mücadeleyi konu alan film bir kitaptan uyarlama.",Yonetmen="Ridney Scott", Oyuncular="Matt Damon, Jessica Chastain, Kate Mara, Chiwetel Ejiofor, Jeff Daniels" ,ImageUrl="marsli2.jpg", CategoryId=3}
                
            };
        }

        public static List<Movie> Movies //Tüm filmleri geriye döndürecek
        {
            get
            {
                return _movies;
            }
        }

        public static void AddMovie(Movie film) //gönderilen filmi repository'e ekleyecek
        {
            _movies.Add(film);
        }


        public static Movie GetById(int id) //gelen id bilgisini karşılaştırıp o id'nin bulunduğu filmi geri gönderecek
        {
            return _movies.FirstOrDefault(i => i.Id == id);
        }
    }
}
