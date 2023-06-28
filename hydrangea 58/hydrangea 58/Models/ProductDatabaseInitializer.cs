using System.Collections.Generic;
using System.Data.Entity;

namespace WingtipToys.Models
{
    public class ProductDatabaseInitializer : DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));
        }

      private static List<Category> GetCategories()
        {
            var categories = new List<Category> {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "машинки"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "самолетики"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "грузовички"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "кораблики"
                },
                new Category
                {
                    CategoryID = 5,
                    CategoryName = "ракеты"
                },
            };

            return categories;
        } 

        private static List<Product> GetProducts()
        {
            var products = new List<Product> {
                new Product
                {
                    ProductID = 1,
                    ProductName = "Кабриолет",
                    Description = "Этот автомобиль с откидным верхом быстр! Двигатель питается от нейтринной батареи (не входит в комплект)." +
                                  "заведи его и гони!",
                    ImagePath="carconvert.png",
                    UnitPrice = 22.50,
                    CategoryID = 1
               },
                new Product
                {
                    ProductID = 2,
                    ProductName = "Раритетная машинка",
                    Description = "В этой игрушечной машинке нет ничего старого, кроме ее внешнего вида. Совместим с другими старыми игрушечными машинками.",
                    ImagePath="carearly.png",
                    UnitPrice = 15.95,
                     CategoryID = 1
               },
                new Product
                {
                    ProductID = 3,
                    ProductName = "Быстрая машинка",
                    Description = "Да, эта машина быстрая, но она также плавает в воде.",
                    ImagePath="carfast.png",
                    UnitPrice = 32.99,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 4,
                    ProductName = "Супер быстрая машинка",
                    Description = "Используйте этот сверхбыстрый автомобиль, чтобы развлекать гостей. Освещение и двери работают!",
                    ImagePath="carfaster.png",
                    UnitPrice = 8.95,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 5,
                    ProductName = "Гонщик 60-х",
                    Description = "Эта старая гоночная машинка может летать (с помощью пользователя). Гравитация управляет продолжительностью полета." +
                                  "Батарейки не требуются.",
                    ImagePath="carracer.png",
                    UnitPrice = 34.95,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 6,
                    ProductName = "Первоклассный самолет",
                    Description = "Настоящая игрушка-самолет. Отличается реалистичным цветом и деталями.",
                    ImagePath="planeace.png",
                    UnitPrice = 95.00,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 7,
                    ProductName = "Планер",
                    Description = "Этот забавный планер сделан из настоящего бальзового дерева. Требуется некоторая сборка.",
                    ImagePath="planeglider.png",
                    UnitPrice = 4.95,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 8,
                    ProductName = "Бумажный самолетик",
                    Description = "Этот бумажный самолетик не похож ни на один другой бумажный самолетик. Требуется некоторое складывание.",
                    ImagePath="planepaper.png",
                    UnitPrice = 2.95,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 9,
                    ProductName = "Пропеллерный самолет",
                    Description = "Самолет с приводом от резиновой ленты оснащен двумя колесами.",
                    ImagePath="planeprop.png",
                    UnitPrice = 32.95,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 10,
                    ProductName = "Ранний грузовик",
                    Description = "У этого игрушечного грузовика настоящий бензиновый двигатель. Требует регулярной настройки.",
                    ImagePath="truckearly.png",
                    UnitPrice = 15.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 11,
                    ProductName = "Пожарная машина",
                    Description = "Вы получите бесконечное удовольствие от этой пожарной машины размером в четверть дюйма.",
                    ImagePath="truckfire.png",
                    UnitPrice = 26.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 12,
                    ProductName = "Большой грузовик",
                    Description = "Этот забавный игрушечный грузовик можно использовать для буксировки других грузовиков, которые не такие большие.",
                    ImagePath="truckbig.png",
                    UnitPrice = 29.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 13,
                    ProductName = "Большой корабль",
                    Description = "Это лодка или корабль? Позвольте этому плавучему средству принимать решение, используя свое" +
                                  "компьютерный мозг с искусственным интеллектом!",
                    ImagePath="boatbig.png",
                    UnitPrice = 95.00,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 14,
                    ProductName = "Бумажный кораблик",
                    Description = "Плавающее развлечение для всех! Эту игрушечную лодку можно собрать за считанные секунды. Плавает в течение нескольких минут!" +
                                  "Требуется некоторое складывание.",
                    ImagePath="boatpaper.png",
                    UnitPrice = 4.95,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 15,
                    ProductName = "Парусная лодка",
                    Description = "Опустите эту забавную игрушечную парусную лодку в воду и отпустите ее!",
                    ImagePath="boatsail.png",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 16,
                    ProductName = "Ракета",
                    Description = "Эта забавная ракета поднимется на высоту 200 футов.",
                    ImagePath="rocket.png",
                    UnitPrice = 122.95,
                    CategoryID = 5
                }
            };

            return products;
        }
    }
}