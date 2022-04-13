using Exercise.Application.Interfaces;
using Exercise.Domain.NotificationSchedule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exercise.Infrastructure;
using Exercise.Domain;

namespace Exercise.Application.Services
{
    public class NotificationService : INotificationService
    {
        private readonly INotificationSchemaRepository _scheduleRepository;
        public NotificationService(INotificationSchemaRepository scheduleRepository)
        {
            _scheduleRepository = scheduleRepository;
        }
        public NotificationPlan CreateNotificationSchedule(string country, int size, DateTime callDate)
        {
            NotificationSchema notificationSchemaForCountry = _scheduleRepository.GetNotificationSchedule(country);
            if(notificationSchemaForCountry is null)
            {
                //throws/log error
            }
            NotificationPlanFactory notificationPlanForCountry = new NotificationPlanFactory(notificationSchemaForCountry);
            return notificationPlanForCountry.CreateNotificationPlan(callDate, (Settings.CompanyType)size);
        }
    }
}
