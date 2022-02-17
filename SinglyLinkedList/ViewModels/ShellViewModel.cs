using Caliburn.Micro;
using SinglyLinkedList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList.ViewModels
{
    public class ShellViewModel : Screen
    {
        private LinkedListModel linkedList = new LinkedListModel();
        private BindableCollection<Item> items = new BindableCollection<Item>();
        private int number;
        private int m;

        public int M
        {
            get { return m; }
            set { 
                m = value;
                NotifyOfPropertyChange(() => M);
            }
        }

        public int Number
        {
            get { return number; }
            set { 
                number = value;
                NotifyOfPropertyChange(() => Number);
            }
        }

        private string answer;

        public string Answer
        {
            get { return answer; }
            set
            { 
                answer = value;
                NotifyOfPropertyChange(() => Answer);
            }
        }

        public BindableCollection<Item> Items
        {
            get { return items; }
            set 
            { 
                items = value;
                NotifyOfPropertyChange(() => Items);
            }
        }


        public LinkedListModel LinkedList
        {
            get { return linkedList; }
            set 
            { 
                linkedList = value;
                NotifyOfPropertyChange(() => LinkedList);
            }
        }

        public void AddNumberToLinkedList(int number)
        {
            if (LinkedList.IsEmpty())
            {
                Items = new BindableCollection<Item>();
            }
            LinkedList.Add(number);
            Items.Add(new Item {CurrentItem = number });
            
            Number = 0;
            Answer = "";
        }

        public bool CanAddNumberToLinkedList(int number) => number != 0;

        public void MthNumber(int m)
        {
            Answer = LinkedList.ReturnMthFromLast(m);
            M = 0;
            LinkedList = new LinkedListModel();
        }

        public bool CanMthNumber(int m) => Items.Count > 0;
    }
}
