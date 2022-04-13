using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise.Domain.NotificationSchedule
{
    public class NotificationPlanFactory
    {
        private readonly NotificationSchema _schema;
        public NotificationPlanFactory(NotificationSchema schema)
        {
            _schema = schema;
        }
        public NotificationPlan CreateNotificationPlan(DateTime callDate, Settings.CompanyType companyType)
        {
            int[] schema = _schema.GetSchedule(companyType);
            if(schema == null)
            {
                return null;
            }
            NotificationPlan plan = new NotificationPlan();
            foreach (var n in schema)
            {
                plan.AddScheduleItem(n, callDate.AddDays(n));
            }
            return plan;
        }
    }
}
