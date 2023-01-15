
    public class DateAndTimeShamsi
    {

        public static string DateShamsi()
        {
            var currentDate = DateTime.Now;
            PersianCalendar pcCalender = new PersianCalendar();
            int year = pcCalender.GetYear(currentDate);
            int month = pcCalender.GetMonth(currentDate);
            int day = pcCalender.GetDayOfMonth(currentDate);
         
            string shamsiDate = string.Format("{0:yyyy/MM/dd}", (year + "/" + month + "/" + day));
  
            if (month < 10 && day > 9)
            {
                shamsiDate = string.Format("{0:yyyy/MM/dd}", (year + "/0" + month + "/" + day));
            }
            if (month < 10 && day < 10)
            {
                shamsiDate = string.Format("{0:yyyy/MM/dd}", (year + "/0" + month + "/0" + day));
            }
            if (month > 9 && day < 10)
            {
                shamsiDate = string.Format("{0:yyyy/MM/dd}", (year + "/" + month + "/0" + day));
            }
            if (month > 9 && day > 9)
            {
                shamsiDate = string.Format("{0:yyyy/MM/dd}", (year + "/" + month + "/" + day));
            }
            return shamsiDate;
        }

        public static string MyTime()
        {
            var currentDate = DateTime.Now;
            PersianCalendar pcCalender = new PersianCalendar();
            int year = pcCalender.GetYear(currentDate);
            int month = pcCalender.GetMonth(currentDate);
            int day = pcCalender.GetDayOfMonth(currentDate);

            string NowTime = string.Format("{0:hh:mm}", Convert.ToDateTime(pcCalender.GetHour(currentDate) + ":" + pcCalender.GetMinute(currentDate)));
            return NowTime;
        }
    }

