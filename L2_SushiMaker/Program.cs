using System;

namespace L2_SushiMaker
{
    internal class Program
    {
        static void AddPartIngridient(string ingridient, int minValue, int curValue)
        {
            string action = string.Empty;
            while (curValue != minValue)
            {
                try
                {
                    if (curValue < minValue) { action = "добавить"; } else { action = "отнять"; }
                    Console.WriteLine($"Текущее количество {ingridient} в кастрюле {curValue} грамм(а).Необходимо {action} ещё {Math.Abs(minValue - curValue)} грамм(а)\nВведите количество: ");
                    int tempcount = Convert.ToInt32(Console.ReadLine());
                    curValue += tempcount;
                    if (curValue < 0) curValue = 0;
                }
                catch (Exception ex) { Console.WriteLine("Ошибка! : " + ex.Message + "\nПопробуйте ещё раз.\n"); }
            }
        }
        static void RinseRice()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Промываем рис...\n");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Достаточно.\n");
            Thread.Sleep(500);
        }
        static void NextStepMessage()
        {
            Console.WriteLine("Отлично! Перейдём к следующему шагу.\n");
        }

        static uint EnterFireLevel()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите режим: ");
                    uint fireLevel = Convert.ToUInt32(Console.ReadLine());
                    if(fireLevel > 3) { throw new Exception("Такого режима не существует."); }
                    return fireLevel;
                }
                catch (Exception ex) { Console.WriteLine("Ошибка! : " + ex.Message + "\nПопробуйте ещё раз.\n"); }
            }
        }

        static uint EnterCookingTime()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите время варки риса в минутах: ");
                    uint cookingTime = Convert.ToUInt32(Console.ReadLine());
                    return cookingTime;
                }
                catch (Exception ex) { Console.WriteLine("Ошибка! : " + ex.Message + "\nПопробуйте ещё раз.\n"); }
            }
        }
        static void Main(string[] args)
        {
            int rollCount = 0;
            while(true)
            {
                try
                {
                    Console.WriteLine("Какое количество роллов вы хотите приготовить?");
                    rollCount = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception ex) { Console.WriteLine("Ошибка! : " + ex.Message + "\nПопробуйте ещё раз.\n"); }
            }

            if(rollCount == 0) { Console.WriteLine("Правильно, лучше заказать доставку :)"); return; }
            
            Console.WriteLine("Отлично сегодня мы приготовим роллы! \np.s. рис нужно варить ровно 20 минут и только на маленьком огне!\n");
            
            int minRiceCount = 160 * rollCount;
            int minWaterCount = Convert.ToInt32(minRiceCount * 1.1);
            int minNoriCount = 3 * rollCount;


            Console.WriteLine($"Берём кастрюлю и насыпаем ровно {minRiceCount} грамм(а) риса.   ( + добавить | - отнять )\n");

            AddPartIngridient("риса",minRiceCount,0);

            NextStepMessage();

            RinseRice();

            NextStepMessage();

            Console.WriteLine($"Теперь наливаем в кастрюлю ровно {minWaterCount} грамм(а) воды.( + добавить | - отнять )\n");

            AddPartIngridient("воды", minWaterCount, 0);

            NextStepMessage();

            Console.WriteLine("Ставим кастрюлю на плиту...\n");

            Console.WriteLine($"Выберите режим огня (0 - минимальный, 1 - средний, 2 - сильный) :");

            uint fireLevel = EnterFireLevel();

            uint cookingTime = EnterCookingTime();

            for (uint i = 0; i < cookingTime; i++)
            {
                Console.WriteLine($"Осталось ждать {cookingTime - i} минут(ы)");
                Thread.Sleep(500);
            }

            if(fireLevel != 0 | cookingTime != 20) { Console.WriteLine("Неудача!К сожалению вы испортили рис.");return;}

            NextStepMessage();

            for(int i = 0; i < rollCount; i++)
            {
                Console.WriteLine($"Готовим ролл #{i + 1}");
                Thread.Sleep(500);
                Console.WriteLine("Нарезаем рыбу...");
                Thread.Sleep(500);
                Console.WriteLine("Выкладываем лист нори...");
                Thread.Sleep(500);
                Console.WriteLine("Выкладываем рис...");
                Thread.Sleep(500);
                Console.WriteLine("Выкладываем рыбу...");
                Thread.Sleep(500);
                Console.WriteLine("Скручиваем ролл...");
                Thread.Sleep(500);
                Console.WriteLine("Разрезаем на 8 частей...");
                Thread.Sleep(500);
                Console.WriteLine("Готово!\n");
            }

            Console.WriteLine("Поздравляем! Роллы успешно приготовлены!");

        }

    }
}