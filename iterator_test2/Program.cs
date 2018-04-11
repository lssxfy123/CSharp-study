using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iterator_test2
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

    // 抽象迭代器接口
    public interface Iterator
    {
        bool HasNext();
        object Next();
    }

    // 电视频道迭代器
    public class TVChannelMenuIterator : Iterator
    {
        private List<MenuItem> menuItems;
        private int position = 0;

        public TVChannelMenuIterator(List<MenuItem> menuItems)
        {
            this.menuItems = menuItems;
        }

        public bool HasNext()
        {
            if ((position > menuItems.Count - 1) || (menuItems[position] == null))
            {
                return false;
            }
            return true;
        }

        public object Next()
        {
            MenuItem item = menuItems[position];
            ++position;
            return item;
        }
    }

    // 电影频道迭代器
    public class FilmMenuIterator : Iterator
    {
        private MenuItem[] menuItems;
        int position = 0;

        public FilmMenuIterator(MenuItem[] menuItems)
        {
            this.menuItems = menuItems;
        }

        public bool HasNext()
        {
            if ((position > menuItems.Length - 1) || (menuItems[position] == null))
            {
                return false;
            }
            return true;
        }

        public object Next()
        {
            MenuItem item = menuItems[position];
            ++position;
            return item;
        }
    }

    public interface  TelevisionMenu
    {
        void AddItem(int channel, string name, string description);

        Iterator CreateIterator();
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

        public Iterator CreateIterator()
        {
            return new TVChannelMenuIterator(menuItems);
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
            MenuItem filmMenuItem = new MenuItem(channel, name, description);
            if (numberOfItems < MAX_ITEMS)
            {
                menuItems[numberOfItems] = filmMenuItem;
                ++numberOfItems;
            }
        }

        public Iterator CreateIterator()
        {
            return new FilmMenuIterator(menuItems);
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
            Iterator tvIterator = tvMenu.CreateIterator();
            Iterator filmIterator = filmMenu.CreateIterator();

            Console.WriteLine("电视节目有：");
            PrintMenu(tvIterator);

            Console.WriteLine("电影节目有：");
            PrintMenu(filmIterator);
        }

        private void PrintMenu(Iterator iter)
        {
            while (iter.HasNext())
            {
                MenuItem item = (MenuItem)iter.Next();
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
