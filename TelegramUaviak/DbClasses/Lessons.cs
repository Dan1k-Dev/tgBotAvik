using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramUaviak.DbClasses
{
    #region Таблица Lessons (Учебные дисциплины) и ее объекты 
    public class Lessons
    {
        [Key]
        public int id { get; set; }
        public int id_timetable { get; set; } // Вторичный ключ от таблицы TimeTables
        public int number { get; set; }
        public string subject { get; set; }
        public string cabinet { get; set; }
        public int types { get; set; } // Вторичный ключ от таблицы TypeLesons
        public int id_group { get; set; } // Вторичный ключ от таблицы Groups
        public int id_teacher { get; set; } // Вторичный ключ от таблицы Teachers
    }
    #endregion
}
