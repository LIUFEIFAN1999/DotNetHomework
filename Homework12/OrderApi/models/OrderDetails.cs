using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TodoApi.Models{
    public class OrderDetails
    {
        private Goods goods;
        private int count;

        public OrderDetails() { }

        public OrderDetails(int count, Goods goods)
        {
            this.count = count;
            this.goods = goods;
        }

        public OrderDetails(int count, int goodsId)
        {
            this.count = count;
            GoodsId = goodsId;
        }

        public int Count { get => count; set => count = value; }
        public double Amount { get{
            if(goods!=null){
                return goods.Price * count;
            }
            else{
                return 0;
            }
        } }
        public int GoodsId { get; set; }
        public Goods Goods { get => goods; set => goods = value; }
        [Key]
        public int ItemID { get; set; }

        public override bool Equals(object obj)
        {
            return obj is OrderDetails details &&
                   details != null &&
                   EqualityComparer<Goods>.Default.Equals(goods, details.goods);
        }

        public override int GetHashCode()
        {
            int hashCode = -720357890;
            hashCode = hashCode * -1521134295 + EqualityComparer<Goods>.Default.GetHashCode(goods);
            hashCode = hashCode * -1521134295 + count.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return $"\t[OrderDetails]\n{goods}\tcount:{count}\tamount:{Amount}";
        }
    }
}