using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iterator_test1
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

    public abstract class TelevisionMenu
    {
        public abstract void AddItem(int channel, string name, string description);
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

        public override void AddItem(int channel, string name, string description)
        {
            MenuItem tvMenuItem = new MenuItem(channel, name, description);
            menuItems.Add(tvMenuItem);
        }

        public List<MenuItem> GetMenuItems()
        {
            return menuItems;
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

        public override void AddItem(int channel, string name, string description)
        {
            MenuItem filmMenuItem = new MenuItem(channel, name, description);
            if (numberOfItems < MAX_ITEMS)
            {
                menuItems[numberOfItems] = filmMenuItem;
                ++numberOfItems;
            }
        }

        public MenuItem[] GetMenuItems()
        {
            return menuItems;
        }
    }

    class Program
    {
        
        static void Main(string[] args)
        {
            TVChannelMenu tvMenuItems = new TVChannelMenu();
            FilmMenu filmMenuItems = new FilmMenu();

            // 遍历电视频道
            for (int i = 0; i < tvMenuItems.GetMenuItems().Count; ++i)
            {

            }

            // 遍历电影频道
            for (int j = 0; j < filmMenuItems.GetMenuItems().Length; ++j)
            {
                
            }
        }
    }
}
