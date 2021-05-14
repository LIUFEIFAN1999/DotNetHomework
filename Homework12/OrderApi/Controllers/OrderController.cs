using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using TodoApi.Models;

namespace BlogApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {

        private readonly OrderContext orderDb;

        //构造函数把OrderContext 作为参数，Asp.net core 框架可以自动注入OrderContext对象
        public OrderController(OrderContext context)
        {
            this.orderDb = context;
        }

        // GET: api/order/{id}  id为路径参数
        [HttpGet("{id}")]
        public ActionResult<Order> GetOrder(int id)
        {
            var order = orderDb.Orders
                    .Include(o=>o.ItemList).ThenInclude(i=>i.Goods)
                    .Include(o => o.Customer)
                    .SingleOrDefault(o => o.OrderId == id);
            if (order == null)
            {
                return NotFound();
            }
            return order;
        }

        // GET: api/order
        // GET: api/order/pageQuery?name=
        [HttpGet]
        public ActionResult<List<Order>> GetOrder(string name)
        {
            var query = buildQuery(name);
            return query.ToList();
        }

        // GET: api/order/pageQuery?skip=5&&take=10  
        // GET: api/order/pageQuery?name=&&skip=5&&take=10
        [HttpGet("pageQuery")]
        public ActionResult<List<Order>> queryOrder(string name, int skip, int take)
        {
            var query = buildQuery(name).Skip(skip).Take(take);
            return query.ToList();
        }

        private IQueryable<Order> buildQuery(string name)
        {
            IQueryable<Order> query = orderDb.Orders
                    .Include(o=>o.ItemList)
                        .ThenInclude(i=>i.Goods)
                    .Include(o => o.Customer)
                    ;
            if (name != null)
            {
                query = query.Where(o => o.Customer.Name == name);
            }
            return query;
        }

        private void fixOrder(Order order){
            order.CustomerId = order.Customer.CustomerId;
            order.Customer = null;
            foreach(OrderDetails item in order.ItemList){
                item.GoodsId = item.Goods.GoodsId;
                item.Goods = null;
            }
        }


        // POST: api/order
        [HttpPost]
        public ActionResult<Order> PostOrder(Order order)
        {
            try
            {
                fixOrder(order);
                orderDb.Orders.Add(order);
                orderDb.SaveChanges();
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return order;
        }

        // PUT: api/order/{id}
        [HttpPut("{id}")]
        public ActionResult<Order> PutOrder(int id, Order order)
        {
            if (id != order.OrderId)
            {
                return BadRequest("Id cannot be modified!");
            }
            try
            {
                DeleteOrder(id);
                PostOrder(order);
            }
            catch (Exception e)
            {
                string error = e.Message;
                if (e.InnerException != null) error = e.InnerException.Message;
                return BadRequest(error);
            }
            return NoContent();
        }

        // DELETE: api/order/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteOrder(int id)
        {
            try
            {
                var order = orderDb.Orders
                    .Include(o=>o.ItemList).ThenInclude(i=>i.Goods)
                    .Include(o => o.Customer)
                    .SingleOrDefault(o => o.OrderId == id);
                if (order != null)
                {
                    orderDb.Items.RemoveRange(order.ItemList);
                    orderDb.Remove(order);
                    orderDb.SaveChanges();
                }
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return NoContent();
        }

    }
}