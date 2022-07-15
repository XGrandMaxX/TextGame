using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTextQuest
{
    class Program
    {
        static int roomNumber = 1;
        static bool hasKey = false;
        static bool MagicArt = false;
        static int deathCount = 0;
        static int mysteryCount = 1;
        public static void Main(string[] args)
        {
            Introduction();
            while (true)
            {
                if (roomNumber == 1) ActionFisrtRoom();  //Функция в 1 комнате бункера
                else if (roomNumber == 2) ActionSecondRoom(); //Функция в 2 комнате бункера
                else if (roomNumber == 3) ActionThirdKeyRoom(); //Функция в 3 комнате бункера (+ можно найти ключ)
                else if (roomNumber == 4) ActionDangerRoom(); //Функция в 4 комнате (+можно умереть от моба)
                else if (roomNumber == 5) ActionQuestRoom(); //Функция в 5 комнате (+квест, чтобы попасть в 6 комнату)
                else if (roomNumber == 6) ActionLastBunkerRoom(); //Функция в 6 комнате (ласт комната и потом нужно сваливать на корабль)

            }
        }

        static void ActionFisrtRoom()
        {
            Console.Clear();
            Console.WriteLine("Ты находишься в 1-й комнате бункера");
            Console.WriteLine("");
            Console.WriteLine("Буря снаружи до сих пор бушует");
            Console.WriteLine("Устав, ты разжог костёр из подручных средств, поел и лёг спать");
            Console.WriteLine("Проснувшись ты принял решение");
            Console.WriteLine("");
            int option;
            if (MagicArt == true)
            {
                Console.WriteLine("1. Использовать огненный шар и выйти из бункера");
                option = GetIntInRange(1);
                if (option == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Выйдя наружу с огненным шаром ты даже не замечаешь бурю, хоть она и не утихает");
                    Console.WriteLine("Ты находишь путь до корабля и успешно осматриваешь его");
                    Console.WriteLine("Спустя 2 часа ты выявляешь и частично устраняешь поломки корабля");
                    Console.WriteLine("");
                    Console.WriteLine("Корабль готов к взлёту, хоть и не полностью починен");
                    Console.WriteLine("Взлетая, ты слышишь странный звук снаружи корабля");
                    Console.WriteLine("Перед взлётом ты решаешь проверить, что это было");
                    Console.WriteLine("Снаружи, на хвосте корабля ты видишь страшное чудовище, не похожее на человека, оно заметило тебя и атакует");
                    Console.WriteLine("");
                    Console.WriteLine("Доступные действия");
                    Console.WriteLine("1. Вступить в бой с монстром атакуя его огненным шаром");
                    Console.WriteLine("2. Бежать на корабль и улетать");
                    option = GetIntInRange(2);
                }
                if (option == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Вступив в бой ты нанёс монстру пару ожогов");
                    Console.WriteLine("");
                    Console.WriteLine("Нажмите Enter для продолжения....");
                    Console.ReadLine();
                    Console.WriteLine("Монстр как будто ничего не почуствовал и теперь атакует в ответ");
                    Console.WriteLine("Схватив тебя за голову монстр отрывает её и ты погибаешь");
                    Console.WriteLine("");
                    Console.WriteLine("Нажмите Enter для завершения игры....");
                    deathCount += 1;
                    hasKey = false;
                    MagicArt = false;
                    Introduction();
                }
                else if (option == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Ты сбегаешь от монстра пока еще не поздно");
                    Console.WriteLine("Корабль взлетает и ты улетаешь на землю");
                    Console.WriteLine("Монстр, повредив хвост корабля отцепился и упал с большой высоты");
                    Console.WriteLine("---======================================---");
                    Console.WriteLine("!!!Игра закончена, спасибо за прохождение!!!");
                    Console.WriteLine("---======================================---");
                    Console.WriteLine("Ваше количество смертей = " + deathCount);
                    Console.WriteLine("С какой попытки была решена загадка = " + mysteryCount);
                    if (deathCount < 1)
                    {
                        Console.WriteLine("Поздравляем, ты прошел игру ни разу не умерев, это отличный результат!");
                        Console.WriteLine("");
                        Console.WriteLine("Нажмите Enter для завершения игры....");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                    else if(deathCount <1 && mysteryCount < 2)
                    {
                        Console.WriteLine("Поздравляем, ты прошел игру ни разу не умерев и решив загадку с 1 раза, это идеальный результат!");
                        Console.WriteLine("");
                        Console.WriteLine("Нажмите Enter для завершения игры....");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Нажмите Enter для завершения игры....");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                }
            }
            else
            {
                Console.WriteLine("1. Выйти из бункера");
                Console.WriteLine("2. Зайти в следующую комнату бункера");
                option = GetIntInRange(2);
            }

            if (option == 1)
            {
                Console.WriteLine("Ты выходишь из бункера в сильную бурю, спустя минуту ты погибаешь от холода так и не дойдя до корабля");
                Console.WriteLine("");
                Console.WriteLine("Нажмите Enter для завершения игры....");
                deathCount += 1;
                hasKey = false;
                MagicArt = false;
                Console.ReadLine();
                Introduction();
            }
            else if (option == 2)
            {
                Console.WriteLine("Ты зашел во 2-ю комнату бункера");
                Console.WriteLine("");
                Console.WriteLine("Нажмите Enter для продолжения....");
                roomNumber = 2;
                Console.ReadLine();
            }
        }
            static void ActionSecondRoom()
        {
            Console.Clear();
            Console.WriteLine("Ты находишься во 2-й комнате бункера");
            Console.WriteLine("");
            Console.WriteLine("Внутри комната абсолютно пустая, нет ничего, кроме голых стен и 2-ух дверей");
            Console.WriteLine("Возле каждой двери есть таблички, ты внимательно читаешь их");
            Console.WriteLine("На двери слева надпись: 'Серверная' ");
            Console.WriteLine("На двери справа надпись: 'トップシークレット' ");
            Console.WriteLine("");
            Console.WriteLine("Доступные действия");
            Console.WriteLine("1. Вернуться в 1-ю комнату");
            Console.WriteLine("2. Зайти в дверь слева");
            Console.WriteLine("3. Зайти в дверь справа");
            int option = GetIntInRange(3);

            if (option == 1)
            {
                Console.WriteLine("Ты возвращаешься в 1-ю комнату бункера");
                Console.WriteLine("");
                Console.WriteLine("Нажмите Enter для продолжения....");
                roomNumber = 1;
                Console.ReadLine();
            }
            else if (option == 2)
            {
                Console.WriteLine("Ты пробуешь открыть левую дверь и кажется она поддаётся");
                Console.WriteLine("");
                Console.WriteLine("Нажмите Enter для продолжения....");
                roomNumber = 3;
                Console.ReadLine();
            }
            else if (option == 3)
            {
                CheckKey();
            }
        }
        static void CheckKey()
        {
            Console.WriteLine("Ты пробуешь открыть правую дверь");
            if (!hasKey)
            {
                Console.WriteLine("дверь никак не поддаётся, возможно нужен ключ");
                Console.WriteLine("");
                Console.WriteLine("Нажмите Enter для продолжения....");
            }
            else
            {
                Console.WriteLine("Ты вставляешь недавно найденный ключ, замок со крипом поддаётся и ты проходишь внутрь");
                Console.WriteLine("");
                Console.WriteLine("Нажмите Enter для продолжения....");
                roomNumber = 4;
            }
            Console.ReadLine();

        }
        static void ActionThirdKeyRoom()
        {
            Console.Clear();
            Console.WriteLine("Ты находишься в 3-й комнате бункера");
            Console.WriteLine("");
            Console.WriteLine("Внутри комнаты находится пульт управления, различные механизмы и пара ящиков");
            int option;
            Console.WriteLine("Доступные действия");
            Console.WriteLine("1. Вернуться во 2-ю комнату");
            if (!hasKey)
            {
                Console.WriteLine("2. Обыскать ящики");
                option = GetIntInRange(2);
            }
            else option = GetIntInRange(1);

            if (option == 1)
            {
                Console.WriteLine("Ты вернулся во 2-ю комнату бункера");
                Console.WriteLine("");
                Console.WriteLine("Нажмите Enter для продолжения....");
                roomNumber = 2;
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Обыскиывая ящики ты находишь лишь ненужные провода и различный хлам");
                Console.WriteLine("Спустя 5 минут поисков тебе удалось найти ключ");
                Console.WriteLine("");
                Console.WriteLine("Нажмите Enter для продолжения....");
                hasKey = true;
                Console.ReadLine();
            }

        }
        static void ActionDangerRoom()
        {
            Console.Clear();
            Console.WriteLine("В комнате с надписью トップシークレット сплошная темнота и лишь в конце виднеется свет");
            Console.WriteLine("Пройдя чуть дальше в глубь комнаты, ты слышишь странный звук....");
            Console.WriteLine("");
            Console.WriteLine("Доступные действия");
            Console.WriteLine("1. Вернуться во 2-ю комнату");
            Console.WriteLine("2. Быстро добежать до света");
            Console.WriteLine("3. Обследовать тёмные углы этой комнаты");
            int option = GetIntInRange(3);
            if (option == 1)
            {
                Console.WriteLine("Ты вернулся во 2-ю комнату");
                Console.WriteLine("");
                Console.WriteLine("Нажмите Enter для продолжения....");
                roomNumber = 2;
                Console.ReadLine();
            }
            else if (option == 2)
            {
                Console.WriteLine("Подойдя ближе к свету, ты понял, что этот свет исходит из двери");
                Console.WriteLine("В этой тёмной комнате тебе было не по себе, недолго думая ты заходишь внутрь");
                Console.WriteLine("");
                Console.WriteLine("Нажмите Enter для продолжения....");
                roomNumber = 5;
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Преодолевая страх ты идешь исследовать тёмные углы этой комнаты");
                Console.WriteLine("Ты натыкаешься на открытый ящик с каким-то блестящим предметом, но вновь слышишь странный звук позади себя");
                Console.WriteLine("Не обращая внимание на звук ты продолжаешь осматривать ящик и забираешь предмет");
                Console.WriteLine("Оглянувшись, ты видишь страшное существо, не похожее на человека, оно отрывает тебе голову и ты погибаешь");
                Console.WriteLine("");
                Console.WriteLine("Нажмите Enter для завершения игры....");
                deathCount += 1;
                hasKey = false;
                MagicArt = false;
                Console.ReadLine();
                Introduction();
            }

        }
        static void ActionQuestRoom()
        {
            Console.Clear();
            Console.WriteLine("Внутри комнаты оказалось очень даже уютно");
            Console.WriteLine("Оглядевшись вокруг ты замечаешь дверь и текст на стенах");
            Console.WriteLine("");
            Console.WriteLine("Доступные действия");
            Console.WriteLine("1. Вернуться в тёмную комнату");
            Console.WriteLine("2. Подойти к двери");
            int option = GetIntInRange(2);
            if (option == 1)
            {
                Console.WriteLine("Ты вернулся обратно в тёмную комнату");
                Console.WriteLine("");
                Console.WriteLine("Нажмите Enter для продолжения....");
                roomNumber = 4;
                Console.ReadLine();
            }
            else CompleteQuest();
        }
        static void CompleteQuest()
        {
            Console.WriteLine("Подойдя к двери ты обнаружил, что на ней висит кодовый замок");
            Console.WriteLine("Чтобы открыть его нужно ввести слово из 9 букв, хм... что это за слово...");
            Console.WriteLine("Недолго подумав ты решаешь разглядеть надписи на стенах, на них написано:");
            Console.WriteLine("============================================================");
            Console.WriteLine("Есть я у мужа, у зверя, у мёртвого камня, у облака.");
            Console.WriteLine("В душу не лезу, ловлю изменения облика.");
            Console.WriteLine("Дева, вглянув на меня, приосанится.");
            Console.WriteLine("Старец, нахмурится, дитятко расхулиганится.");
            Console.WriteLine("Кто я? ('Последняя стрка написана прямо под дверью')");
            Console.WriteLine("");
            Console.WriteLine("Теперь нужно ввести слово");
            string word = Console.ReadLine();
            while (word.ToLower() != "отражение") //toLower принимает любой регистр, т.к визуально ты пишешь как хочешь, но программно оно конвертирует в нижний регистр.
            {
                Console.WriteLine("Ты ввел неверное слово, попробуй еще раз");
                mysteryCount += 1;
                word = Console.ReadLine();
            }
            Console.WriteLine("Комната открылась и ты осторожно заходишь внутрь");
            Console.WriteLine("");
            Console.WriteLine("Нажмите Enter для продолжения....");
            roomNumber = 6;
            Console.ReadLine();

        }
        static void ActionLastBunkerRoom()
        {
            Console.Clear();
            Console.WriteLine("Внутри комнаты нет ничего кроме стенда по середине");
            Console.WriteLine("На стенде лежит странный, покрытый огнём предмет");
            Console.WriteLine("Ты решаешь подойти и осмотреть его, уже позже осознавая, что это некий огненный артефакт шарообразной формы, который с лёгкостью позволит передвигаться в бурю");
            Console.WriteLine("");
            int option;

            Console.WriteLine("Доступные действия");
            Console.WriteLine("1. Вернуться обратно в комнату с загадкой");
            if (!MagicArt)
            {
                Console.WriteLine("2. Осмотреть и забрать огненный шар");
                option = GetIntInRange(2);
            }
            else option = GetIntInRange(1);

            if (option == 1)
            {
                Console.WriteLine("Ты вернулся в комнату с загадкой, однако дверь за тобой закрылась и нужно ввести слово еще раз");
                Console.WriteLine("");
                Console.WriteLine("Нажмите Enter для продолжения....");
                roomNumber = 5;
                Console.ReadLine();
            }
            else if (option == 2)
            {
                Console.WriteLine("Забрав артефакт ты возвращаешься в начало бункера");
                Console.WriteLine("Возможно стоит попробовать выйти наружу имея огненный артефакт, буря не должа более быть помехой");
                Console.WriteLine("");
                Console.WriteLine("Нажмите Enter для продолжения....");
                MagicArt = true;
                roomNumber = 1;
                Console.ReadLine();
            }
        }
        static void Introduction()
        {
            Console.Clear();
            Console.WriteLine("Пожалуйста, проходите игру не закрывая консоль, спасибо за понимание!");
            Console.WriteLine("Нажимайте Enter для продолжения....");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Ты смутно помнишь где ты...даже кто ты...");
            Console.ReadLine();
            Console.WriteLine("Кажется, что сейчас нужно осмотреться и понять что происходит....");
            Console.ReadLine();
            Console.WriteLine("Корабль, ты видишь разрушеный корабль.....И кажется, ты не на земле....");
            Console.ReadLine();
            Console.WriteLine("Перед собой ты видишь различный мусор, обломки корабля и непонятный объект похожий на бункер");
            Console.ReadLine();
            Console.WriteLine("Ты решаешь спуститься туда и переночивать из-за надвигающейся бури, а после осмотреть и починить корабль....");
            Console.ReadLine();
            roomNumber = 1;
        }
        static int GetIntInRange(int optionnumber)
        {
            string input = Console.ReadLine();
            int number = -1;
            bool isConverted = int.TryParse(input, out number);
            bool isInRange = number >= 1 && number <= optionnumber;

            while (!isConverted || !isInRange)
            {
                Console.WriteLine("Не верная опция, введите значение еще раз");
                input = Console.ReadLine();
                isConverted = int.TryParse(input, out number);
                isInRange = number >= 1 && number <= optionnumber;
            }
            return number;
        }
    }
}
