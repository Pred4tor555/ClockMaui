namespace ClockMaui
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            // Запуск асинхронного таймера
            StartClock();
        }

        private async void StartClock()
        {
            var timer = new PeriodicTimer(TimeSpan.FromSeconds(1));

            // Асинхронно выполняем цикл
            await Task.Run(async () =>
            {
                while (await timer.WaitForNextTickAsync())
                {
                    var currentTime = DateTime.Now;

                    var hours = currentTime.Hour;
                    var minutes = currentTime.Minute;
                    var seconds = currentTime.Second;
                    

                    // Обновление UI должно происходить в главном потоке
                    MainThread.BeginInvokeOnMainThread(() =>
                    {
                        var secondJunNow = seconds % 10;
                        SecondJunDisplay(secondJunNow);
                        
                        var secondSenNow = seconds / 10;
                        SecondSenDisplay(secondSenNow);
                        
                        
                        var minuteJunNow = minutes % 10;
                        minuteJunDisplay(minuteJunNow);
                        
                        var minuteSenNow = minutes / 10;
                        minuteSenDisplay(minuteSenNow);
                        
                        
                        var hourJunNow = hours % 10;
                        hourJunDisplay(hourJunNow);
                        
                        var hourSenNow = hours / 10;
                        hourSenDisplay(hourSenNow);
                    });
                }
            });
        }

        
        
        // Метод для отображения младшего разряда секунд
        private void SecondJunDisplay(int secondJunNow)
        {
            switch (secondJunNow)
            {
                case 0:
                    secondJun9.IsVisible = false;
                    secondJun0.IsVisible = true;
                    break;
                case 1:
                    secondJun0.IsVisible = false;
                    secondJun1.IsVisible = true;
                    break;
                case 2:
                    secondJun1.IsVisible = false;
                    secondJun2.IsVisible = true;
                    break;
                case 3:
                    secondJun2.IsVisible = false;
                    secondJun3.IsVisible = true;
                    break;
                case 4:
                    secondJun3.IsVisible = false;
                    secondJun4.IsVisible = true;
                    break;
                case 5:
                    secondJun4.IsVisible = false;
                    secondJun5.IsVisible = true;
                    break;
                case 6:
                    secondJun5.IsVisible = false;
                    secondJun6.IsVisible = true;
                    break;
                case 7:
                    secondJun6.IsVisible = false;
                    secondJun7.IsVisible = true;
                    break;
                case 8:
                    secondJun7.IsVisible = false;
                    secondJun8.IsVisible = true;
                    break;
                case 9:
                    secondJun8.IsVisible = false;
                    secondJun9.IsVisible = true;
                    break;
            }
        }
        
        
        // Метод для отображения старшего разряда секунд
        private void SecondSenDisplay(int secondSenNow)
        {
            switch (secondSenNow)
            {
                case 0:
                    secondSen5.IsVisible = false;
                    secondSen0.IsVisible = true;
                    break;
                case 1:
                    secondSen0.IsVisible = false;
                    secondSen1.IsVisible = true;
                    break;
                case 2:
                    secondSen1.IsVisible = false;
                    secondSen2.IsVisible = true;
                    break;
                case 3:
                    secondSen2.IsVisible = false;
                    secondSen3.IsVisible = true;
                    break;
                case 4:
                    secondSen3.IsVisible = false;
                    secondSen4.IsVisible = true;
                    break;
                case 5:
                    secondSen4.IsVisible = false;
                    secondSen5.IsVisible = true;
                    break;
            }
        }
        
        
        // Метод для отображения младшего разряда минут
        private void minuteJunDisplay(int minuteJunNow)
        {
            switch (minuteJunNow)
            {
                case 0:
                    minuteJun9.IsVisible = false;
                    minuteJun0.IsVisible = true;
                    break;
                case 1:
                    minuteJun0.IsVisible = false;
                    minuteJun1.IsVisible = true;
                    break;
                case 2:
                    minuteJun1.IsVisible = false;
                    minuteJun2.IsVisible = true;
                    break;
                case 3:
                    minuteJun2.IsVisible = false;
                    minuteJun3.IsVisible = true;
                    break;
                case 4:
                    minuteJun3.IsVisible = false;
                    minuteJun4.IsVisible = true;
                    break;
                case 5:
                    minuteJun4.IsVisible = false;
                    minuteJun5.IsVisible = true;
                    break;
                case 6:
                    minuteJun5.IsVisible = false;
                    minuteJun6.IsVisible = true;
                    break;
                case 7:
                    minuteJun6.IsVisible = false;
                    minuteJun7.IsVisible = true;
                    break;
                case 8:
                    minuteJun7.IsVisible = false;
                    minuteJun8.IsVisible = true;
                    break;
                case 9:
                    minuteJun8.IsVisible = false;
                    minuteJun9.IsVisible = true;
                    break;
            }
        }
        
        
        // Метод для отображения старшего разряда минут
        private void minuteSenDisplay(int minuteSenNow)
        {
            switch (minuteSenNow)
            {
                case 0:
                    minuteSen5.IsVisible = false;
                    minuteSen0.IsVisible = true;
                    break;
                case 1:
                    minuteSen0.IsVisible = false;
                    minuteSen1.IsVisible = true;
                    break;
                case 2:
                    minuteSen1.IsVisible = false;
                    minuteSen2.IsVisible = true;
                    break;
                case 3:
                    minuteSen2.IsVisible = false;
                    minuteSen3.IsVisible = true;
                    break;
                case 4:
                    minuteSen3.IsVisible = false;
                    minuteSen4.IsVisible = true;
                    break;
                case 5:
                    minuteSen4.IsVisible = false;
                    minuteSen5.IsVisible = true;
                    break;
            }
        }
        
        
        // Метод для отображения младшего разряда часов
        private void hourJunDisplay(int hourJunNow)
        {
            switch (hourJunNow)
            {
                case 0:
                    if (hourSen2.IsVisible)
                    {
                        hourJun3.IsVisible = false;
                        hourJun0.IsVisible = true;
                        break;
                    }
                    hourJun9.IsVisible = false;
                    hourJun0.IsVisible = true;
                    break;
                case 1:
                    hourJun0.IsVisible = false;
                    hourJun1.IsVisible = true;
                    break;
                case 2:
                    hourJun1.IsVisible = false;
                    hourJun2.IsVisible = true;
                    break;
                case 3:
                    hourJun2.IsVisible = false;
                    hourJun3.IsVisible = true;
                    break;
                case 4:
                    hourJun3.IsVisible = false;
                    hourJun4.IsVisible = true;
                    break;
                case 5:
                    hourJun4.IsVisible = false;
                    hourJun5.IsVisible = true;
                    break;
                case 6:
                    hourJun5.IsVisible = false;
                    hourJun6.IsVisible = true;
                    break;
                case 7:
                    hourJun6.IsVisible = false;
                    hourJun7.IsVisible = true;
                    break;
                case 8:
                    hourJun7.IsVisible = false;
                    hourJun8.IsVisible = true;
                    break;
                case 9:
                    hourJun8.IsVisible = false;
                    hourJun9.IsVisible = true;
                    break;
            }
        }
        
        
        // Метод для отображения старшего разряда часов
        private void hourSenDisplay(int hourSenNow)
        {
            switch (hourSenNow)
            {
                case 0:
                    hourSen2.IsVisible = false;
                    hourSen0.IsVisible = true;
                    break;
                case 1:
                    hourSen0.IsVisible = false;
                    hourSen1.IsVisible = true;
                    break;
                case 2:
                    hourSen1.IsVisible = false;
                    hourSen2.IsVisible = true;
                    break;
            }
        }
    }
}
