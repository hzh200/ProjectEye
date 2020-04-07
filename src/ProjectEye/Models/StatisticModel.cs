﻿using Project1.UI.Controls.ChartControl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEye.Models
{
    public class StatisticModel : UINotifyPropertyChanged
    {
        private int Year_;
        public int Year
        {
            get
            {
                return Year_;
            }
            set
            {
                Year_ = value;
                OnPropertyChanged("Year");
            }
        }
        private int Month_;
        public int Month
        {
            get
            {
                return Month_;
            }
            set
            {
                Month_ = value;
                OnPropertyChanged("Month");
            }
        }

        private List<ChartDataModel> MonthWorkData_;
        /// <summary>
        /// 月份工作统计数据
        /// </summary>
        public List<ChartDataModel> MonthWorkData { get { return MonthWorkData_; } set { MonthWorkData_ = value; OnPropertyChanged(); } }


        private List<ChartDataModel> MonthRestData_;
        /// <summary>
        /// 月份休息统计数据
        /// </summary>
        public List<ChartDataModel> MonthRestData { get { return MonthRestData_; } set { MonthRestData_ = value; OnPropertyChanged(); } }

        private List<ChartDataModel> MonthSkipData_;
        /// <summary>
        /// 月份跳过统计数据
        /// </summary>
        public List<ChartDataModel> MonthSkipData { get { return MonthSkipData_; } set { MonthSkipData_ = value; OnPropertyChanged(); } }

        #region 本周数据
        private List<ChartDataModel> WeekWorkData_;
        /// <summary>
        /// 本周工作统计数据
        /// </summary>
        public List<ChartDataModel> WeekWorkData { get { return WeekWorkData_; } set { WeekWorkData_ = value; OnPropertyChanged(); } }


        private List<ChartDataModel> WeekRestData_;
        /// <summary>
        /// 本周休息统计数据
        /// </summary>
        public List<ChartDataModel> WeekRestData { get { return WeekRestData_; } set { WeekRestData_ = value; OnPropertyChanged(); } }

        private List<ChartDataModel> WeekSkipData_;
        /// <summary>
        /// 本周跳过统计数据
        /// </summary>
        public List<ChartDataModel> WeekSkipData { get { return WeekSkipData_; } set { WeekSkipData_ = value; OnPropertyChanged(); } }
        #endregion

        #region 本月数据总和
        private double MonthWork_;
        public double MonthWork
        {
            get
            {
                return MonthWork_;
            }
            set
            {
                MonthWork_ = value;
                OnPropertyChanged();
            }
        }
        private double MonthRest_;
        public double MonthRest
        {
            get
            {
                return MonthRest_;
            }
            set
            {
                MonthRest_ = value;
                OnPropertyChanged();
            }
        }
        private int MonthSkip_;
        public int MonthSkip
        {
            get
            {
                return MonthSkip_;
            }
            set
            {
                MonthSkip_ = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region 上月数据总和
        private double LastMonthWork_;
        public double LastMonthWork
        {
            get
            {
                return LastMonthWork_;
            }
            set
            {
                LastMonthWork_ = value;
                OnPropertyChanged();
            }
        }
        private double LastMonthRest_;
        public double LastMonthRest
        {
            get
            {
                return LastMonthRest_;
            }
            set
            {
                LastMonthRest_ = value;
                OnPropertyChanged();
            }
        }
        private int LastMonthSkip_;
        public int LastMonthSkip
        {
            get
            {
                return LastMonthSkip_;
            }
            set
            {
                LastMonthSkip_ = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region 本周数据总和
        private double WeekWork_;
        public double WeekWork
        {
            get
            {
                return WeekWork_;
            }
            set
            {
                WeekWork_ = value;
                OnPropertyChanged();
            }
        }
        private double WeekRest_;
        public double WeekRest
        {
            get
            {
                return WeekRest_;
            }
            set
            {
                WeekRest_ = value;
                OnPropertyChanged();
            }
        }
        private int WeekSkip_;
        public int WeekSkip
        {
            get
            {
                return WeekSkip_;
            }
            set
            {
                WeekSkip_ = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region 上周数据总和
        private double LastWeekWork_;
        public double LastWeekWork
        {
            get
            {
                return LastWeekWork_;
            }
            set
            {
                LastWeekWork_ = value;
                OnPropertyChanged();
            }
        }
        private double LastWeekRest_;
        public double LastWeekRest
        {
            get
            {
                return LastWeekRest_;
            }
            set
            {
                LastWeekRest_ = value;
                OnPropertyChanged();
            }
        }
        private int LastWeekSkip_;
        public int LastWeekSkip
        {
            get
            {
                return LastWeekSkip_;
            }
            set
            {
                LastWeekSkip_ = value;
                OnPropertyChanged();
            }
        }
        #endregion
    }
}
