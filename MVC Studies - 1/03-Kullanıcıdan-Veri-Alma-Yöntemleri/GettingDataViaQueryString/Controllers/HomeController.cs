using GettingDataViaQueryString.Models;
using Microsoft.AspNetCore.Mvc;

namespace GettingDataViaQueryString.Controllers
{
    /*
     * Ziyaretçinin web sitemizde bir sayfadan başka bir sayfaya geçişi yada sayfanın sunucuya gidip geri gelmesi esnasında,
     * bazı bilgileri saklamak ve gerektiğinde tekrar kullanmak isteyebiliriz. Bu gibi durumlarda durum yönetimi nesneleri 
     * kullanılır. QueryString de bu nesnelerden biridir ve istenen bilgiyi gidilecek olan sayfanın adresine (url'sine) ekleyerek 
     * taşımamızı sağlar. 
     * 
     * www.btdersleri.com/ders.aspx?konu=148
     * 
     * Örneğin yukarıdaki url'ye bakarsanız adresin sonuna ?konu=148 şeklinde bir bilgi eklendğini görürsünüz. 
     * ? karakterinden sonra querystring ile taşınacak bilgiler yazılır ki bu kısım parametre ve değer olmak üzere,
     * iki kısımdan oluşur. Burada parametre konu, değeri ise 148'dir. Birden fazla parametre ve değer taşınacak ise 
     * aralarına & karakteri konulur.
     * 
     * Örnek: ders.aspx?q1=Ali&q2=Yılmaz&q3=Esnaf
     */

    /*
     * Sayfalar arası veri taşıma yollarından en kolayı olan QueryString yöntemi, URL üzerindeki stringler ile verileri taşımaya 
     * yarar. İnternette gezerken bir çok sitenin url adresleri garip harf ve sembollerle dolduğu dikkatinizi çekmiştir. 
     * İşte bu karakterler sunucu tarafında adrese eklenip sayfayla birlikte hareket eden QueryString'dir. Yeni sayfada bu link 
     * alınıp içindeki veriler sayfaya yerleştirilir. Fazla değerli verilerin olmadığı anlarda tercih edilmesi gereken yöntemdir 
     * çünkü taşınan veriler kullanıcının direkt gözü önündedir. QueryString'in kullanımı çok kolaydır. Diğer bir güzel yanı ise, 
     * URL adresinin içinde bulunmasından dolayı, sayfanın yer imlerine kaydedilmesi durumunda kendisinin de saklanmasıdır. 
     * Böylece yer imine gidildiğinde, sayfa saklandığı haldeki şekliyle açılır.  
     */

    public class HomeController : Controller
    {

        public string Index()
        {
            return "GettingDataViaQueryString ->> Index. Application is running.";
        }

        // Aşağıdaki metodun çalışması için tarayıcının arama sekmesine "/home/QueryString?name=Halim&surname=Ocaklı" yazdık.
        public string QueryString(string name, string surname)
        {
            return $"GettingDataViaQueryString ->> QueryString. Application is running.\n" +
                $"Name: {name} - Surname: {surname}";
        }

        // Aşağıdaki metodun çalışması için tarayıcının arama sekmesine
        // "home/QueryStringClass?id=10&productname=Television&categoryName=Electronics" yazdık.
        public string QueryStringClass(Product product)
        {
            return $"GettingDataViaQueryString ->> QueryStringClass. Application is running\n" +
                $"Product ID: {product.ID}\n" +
                $"Producy Name: {product.ProductName}\n" +
                $"Product Category Name: {product.CategoryName}";
        }

        // Aşağıdaki metodun çalışması için tarayıcının arama sekmesine
        // "home/QueryStringClassAndVariable?id=10&productname=Television&categoryName=Electronics&customername=Halim Can Ocaklı" yazdık.
        public string QueryStringClassAndVariable(Product product, string customerName)
        {
            return $"GettingDataViaQueryString ->> QueryStringClassAndVariable. Application is running\n" +
                $"Customer Name: {customerName}\n" +
                $"Product ID: {product.ID}\n" +
                $"Producy Name: {product.ProductName}\n" +
                $"Product Category Name: {product.CategoryName}";
        }
    }
}
