using HZH_Controls.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BK_PCR
{
    public partial class PCR : Form
    {
        public PCR()
        {
            InitializeComponent();
        }

        private void UCTestMenu_Load(object sender, EventArgs e)
        {
            List<MenuItemEntity> lstMenu1 = new List<MenuItemEntity>();
            MenuItemEntity itemMenu1 = new MenuItemEntity()
            {
                Key = "Setting",
                Text = "设置",
            };
            MenuItemEntity itemMenu2 = new MenuItemEntity()
            {
                Key = "Start",
                Text = "运行",
            };
            itemMenu1.Childrens = new List<MenuItemEntity>();
            itemMenu2.Childrens = new List<MenuItemEntity>();
            MenuItemEntity item1 = new MenuItemEntity()
            {
                Key = "TestItem1",
                Text = "检验项目",
            };
            MenuItemEntity item2 = new MenuItemEntity()
            {
                Key = "TestItem2",
                Text = "样本信息",
            };
            MenuItemEntity item3 = new MenuItemEntity()
            {
                Key = "TestItem3",
                Text = "反应板",
            };
            MenuItemEntity item4 = new MenuItemEntity()
            {
                Key = "TestItem4",
                Text = "程序设置",
            };
            MenuItemEntity item5 = new MenuItemEntity()
            {
                Key = "TestItem5",
                Text = "荧光曲线",
            };
            MenuItemEntity item6 = new MenuItemEntity()
            {
                Key = "TestItem6",
                Text = "温度曲线",
            };
            MenuItemEntity item7 = new MenuItemEntity()
            {
                Key = "TestItem7",
                Text = "运行程序",
            };
            itemMenu1.Childrens.Add(item1);
            itemMenu1.Childrens.Add(item2);
            itemMenu1.Childrens.Add(item3);
            itemMenu1.Childrens.Add(item4);
            itemMenu2.Childrens.Add(item5);
            itemMenu2.Childrens.Add(item6);
            itemMenu2.Childrens.Add(item7);

            lstMenu1.Add(itemMenu1);
            lstMenu1.Add(itemMenu2);
            this.ucMenu1.DataSource = lstMenu1;            
        }

    }
}
