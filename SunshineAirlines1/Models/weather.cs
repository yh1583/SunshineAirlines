using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunshineAirlines1.Models
{
    public class Weather
    {
        public Weather(string city, string country, string wea, string wea_img, string tem, string tem1, string tem2, string win, string win_speed, string win_meter, string humidity, string visibility, string pressure, string air, string air_level, string air_tips)
        {
            this.city = city;
            this.country = country;
            this.wea = wea;
            this.wea_img = wea_img;
            this.tem = tem;
            this.tem1 = tem1;
            this.tem2 = tem2;
            this.win = win;
            this.win_speed = win_speed;
            this.win_meter = win_meter;
            this.humidity = humidity;
            this.visibility = visibility;
            this.pressure = pressure;
            this.air = air;
            this.air_level = air_level;
            this.air_tips = air_tips;
        }


        /// <summary>
        /// 城市名
        /// </summary>
        public  string city { get; private set; }

        /// <summary>
        /// 国家名
        /// </summary>
        public  string country { get; private set; }

        /// <summary>
        /// 天气状况
        /// </summary>
        public  string wea { get; private set; }

        /// <summary>
        /// 天气状况图片
        /// </summary>
        public string wea_img { get; private set; }
        /// <summary>
        /// 实时温度
        /// </summary>
        public  string tem { get; private set; }
        /// <summary>
        /// 最高温度
        /// </summary>
        public  string tem1 { get; private set; }
        /// <summary>
        /// 最低温度
        /// </summary>
        public  string tem2 { get; private set; }


        /// <summary>
        /// 风向
        /// </summary>
        public  string win { get; private set; }

        /// <summary>
        /// 风力等级
        /// </summary>
        public  string win_speed { get; private set; }

        /// <summary>
        /// 风速
        /// </summary>
        public  string win_meter { get; private set; }


        /// <summary>
        /// 湿度
        /// </summary>
        public  string humidity { get; private set; }

        /// <summary>
        /// 能见度
        /// </summary>
        public  string visibility { get; private set; }

        /// <summary>
        /// 气压hPa
        /// </summary>
        public  string pressure { get; private set; }



        /// <summary>
        /// 空气质量
        /// </summary>
        public  string air { get; private set; }


        /// <summary>
        /// 空气质量等级
        /// </summary>
        public  string air_level { get; private set; }

        /// <summary>
        /// 空气质量描述
        /// </summary>
        public  string air_tips { get; private set; }


 
    }
}
