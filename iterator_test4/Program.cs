using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iterator_test4
{
    public class MenuItem
    {
        public MenuItem(int channel, string name, string description)
        {
            Channel = channel;
            Name = name;
            Description = description;
        }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Channel { get; set; }
    }

    public interface TelevisionMenu : IEnumerable
    {
        void AddItem(int channel, string name, string description);
    }

    public class TVChannelMenu : TelevisionMenu
    {
        // 使用List集合
        private List<MenuItem> menuItems = new List<MenuItem>();

        public TVChannelMenu()
        {
            AddItem(1, "CCTV-1", "This is CCTV-1");
            AddItem(2, "CCTV-2", "This is CCTV-2");
            AddItem(3, "CCTV-3", "This is CCTV-3");
        }

        public void AddItem(int channel, string name, string description)
        {
            MenuItem tvMenuItem = new MenuItem(channel, name, description);
            menuItems.Add(tvMenuItem);
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < menuItems.Count; ++i)
            {
                yield return menuItems[i];
            }
        }
    }

    public class FilmMenu : TelevisionMenu
    {
        const int MAX_ITEMS = 5;
        MenuItem[] menuItems = new MenuItem[MAX_ITEMS];
        int numberOfItems = 0;

        public FilmMenu()
        {
            AddItem(1, "绝世天劫", "这是好电影");
            AddItem(2, "达芬奇密码", "这是最喜欢的电影");
        }

        public void AddItem(int channel, string name, string description)
        {
            if (numberOfItems < MAX_ITEMS)
            {
                MenuItem filmMenuItem = new MenuItem(channel, name, description);
                menuItems[numberOfItems] = filmMenuItem;
                ++numberOfItems;
            }
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < numberOfItems; ++i)
            {
                yield return menuItems[i];
            }
        }
    }

    public class MainMenu
    {
        private TVChannelMenu tvMenu;
        private FilmMenu filmMenu;

        public MainMenu(TVChannelMenu tvMenu, FilmMenu filmMenu)
        {
            this.tvMenu = tvMenu;
            this.filmMenu = filmMenu;
        }

        public void PrintMenu()
        {
            Console.WriteLine("电视节目有：");
            PrintMenu(tvMenu);

            Console.WriteLine("电影节目有：");
            PrintMenu(filmMenu);
        }

        private void PrintMenu(TelevisionMenu menu)
        {
            foreach (MenuItem item in menu)
            {
                Console.Write("channel: " + item.Channel + ", ");
                Console.Write("name: " + item.Name + ", ");
                Console.WriteLine("description: " + item.Description);
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            TVChannelMenu tvMenu = new TVChannelMenu();
            FilmMenu filmMenu = new FilmMenu();

            MainMenu mainMenu = new MainMenu(tvMenu, filmMenu);
            mainMenu.PrintMenu();
        }
    }
}
