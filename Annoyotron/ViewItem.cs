using System.Windows.Controls;

namespace Annoyotron
{
    public class ViewItem
    {
        public ViewItem(UserControl view, string name)
        {
            View = view;
            Name = name;
        }

        public UserControl View { get; set; }

        public string Name { get; }
    }
}
