using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace SunshineAirlines1.Dals
{
    public class AllFun
    {


        //定义一个Control类型的队列allCtrls
        private static Queue<Control> allCtrls = new Queue<Control>();



        //递归遍历所有的子孙控件包括容器类
        public static void CheckAllCtrls(Control item)
        {
            for (int i = 0; i < item.Controls.Count; i++)
            {
                if (item.Controls[i].HasChildren)
                {
                    CheckAllCtrls(item.Controls[i]);

                }
                //else{allCtrls.Enqueue (item.Controls[i]);}//如果只要子控件，那么这个语句在else里
                allCtrls.Enqueue(item.Controls[i]);
            }
        }
        public static void ReplaceByLanguageMode()
        {
            if (ConfigurationManager.AppSettings["language"] == "1")
            {
                foreach (var item in allCtrls)
                {
                    if (item.Text != "")
                    {
                        string str = Readjson(item.Text);
                        if (str != "")
                        {
                            item.Text = str;
                        }
                    }
                }
            }
            allCtrls.Clear();
        }

        /// <summary>
        /// 读取JSON文件
        /// </summary>
        /// <param name="key">JSON文件中的key值</param>
        /// <returns>JSON文件中的value值</returns>
        public static string Readjson(string key)
        {
            
            string jsonfile = Application.StartupPath+@"\Basic.json";//JSON文件路径
            using (StreamReader file = new StreamReader(jsonfile,Encoding.Default))
            {
               
                using (JsonTextReader reader = new JsonTextReader(file))
                {
                    JObject o = (JObject)JToken.ReadFrom(reader);
                    string value;
                    try
                    {
                        value = GetUTF8(o[key].ToString());
                    }
                    catch (Exception)
                    {
                        return "";
                    }
                    return value;
                }
            }
        }

        public static string GetUTF8(string Json)
        {
            string Str = Regex.Unescape(Json);
            return Str;
        }

    }
}
