using System;

namespace names
{
	class NamesTasks
	{
		public static void ShowBirthDayMonthStatistics(NameData[] names)
		{
			Console.WriteLine("Статистика рождаемости по датам");
			/*
			Выведите на консоль количество людей, рожденных в первый день месяца, в последний день месяца, 
			и усредненное по всем остальным дням месяца количество рожденных людей
			(то есть количество людей, рожденных не первого и не последнего числа, 
			деленное на количество не первых и не последних чисел в году).
			Все три величины должны быть вычислены в одном цикле.
			Количество дней в году можно считать равным 365.
			
			Попробуйте объяснить результат.

			Можно обращаться к свойствам NameData так names[0].Name 
			Полностью аналогично тому, как вы обращаетесь к свойствам строки s.Length
			*/

            var date = names[0].BirthDate.Date;
            var dayStart = new DateTime(date.Year, date.Month+1, 1);
            var dayFinish = new DateTime(date.Year, date.Month, 1);
            var lastDayInMonth = dayStart.Subtract(dayFinish);

            Console.WriteLine(lastDayInMonth.Days);
		}

		public static void ShowBirthYearsStatisticsHistogram(NameData[] names)
		{
			Console.WriteLine("Статистика рождаемости по годам");
			/*
			Напишите код, готовящий данные для построения гистограммы 
			— количества людей в выборке в зависимости от года их рождения.
			Если вас пугает незнакомое слово гистограмма — вам как обычно в википедию! 
			http://ru.wikipedia.org/wiki/%D0%93%D0%B8%D1%81%D1%82%D0%BE%D0%B3%D1%80%D0%B0%D0%BC%D0%BC%D0%B0
			*/
			Histogram.Show("Рождаемость по годам", new[] { 1990, 2000 }, new[] { 1000, 2000 });
		}

		public static void ShowBirthDayMonthStatisticsForName(NameData[] names, string name)
		{
			Console.WriteLine("Статистика рождаемости имени {0}", name);
			/*
			Выведите на консоль:
				1. Дату без года (только день и месяц) с максимальной рождаемостью людей с именем name.
				2. Процент людей с заданным именем, рожденных в найденную дату из предыдущего пункта.
				Проинтерпретируйте результат этой функции на именах Виктория, Юрий, Илья, Владимир.
				Сильно ли выше среднего рождаемость в самые "плодотворные" дни?
			 */
		}
	}
}
