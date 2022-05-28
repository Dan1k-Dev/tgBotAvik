using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramUaviak.DbClasses
{
    #region Таблица Groups (Группы) и ее объекты
    public class Groups
    {
        [Key]
        public int id { get; set; }
        public string number { get; set; }

        public virtual ICollection<Lessons> groups { get; set; }
    }
    #endregion
}
