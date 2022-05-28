using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramUaviak.DbClasses
{
    #region Таблица TimeTables (Расписание) и ее объекты
    public class TimeTables
    {
        [Key]
        public int id { get; set; }
        public DateTime date { get; set; }
        public virtual ICollection<Lessons> tabels { get; set; }
    }
    #endregion
}
