using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp0425.Models;

namespace WpfApp0425.Repo
{
    public class FakeRepo
    {
        public List<Printer> GetPrinters()
        {
            return new List<Printer>
            {
                new Printer
                {
                    Model="Envy",
                    Vendor="HP",
                    Color="Black"
                },
                new Printer
                {
                    Model="R100",
                    Vendor="Canon",
                    Color="Red"
                },
                new Printer
                {
                    Model="T431",
                    Vendor="Canon",
                    Color="Blue"
                },
                new Printer
                {
                    Model="123A",
                    Vendor="HP",
                    Color="White"
                }
            };
        }
    }
}
