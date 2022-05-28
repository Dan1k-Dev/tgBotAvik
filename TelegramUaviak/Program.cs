using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types.ReplyMarkups;
using TelegramUaviak.DbControllers;
using TelegramUaviak.DbClasses;
using Telegram.Bot.Types;

namespace TelegramUaviak
{
    class Program
    {
        static DbController dbController = new DbController(); //Подлючение к БД
        private static string token { get; set; } = "5597495005:AAFZTTz585ill9hE96aKf7SoIM2spdiK7mc"; //Токен-ключ бота
        private static TelegramBotClient client; //Инициализация бота

        #region Запуск и работа бота
        [Obsolete]
        static void Main(string[] args)
        {
            client = new TelegramBotClient(token);
            client.StartReceiving();
            client.OnMessage += OnMessageHandler;
            Console.ReadLine();
            client.StopReceiving();
        }
        #endregion

        #region Логика телеграм бота
        /// <summary>
        /// Если сообщение пришло, то бот вытягивает необходимые запрошенные данные и выводит их
        /// Тестовый вариант
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        [Obsolete]
        private static async void OnMessageHandler(object sender, MessageEventArgs e)
        {
            var msg = e.Message;
            var req = dbController.groups.Select(x => x.number).FirstOrDefault().ToString(); //тестовый запрос к базе на вывод
            string ans = req.ToString(); //тестовый вывод значения из базы

            if (msg.Text != null)
            {
                Console.WriteLine($"Пришло сообщение с текстом: {msg.Text}");
                await client.SendTextMessageAsync(msg.Chat.Id, ans, replyToMessageId: msg.MessageId);
            }
        }
        #endregion
    }
}
