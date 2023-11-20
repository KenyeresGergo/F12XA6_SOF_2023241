using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using F12XA6_SOF_2023241.Models.Interfaces;

namespace F12XA6_SOF_2023241.Models
{
    public class HomePageViewModel : IHomePageViewModel
    {
        public List<Studios> Studios { get; private set; }
        public int CurrentPage { get; private set; }
        public int TotalPages { get; private set; }

        public HomePageViewModel(List<Studios> studios, int currentPage, int totalPages)
        {
            Studios = studios;
            CurrentPage = currentPage;
            TotalPages = totalPages;
        }
    }
}
