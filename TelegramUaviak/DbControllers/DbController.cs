using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using TelegramUaviak.DbClasses;

namespace TelegramUaviak.DbControllers
{
    #region Инициализация базы данных и создание строки подключения
    public class DbController : DbContext
    {
        public DbController() : base("ConnectDb")
        {
            //uselater (в будущем проект перейдет на другую БД для парсера, сейчас это тестовая версия)
        }
        public DbSet<Groups> groups { get; set; } //Инициализация таблицы Groups
        public DbSet<Lessons> lessons { get; set; } //Инициализация таблицы Lessons
        public DbSet<Teachers> teachers { get; set; } //Инициализация таблицы Teachers
        public DbSet<TimeTables> timeTables { get; set; } //Инициализация таблицы TimeTables

        public DbSet<TypeLessons> typeLessons { get; set; } //Инициализация таблицы TypeLessons
    }
    #endregion
}
