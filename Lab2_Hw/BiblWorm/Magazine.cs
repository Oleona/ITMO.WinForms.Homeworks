using System;

namespace MyClass
{
    class Magazine : Item, IPubs
    {
        private String volume;    // том
        private int number;        // номер
        private String title;       // название
        private int year;      // дата выпуска

        private bool IfSubs { get; set; } // подписка на журнал

        public Magazine(String volume, int number, String title, int year, long invNumber, bool taken)
            : base(invNumber, taken)
        {
            this.volume = volume;
            this.number = number;
            this.title = title;
            this.year = year;
        }


        public override void Return()    // операция "вернуть"
        {
            taken = true;
        }

        // реализация интерфейса



        public void Subs()
        {
            IfSubs = true;
        }


        public override string ToString()
        {
            if (IfSubs)
                return "\nЖурнал:\n Название: " + title + "\nТом: " + volume +
                "\n Номер: " + number + "\nГод выпуска: " + year + " г.\n" + base.ToString() + "\n Подписка оформлена";
            else
                return "\nЖурнал:\n Название: " + title + "\nТом: " + volume +
            "\n Номер: " + number + "\nГод выпуска: " + year + " г.\n" + base.ToString() + "\n Подписка не оформлена"; ;
        }
    }
}
