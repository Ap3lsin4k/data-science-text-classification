#include <iostream>
#include<bits/st
using namespace std;

// Функція сортування массиву, після виконання вхідний
// массив міститиме числа в зростаючому порядку
// Для простоти реалізуємо функцію сортування бульбашкою
void sort(int * array, int size)
{
	for (int i = size - 1; i > 0; i--)
	{
		for (int j = 0; j < i; j++)
		{
			if (array[j] > array[j + 1])
			{
				int tmp = array[j];
				array[j] = array[j + 1];
				array[j + 1] = tmp;
			}
		}
	}
}

// Вважатимемо мінімально можливою довжиною арифметичної прогресії 2
// Якщо за умовою буде інше значення - змініть значення змінної нижче
int MIN_SIZE = 2;

int main()
{
	int N;

	// За умовою не зрозуміло максимально можливу кількість чисел, для простоти використаємо 1000
	// Якщо в умові буде вказано обмеження довжини массиву, то вкажіть його нижче.
	int numbers[1000];

	// Зчитуємо кількість чисел
	cin >> N;

	// Зчитуємо самі числа
	for (int i = 0; i < N; i++)
		cin >> numbers[i];

	// Для пошуку всіх можливих прогресій відсортуємо массив по зростанню
	sort(numbers, N);

	// Ініціалізуємо допоміжні змінні
	int max_len = 0;
	int number_of_progression = 0;
	int min_element = 0;
	int min_diff = 0;

	// Для пошуку арифметичної прогресії викличемо допоміжну функцію
	// для кожного елементу массиву
	for (int i = 0; i < N; i++)
	{
		for (int j = i + 1; j < N; j++)
		{
			// Визначимо різницю поточної прогресії
			int current_progression_diff = numbers[j] - numbers[i];

			// Вкажемо поточну довжину прогресії
			int current_progression_len = 2;

			// Визначимо поточний мінімальний елемент
			int current_min_element = numbers[i];

			// Перевіримочи є серед інших чисел члени поточної прогрессії
			for (int k = j + 1; k < N; k++)
			{
				int diff = numbers[k] - numbers[j];

				// Якщо поточна різниця рівна різниця прогресії, то даний елемент
				// є членом поточної арифметичної прогресії
				if (diff == current_progression_diff)
				{
					// Збільшимо поточну довжину прогресії
					current_progression_len++;

					// Перейдемо до наступного елементу
					continue;
				}

				// Якщо різниця між поточним елементом і попереднім менше
				// різниці поточної прогресії, то можливо хтось і з наступних
				// елементів массиву буде членом прогресії
				if (diff < current_progression_diff)
				{
					// Перейдемо до наступного елементу
					continue;
				}

				// Інакше різниця більша різниці поточної прогесії і більше членів прогресії в массиві ми не знайдемо
				break;
			}

			// Перевіримо чи довжина поточної прогресії достатня
			if (current_progression_len < MIN_SIZE)
			{
				// Якщо менша за мінімальну, то перейдемо до перевірки наступних прогресій
				continue;
			}

			// Перевіримо чи довжину поточної прогресії не максимальна
			if (max_len < current_progression_len)
			{
				// Якщо максимальна, то оновимо відповіді
				current_progression_diff = numbers[j] - numbers[i];

				max_len = current_progression_len;
				number_of_progression = 1;
				min_element = current_min_element;
				min_diff = current_progression_diff;
			}
			// Інакше перевіримочи не було раніше прогресії з такою довжиною
			else if (max_len == current_progression_len)
			{
				// Якщо була, то оновимо відповіді

				// Збільшимо кількість таких прогресій
				number_of_progression += 1;

				// Визначимо
				if (min_element > current_min_element)

				// Визначимо прогресію з мінімільною різницею
				// і мінімільний елемент в такій прогресії
				if (min_diff > current_progression_diff)
				{
					min_diff = current_progression_diff;
					min_element = current_min_element;
				}
			}
		}
	}

	// Виведемо відповіді
	cout << max_len << endl;
	cout << number_of_progression << endl;
	cout << min_element << endl;
	cout << min_diff << endl;

	return 0;
}
