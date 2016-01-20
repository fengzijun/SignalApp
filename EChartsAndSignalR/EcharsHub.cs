using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using EChartsAndSignalR.Models;
using System.Threading.Tasks;
using SignalChat;

namespace EChartsAndSignalR
{
    public class EcharsHub : Hub
    {
        public void Send()
        {
            // Task perdiodicTask = PeriodicTaskFactory.Start(() =>
            // {
            //     // Console.WriteLine(DateTime.Now);
            //     List<FlyModel> bjModelTemp = new List<FlyModel>();
            //     List<FlyModel> shModelTemp = new List<FlyModel>();
            //     List<FlyModel> gzModelTemp = new List<FlyModel>();
            //     GetData(ref bjModelTemp, ref shModelTemp, ref gzModelTemp);
            //     Clients.All.getFlyMsgSend(bjModelTemp, shModelTemp, gzModelTemp);
            // },

            // intervalInMilliseconds: 5000// fire every two seconds...
            //);

            List<FlyModel> bjModelTemp = new List<FlyModel>();
            List<FlyModel> shModelTemp = new List<FlyModel>();
            List<FlyModel> gzModelTemp = new List<FlyModel>();
            GetData(ref bjModelTemp, ref shModelTemp, ref gzModelTemp);
            Clients.All.getFlyMsgSend(bjModelTemp, shModelTemp, gzModelTemp);
        }

        private void GetData(ref List<FlyModel> bjModelTemp, ref List<FlyModel> shModelTemp, ref List<FlyModel> gzModelTemp)
        {
            List<FlyModel> bjModel = new List<FlyModel>();
            List<FlyModel> shModel = new List<FlyModel>();
            List<FlyModel> gzModel = new List<FlyModel>();

            bjModel.Add(new FlyModel { StartName = "北京", EndName = "上海", Val = 90 });
            bjModel.Add(new FlyModel { StartName = "北京", EndName = "广州", Val = 80 });
            bjModel.Add(new FlyModel { StartName = "北京", EndName = "大连", Val = 70 });
            bjModel.Add(new FlyModel { StartName = "北京", EndName = "南宁", Val = 60 });
            bjModel.Add(new FlyModel { StartName = "北京", EndName = "南昌", Val = 50 });
            bjModel.Add(new FlyModel { StartName = "北京", EndName = "拉萨", Val = 40 });
            bjModel.Add(new FlyModel { StartName = "北京", EndName = "长春", Val = 30 });
            bjModel.Add(new FlyModel { StartName = "北京", EndName = "包头", Val = 20 });
            bjModel.Add(new FlyModel { StartName = "北京", EndName = "重庆", Val = 10 });

            shModel.Add(new FlyModel { StartName = "上海", EndName = "北京", Val = 90 });
            shModel.Add(new FlyModel { StartName = "上海", EndName = "广州", Val = 80 });
            shModel.Add(new FlyModel { StartName = "上海", EndName = "大连", Val = 70 });
            shModel.Add(new FlyModel { StartName = "上海", EndName = "南宁", Val = 60 });
            shModel.Add(new FlyModel { StartName = "上海", EndName = "南昌", Val = 50 });
            shModel.Add(new FlyModel { StartName = "上海", EndName = "拉萨", Val = 40 });
            shModel.Add(new FlyModel { StartName = "上海", EndName = "长春", Val = 30 });
            shModel.Add(new FlyModel { StartName = "上海", EndName = "包头", Val = 20 });
            shModel.Add(new FlyModel { StartName = "上海", EndName = "重庆", Val = 10 });

            gzModel.Add(new FlyModel { StartName = "广州", EndName = "北京", Val = 90 });
            gzModel.Add(new FlyModel { StartName = "广州", EndName = "上海", Val = 80 });
            gzModel.Add(new FlyModel { StartName = "广州", EndName = "大连", Val = 70 });
            gzModel.Add(new FlyModel { StartName = "广州", EndName = "南宁", Val = 60 });
            gzModel.Add(new FlyModel { StartName = "广州", EndName = "南昌", Val = 50 });
            gzModel.Add(new FlyModel { StartName = "广州", EndName = "拉萨", Val = 40 });
            gzModel.Add(new FlyModel { StartName = "广州", EndName = "长春", Val = 30 });
            gzModel.Add(new FlyModel { StartName = "广州", EndName = "包头", Val = 20 });
            gzModel.Add(new FlyModel { StartName = "广州", EndName = "重庆", Val = 10 });

            Random rank = new Random();
            int index = rank.Next(0, 9);
            bjModelTemp.Add(bjModel[index]);
            index = rank.Next(0, 9);
            shModelTemp.Add(shModel[index]);
            index = rank.Next(0, 9);
            gzModelTemp.Add(gzModel[index]);
           
        }
    }
}