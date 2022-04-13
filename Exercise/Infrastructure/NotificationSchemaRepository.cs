using Exercise.Domain;
using Exercise.Domain.NotificationSchedule;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise.Infrastructure
{
    public class NotificationSchemaRepository : INotificationSchemaRepository
    {
        //could be retireved from database
        private List<Domain.NotificationSchedule.NotificationSchema> _rules = new List<Domain.NotificationSchedule.NotificationSchema>
        {
            new Domain.NotificationSchedule.NotificationSchema()
            {
                Country = "Denmark",
                Schedule = new Dictionary<Settings.CompanyType, int[]>()
                {
                    { Settings.CompanyType.common, new int[] { 1, 5,10,15,20} },
                }
            },
            new Domain.NotificationSchedule.NotificationSchema()
            {
                Country = "Norway",
                Schedule = new Dictionary<Settings.CompanyType, int[]>()
                {
                    { Settings.CompanyType.common, new int[] { 1, 5,10,20} }
                }
            },
                      new Domain.NotificationSchedule.NotificationSchema()
            {
                Country = "Sweden",
                Schedule = new Dictionary<Settings.CompanyType, int[]>()
                {
                    { Settings.CompanyType.small, new int[] { 1, 7,14,28} },
                    { Settings.CompanyType.medium, new int[] { 1, 7,14,28} }
                }
            },
                                            new Domain.NotificationSchedule.NotificationSchema()
            {
                Country = "Finland",
                Schedule = new Dictionary<Settings.CompanyType, int[]>()
                {
                    { Settings.CompanyType.large, new int[] { 1, 5,10,15,20} }
                }
            }
        };
        public NotificationSchema GetNotificationSchedule(string country)
        {
            NotificationSchema schema = _rules
                .FirstOrDefault(x => string.Compare(country, x.Country, true, CultureInfo.InvariantCulture) == 0);
            return schema;
        }
    }
}
