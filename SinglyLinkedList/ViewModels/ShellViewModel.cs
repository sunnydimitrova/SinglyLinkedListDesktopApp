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
        private int number;
        private int m;
        private string answer;
        private LinkedListModel linkedList = new LinkedListModel();
        private BindableCollection<Item> items = new BindableCollection<Item>();

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
            LinkedList.Add(number);
            Items.Add(new Item {CurrentItem = number });
            
            Number = 0;
            Answer = "";
        }

        public void MthNumber(int m)
        {
            Answer = LinkedList.ReturnMthFromLast(m);
            M = 0;
            LinkedList = new LinkedListModel();
            Items = new BindableCollection<Item>();
        }
    }
}
