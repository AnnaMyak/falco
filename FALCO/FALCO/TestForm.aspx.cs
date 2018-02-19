using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.UI;
using System.Web.ModelBinding;
using System.IO;
using DataLayer;

namespace FALCO
{
    public partial class TestForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                Order order = new Order();

                   ;

                    order.Stain = "Test";
                    order.Acceptance = 100;
                    order.Organ = "test";
                    order.Value = 20;
                    order.Tissue = "test";

                Criteria c = new Criteria();
                c.Title = "Test";
                    // Создать объект контекста
                    ApplicationContext context = new DataLayer.ApplicationContext();

                    // Вставить данные в таблицу Customers с помощью LINQ
                    context.Orders.Add(order);
                    context.Criterias.Add(c); 

                    // Сохранить изменения в БД
                    context.SaveChanges();
                }
            }
        }
    }
