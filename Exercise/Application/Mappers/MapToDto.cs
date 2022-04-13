using Exercise.Domain;
using Exercise.Domain.NotificationSchedule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise.Application.Mappers
{
    public static class MapToDto
    {
        public static Presentation.NotificationPlan MapToNotificationPlan(Company domain)
        {
            return new Presentation.NotificationPlan
            {
                companyId = domain.Id,
                notifications = domain.NotificationPlan.Schedule.Select(x=>x.Value.ToString("dd/MM/yyyy"))
            };
        }
    }
}
