using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schedule_v2
{
    static class SDate_
    {
        public static DateTime date_start = GetFirstDayMonth( DateTime.Today);
        public static DateTime date_end = DateTime.Today;

        enum Period
        {
            current_week,
            current_month,
            next_week,
            next_month
        }
        public static int GetNumDayOfWeek_(DateTime date_)
        {
            return ((int)date_.DayOfWeek == 0) ? 7 : (int)date_.DayOfWeek;
        }
        public static DateTime GetStartNextWeek_(DateTime date_start_)
        {
            DateTime temp_date = date_start_;
            while (temp_date.DayOfWeek != DayOfWeek.Monday) temp_date = temp_date.AddDays(1); //ближайший понедельник
            return temp_date;
        }
        public static DateTime GetLastDayWeek_(DateTime date_start_)
        {
            DateTime temp_date = date_start_;
            while (temp_date.DayOfWeek != DayOfWeek.Sunday) temp_date = temp_date.AddDays(1); //ближайшее воскресенье
            return temp_date;
        }
        public static DateTime GetFirstDayMonth(DateTime date_)
        {
            int year_ = date_.Year;
            int month_ = date_.Month;
            if (month_ > 12) { year_ += 1; month_ = 1; }
            DateTime first_day = new DateTime(year_, month_, 1);
            return first_day;
        }
        public static DateTime GetLastDayMonth(DateTime date_)
        {
            int year_ = date_.Year;
            int month_ = date_.Month + 1;
            if (month_ > 12) { year_ += 1; month_ = 1; }
            DateTime end_month = new DateTime(year_, month_, 1);
            return end_month.AddDays(-1);
        }
        public static DateTime GetStartFirstWeekOfMonth_()
        {

            int year_ = DateTime.Today.Year;
            int month_ = DateTime.Today.Month + 1;
            if (month_ > 12)
            {
                year_ += 1;
                month_ = 1;
            }
            DateTime start_month = new DateTime(year_, month_, 1);
            while (start_month.DayOfWeek != DayOfWeek.Monday) start_month = start_month.AddDays(1); //первый понедельник месяца
            return start_month;

        }
    }
}
