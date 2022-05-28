using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramUaviak.DbClasses
{
    #region Таблица TypeLessons (Типы дисциплин) и ее объекты
    public class TypeLessons
    {
        [Key]
        public int IdType { get; set; }
        public string Type { get; set; }
        public virtual ICollection<Lessons> tipes { get; set; }
    }
    #endregion
}
