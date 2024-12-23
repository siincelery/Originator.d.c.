using Microsoft.EntityFrameworkCore;


namespace Origi.Pages.Models
{
    public class ApplicationContext:DbContext
    {
        public DbSet<Service> Services { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Admin> Admins { get; set; }
     
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Андрей\\Documents\\Originat.mdf;Integrated Security=True;Connect Timeout=30");
        }
        // Метод для заполнения таблицы данными
        public void SeedData()
        {

            //var service = new List<Service>
            //{
            //    new Service { Name_Service = "Контент-план", Description = "Контент-план на 2 недели для блога, бизнес-страницы, канала, группы", Price = 1000, Emloyee = "Кристина" },
            //    new Service { Name_Service = "Контент-план", Description = "Контент-план на месяц для блога, бизнес-страницы, канала, группы", Price = 1700, Emloyee = "Кристина" },
            //    new Service { Name_Service = "Статья", Description = "", Emloyee = "Кристина" },
            //    new Service { Name_Service = "Сценарий", Description = "Сценарий для ролика 15-30 секунд", Price= 1000, Emloyee = "Кристина" },
            //    new Service { Name_Service = "Сценарий", Description = "Сценарий для ролика до минуты", Price= 2000, Emloyee = "Кристина" },
            //    new Service { Name_Service = "Коррекция постов", Description = "Коррекция постов, поиск подходящих стилистических решений. За один пост до 4100 знаков", Price=400, Emloyee = "Кристина" },
            //    new Service { Name_Service = "Пост", Description = "Пост для любой социальной сети до 2000 знаков", Price= 500, Emloyee = "Кристина" },
            //    new Service { Name_Service = "Дизайн постера", Description = "Дизайн постера любого формата", Price= 800, Emloyee = "Ангелина" },
            //    new Service { Name_Service = "Оформление поста", Description = "Визуальное оформление поста для блога, бизнес-страницы, канала, группы", Price= 700, Emloyee = "Ангелина" },
            //    new Service { Name_Service = "Создание визуала", Description = "Выбор концепции и основных цветов для блога, бизнес-страницы, канала, группы", Price= 1000, Emloyee = "Ангелина" },
            //    new Service { Name_Service = "Дизайн сайта", Description = "", Price= 5000, Emloyee = "Ангелина" },
            //    new Service { Name_Service = "Оформление группы Вконтакте", Description = "Визуальное оформление для блога, бизнес-страницы, канала, группы", Price= 2500, Emloyee = "Ангелина" },
            //    new Service { Name_Service = "Базовый Вконтакте", Description = "Cоздадим визуал, составим контент-план постов на выбранный срок, напишем текст описания, меню, статуса, постов (за каждый оплата отдельно), при необходимости отредактируем Ваш",Price= 8000, Emloyee = "Кристина и Ангелина" },
            //    new Service { Name_Service = "Базовый Нельзяграм", Description = "Cоздадим визуал, cоставим контент-план для постов на выбранный срок (из уже написанных или поможем написать новые)",Price=7000, Emloyee = "Кристина и Ангелина" },
            //    new Service { Name_Service = "Продвинутый Вконтакте", Description = "Cоздадим визуал, cсоставим контент-план на выбранный срок, напишем текст описания, меню, статуса, постов (за каждый оплата отдельно), при необходимости отредактируем Ваш, берем на себя ведение стены группы (месяц), закупаем рекламу на оговоренный заранее бюджет", Price=20000, Emloyee = "Кристина и Ангелина"  },
            //    new Service { Name_Service = "Продвинутый Нельзяграм", Description = "Продвинутый Нельзяграм', 'Cоздадим визуал, cсоставим контент-план для постов на выбранный срок (из уже написанных или поможем придумать новые), напишем сторителлинг, который повысит вовлеченность аудитории",Price = 15000, Emloyee = "Кристина и Ангелина" },
            //};

            //// Добавляем данные в контекст
            //Services.AddRange(service);
            //SaveChanges();
            //var client = new List<Client>
            //{
            //     new Client { Name_client="Ангелина", Phone_cleint= "89273451787", Url_client="@siincelery" }
            //}; 
            //Clients.AddRange(client);
            //    SaveChanges();


            if (!Admins.Any())
            {
                // Добавляем тестовые данные для админов
                Admins.AddRange(
                    new Admin { Login_Admin = "admin1", Password = "123" }
                );
                SaveChanges();
            }


        }
    }
}
