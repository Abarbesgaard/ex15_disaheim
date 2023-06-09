﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Utility
    {



        public double GetValueOfBook(Book book)
        {

            return book.Price;
        }

        public double GetValueOfAmulet(Amulet amulet)
        {
            
            double price = 0.0;
          
            if (amulet.Quality == Level.low)
                price = 12.5;
            else if (amulet.Quality == Level.medium)
                price = 20.0;
            else if (amulet.Quality == Level.high)
                price = 27.5;

            return price;
        }
    }
}
