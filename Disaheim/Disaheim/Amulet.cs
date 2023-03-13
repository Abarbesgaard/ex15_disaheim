using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{   
    public class Amulet
    {
        //public string ItemId { get; set; }
        //public string Design { get; set; }
       // public Level Quality { get; set; }

        private string itemId;

        public string ItemId
        {
            get { return itemId; }
            set { itemId = value; }
        }

        private string design;

        public string Design
        {
            get { return design; }
            set { design = value; }
        }

        private Level quality;

        public Level Quality
        {
            get { return Quality; }
            set { Quality = value; }
        }


        public Amulet(string ItemId, Level Quality, string Design) 
        {
            this.itemId = ItemId;
            this.quality = Quality;
            this.design = Design;
        }


        public Amulet(string ItemId) :
            this(ItemId, Level.medium,"")
        { 
            //this.itemId = ItemId;
            //quality = Level.medium;
        }
        public Amulet(string ItemId, Level Quality) : 
            this(ItemId, Quality,"")
        { 
            //this.itemId = ItemId;
            //this.quality = Quality;
        }

        public override string ToString()
        {
            //"ItemId: 11, Quality: medium, Design: "
            return $"ItemId: {itemId}, Quality: {quality}, Design: {design}";
        }

    }
}
