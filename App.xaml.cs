using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace KrasnoeBeloe
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            
            // Инициализация приложения
            // Проверка подключения к БД
            // Загрузка конфигурации
            Console.WriteLine("Приложение 'Красное & Белое' запущено");
        }
        
        protected override void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);
            Console.WriteLine("Приложение 'Красное & Белое' завершено");
        }
    }
}