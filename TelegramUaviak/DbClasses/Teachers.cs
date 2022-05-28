using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramUaviak.DbClasses
{
    #region Таблица Teachers (Преподаватели) и ее объекты
    public class Teachers
    {
        [Key]
        public int id { get; set; }
        public string short_name { get; set; }
        public string long_name { get; set; }
        public virtual ICollection<Lessons> teachers { get; set; }
    }
    #endregion
}
