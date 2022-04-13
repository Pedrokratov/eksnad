using Exercise.Domain.NotificationSchedule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise.Infrastructure
{
    public class NotificationPlanRepository: INotificationPlanRepository
    {
        public NotificationPlan GetNotificationPlan()
        {
            return new NotificationPlan();
        }
    }
}
