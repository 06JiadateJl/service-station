using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсач_15_вар
{
    abstract class Information
    {
        int key;
        public int Key { get { return key; } set { key = value; } }
        public abstract string Info();
    }
    class Owner : Information
    {
        string name;
        public string Name { get { return name; } set { name = value; } }
        int numberpassport;
        public int NumberPassport { get { return numberpassport; } set { numberpassport = value; } }
        string adress;
        public string Adress { get { return adress; } set { adress = value; } }
        int age;
        public int Age { get { return age; } set { age = value; } }
        string marka;//марка авто
        public string Marka { get { return marka; } set { marka = value; } }
        DateTime dateOfApplication;
        public DateTime DateOfApplication { get { return dateOfApplication; } set { dateOfApplication = value; } }
        DateTime dateOfReceiving;
        public DateTime DateOfReceiving { get { return dateOfReceiving; } set { dateOfReceiving = value; } }
        string numberAuto;
        public string NumberAuto { get { return numberAuto; } set { numberAuto = value; } }
        public override string Info()
        {
            string data = Key + ";" + Name + ";" + NumberPassport + ";" + Adress + ";" + Age + ";" + Marka + ";" + DateOfApplication + ";" + DateOfReceiving;
            return data;
        }
        public Owner() { }
        public Owner(int key, string name, int numberpassport, string adress, int age, string marka, DateTime dateOfApplication, DateTime dateOfReceiving, string numberAuto)
        {
            Key = key;
            Name = name;
            NumberPassport = numberpassport;
            Adress = adress;
            Age = age;
            Marka = marka;
            DateOfApplication = dateOfApplication;
            DateOfReceiving = dateOfReceiving;
            NumberAuto = numberAuto;

        }

    }
    class Auto : Information
    {
        string marka;
        public string Marka { get { return marka; } set { marka = value; } }
        string color;
        public string Color { get { return color; } set { color = value; } }
        DateTime yearOfIssue;//год выпуска
        public DateTime YearOfIssue { get { return yearOfIssue; } set { yearOfIssue = value; } }
        string numberOfAuto;
        public string NumberOfAuto { get { return numberOfAuto; } set { numberOfAuto = value; } }
        string defects;
        public string Defects { get { return defects; } set { defects = value; } }
        public override string Info()
        {
            string data = Key + ";" + Marka + ";" + Color + ";" + YearOfIssue + ";" + NumberOfAuto;
            return data;
        }
        public Auto() { }
        public Auto(int key, string marka, string color, DateTime yearOfIssue, string numberOfAuto, string defects)
        {
            Key = key;
            Marka = marka;
            Color = color;
            YearOfIssue = yearOfIssue;
            NumberOfAuto = numberOfAuto;
            Defects = defects;
        }
    }
    class Worker : Information
    {
        string name;
        public string Name { get { return name; } set { name = value; } }
        string speciality;
        public string Speciality { get { return speciality; } set { speciality = value; } }
        string сategory;
        public string Сategory { get { return сategory; } set { сategory = value; } }
        DateTime date;
        public DateTime Date { get { return date; } set { date = value; } }
        decimal priceForWork;
        public decimal PriceForWork { get { return priceForWork; } set { priceForWork = value; } }
        decimal priceForDetails;
        public decimal PriceForDetails { get { return priceForDetails; } set { priceForDetails = value; } }
        public override string Info()
        {
            string data = Key + ";" + Name + ";" + Speciality + ";" + Сategory + ";" + PriceForWork + ";" + PriceForDetails;
            return data;
        }
        public Worker() { }
        public Worker(int key, string name, string speciality, string сategory, DateTime date, decimal priceForWork, decimal priceForDetails)
        {
            Key = key;
            Name = name;
            Speciality = speciality;
            Сategory = сategory;
            Date = date;
            PriceForWork = priceForWork;
            PriceForDetails = priceForDetails;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            FileRead();
            int n = -1;
            while (true)
            {
                Frame();
                if (!int.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine("Это не цифра, нажмите Enter");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }

                switch (n)
                {
                    case 1:
                        Auto_for_owner();
                        Console.WriteLine
                            ("Нажмите любую клавишу");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    case 2:
                        Worker_for_auto();
                        Console.WriteLine
                            ("Нажмите любую клавишу");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    case 3:
                        Remont();
                        Console.WriteLine
                            ("Нажмите любую клавишу");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    case 4:
                        Console.WriteLine("Введите ID авто(начиная с 0)");
                        int i = Convert.ToInt32(Console.ReadLine());
                        RemoveAuto(i);
                        Console.WriteLine("Авто успешно удалено");
                        Console.WriteLine
                            ("Нажмите любую клавишу");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    case 5:
                        Console.WriteLine("Введите ключ: ");
                        int key = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите имя клиента: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Введите номер паспорта: ");
                        int numberpassport = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите адресс: ");
                        string adress = Console.ReadLine();
                        Console.WriteLine("Введите возраст: ");
                        int age = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите марку авто: ");
                        string marka = Console.ReadLine();
                        Console.WriteLine("Введите дату обращения: ");
                        DateTime dateOfApplication = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("Введите дату выдачи: ");
                        DateTime dateOfReceiving = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("Введите гос. номер авто:");
                        string numberAuto = Console.ReadLine();
                        AddOwner(key, name, numberpassport, adress, age, marka, dateOfApplication, dateOfReceiving, numberAuto);
                        Console.WriteLine("Клиент успешно добавлен");
                        Console.WriteLine
                            ("Нажмите любую клавишу");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    case 6:
                        OwnerListView();
                        continue;
                    case 9:
                        Console.Clear();
                        Console.WriteLine
                            ("Выйти из программы - да, нет - любая клавиша");
                        string s = Console.ReadLine();
                        if (s == "да") Environment.Exit(0);
                        else
                        {
                            Console.Clear();
                            continue;
                        }
                        continue;
                    case 7:
                        AutoListView();
                        continue;
                    case 8:
                        WorkerListView();
                        continue;
                    default:
                        Console.Clear();
                        Console.WriteLine
                            ("Введенный № отсутствует, нажмите любую клавишу");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                }
            }
        }
        static void FileRead()
        {
            using (StreamReader sr = new StreamReader(OwnerPath, System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] words = line.Split(';');
                    lstOwner.Add(new Owner(Convert.ToInt32(words[0]), Convert.ToString(words[1]), Convert.ToInt32(words[2]), Convert.ToString(words[3]), Convert.ToInt32(words[4]), Convert.ToString(words[5]), Convert.ToDateTime(words[6]), Convert.ToDateTime(words[7]), Convert.ToString(words[8])));
                    //  Console.WriteLine(line);
                }

            }
            using (StreamReader sr = new StreamReader(AutoPath, System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] words = line.Split(';');
                    lstAuto.Add(new Auto(Convert.ToInt32(words[0]), Convert.ToString(words[1]), Convert.ToString(words[2]), Convert.ToDateTime(words[3]), Convert.ToString(words[4]), words[5]));
                    //  Console.WriteLine(line);
                }

            }
            using (StreamReader sr = new StreamReader(WorkerPath, System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] words = line.Split(';');
                    lstWorker.Add(new Worker(Convert.ToInt32(words[0]), Convert.ToString(words[1]), Convert.ToString(words[2]), Convert.ToString(words[3]), Convert.ToDateTime(words[4]), Convert.ToDecimal(words[5]), Convert.ToDecimal(words[6])));
                    //  Console.WriteLine(line);
                }

            }
        }
        static public void Auto_for_owner()
        {
            Console.WriteLine("Введите имя клиента: ");
            string name = Console.ReadLine();
            var s = from c in lstAuto
                    join v in lstOwner on c.Key equals v.Key
                    where v.Name == name
                    where v.Key == c.Key
                    select c.Marka + ";" + c.YearOfIssue;

            Console.WriteLine("Марка и год выпуска: ");
            foreach (string t in s)
            {
                Console.WriteLine(t);
            }
        }
        static public void Worker_for_auto()
        {
            Console.WriteLine("Введите гос номер авто: ");
            string number = Console.ReadLine();
            var s = from v in lstOwner
                    join c in lstAuto on v.Key equals c.Key
                    join b in lstWorker on v.Key equals b.Key
                    where c.NumberOfAuto == number
                    where c.NumberOfAuto == v.NumberAuto
                    where v.Key == b.Key
                    select b.Name;
            Console.WriteLine("Имя работника: ");
            foreach (string t in s)
            {
                Console.WriteLine(t);
            }
        }
        static public void Remont()
        {
            Console.WriteLine("Введите дефект: ");
            string defects = Console.ReadLine();
            var s = from c in lstAuto
                    join v in lstOwner on c.Key equals v.Key
                    where c.Defects == defects
                    select v.Name;

            Console.WriteLine("Имя владельца: ");
            foreach (string t in s)
            {
                Console.WriteLine(t);
            }
        }
        static public void RemoveAuto(int i)
        {
            lstAuto.RemoveAt(i);
            using (StreamWriter sw = new StreamWriter(AutoPath, false, System.Text.Encoding.Default))
            {
                foreach (Auto np in lstAuto)
                {
                    sw.WriteLine(np.Info());
                }
            }
        }
        static public void AddOwner(int key, string name, int numberpassport, string adress, int age, string marka, DateTime dateOfApplication, DateTime dateOfReceiving, string numberAuto)
        {
            lstOwner.Add(new Owner(key, name, numberpassport, adress, age, marka, dateOfApplication, dateOfReceiving, numberAuto));
            using (StreamWriter sw = new StreamWriter(OwnerPath, false, System.Text.Encoding.Default))
            {
                foreach (Owner ns in lstOwner)
                {
                    sw.WriteLine(ns.Info());
                }
            }
        }
        static public void OwnerListView()
        {
            Console.Clear();
            Console.WriteLine("Key;Имя;Номер паспорта;Адресс;Возраст;Марка авто;Дата обращения;Дата получения;Номер авто");
            foreach (Owner ns in lstOwner)
            {

                Console.WriteLine(ns.Info());
            }
        }
        static public void AutoListView()
        {
            Console.Clear();
            Console.WriteLine("Key;Марка;Цвет;Дата выпуска;Гос номер;Дефект");
            foreach (Auto ns in lstAuto)
            {

                Console.WriteLine(ns.Info());
            }
        }
        static public void WorkerListView()
        {
            Console.Clear();
            Console.WriteLine("Key;Имя;Специальность;Разряд;Дата;Цена работы;Цена запчастей");
            foreach (Worker ns in lstWorker)
            {

                Console.WriteLine(ns.Info());
            }
        }
        static void Frame()
        {
            Console.WriteLine("\tВыберите № задачи\n");
            Console.WriteLine("1 - Кто обслуживавл владельца заданого автомобиля");
            Console.WriteLine("2 - Марка и год выпуска автомобиля данного владельца");
            Console.WriteLine("3 - Владельцы сдавшие автомобиля с данным типом неисправности");
            Console.WriteLine("4 - Удалить авто из списка");
            Console.WriteLine("5 - Добавить клиента в список");
            Console.WriteLine("6 - Просмотреть список клиентов");
            Console.WriteLine("7 - Просмотреть список авто");
            Console.WriteLine("8 - Просмотреть список рабочих");
            Console.WriteLine("9 - Выход из программы");
        }
        static List<Owner> lstOwner = new List<Owner>();
        static List<Auto> lstAuto = new List<Auto>();
        static List<Worker> lstWorker = new List<Worker>();
        static string OwnerPath = Directory.GetCurrentDirectory() + "\\Owner.txt";
        static string AutoPath = Directory.GetCurrentDirectory() + "\\Auto.txt";
        static string WorkerPath = Directory.GetCurrentDirectory() + "\\Worker.txt";
    }
}
