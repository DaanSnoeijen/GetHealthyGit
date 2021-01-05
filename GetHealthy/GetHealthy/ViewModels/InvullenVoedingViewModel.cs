using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GetHealthy.Controllers;
using GetHealthy.Models;


namespace GetHealthy.ViewModels
{
    public class InvullenVoedingViewModel
    {
        public List<ProductViewModel> listA;
        public List<Product> ListB;

        public int Page = 1;

        public List<ProductViewModel> ListA(int page)
        {
            List<ProductViewModel> list = new List<ProductViewModel>();

            if (page == 1)
            {
                for (int i = 0; i < 100; i++)
                {
                    list.Add(listA[i]);
                }
            }
            else if (page == 2)
            {
                for (int i = 101; i < 200; i++)
                {
                    list.Add(listA[i]);
                }
            }
            else if (page == 3)
            {
                for (int i = 201; i < 300; i++)
                {
                    list.Add(listA[i]);
                }
            }
            else if (page == 4)
            {
                for (int i = 301; i < 400; i++)
                {
                    list.Add(listA[i]);
                }
            }
            else if (page == 5)
            {
                for (int i = 401; i < 500; i++)
                {
                    list.Add(listA[i]);
                }
            }
            else if (page == 6)
            {
                for (int i = 501; i < 600; i++)
                {
                    list.Add(listA[i]);
                }
            }
            else if (page == 7)
            {
                for (int i = 601; i < 700; i++)
                {
                    list.Add(listA[i]);
                }
            }
            else if (page == 8)
            {
                for (int i = 701; i < 800; i++)
                {
                    list.Add(listA[i]);
                }
            }
            else if (page == 9)
            {
                for (int i = 901; i < 800; i++)
                {
                    list.Add(listA[i]);
                }
            }
            else if (page == 10)
            {
                for (int i = 901; i < 1000; i++)
                {
                    list.Add(listA[i]);
                }
            }

            return list;
        }
    }
}
