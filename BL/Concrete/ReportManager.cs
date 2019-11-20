using BL.Abstract;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Dynamic;

namespace BL.Concrete
{
    public class ReportManager : IReportService
    {
        #region Private Fields

        List<WorkOrderDto> workOrderList = new List<WorkOrderDto> {
            new WorkOrderDto{ Id=1001, Start=DateTime.ParseExact("01.01.2017 08:00:00", "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture ),
                                       Finish=DateTime.ParseExact("01.01.2017 16:00:00", "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture )},
            new WorkOrderDto{ Id=1002, Start=DateTime.ParseExact("01.01.2017 16:00:00", "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture ),
                                       Finish=DateTime.ParseExact("02.01.2017 00:00:00", "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture )},
            new WorkOrderDto{ Id=1003, Start=DateTime.ParseExact("02.01.2017 00:00:00", "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture ),
                                       Finish=DateTime.ParseExact("02.01.2017 08:00:00", "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture )},
            new WorkOrderDto{ Id=1004, Start=DateTime.ParseExact("02.01.2017 08:00:00", "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture ),
                                       Finish=DateTime.ParseExact("02.01.2017 16:00:00", "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture )},
            new WorkOrderDto{ Id=1005, Start=DateTime.ParseExact("02.01.2017 16:00:00", "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture ),
                                       Finish=DateTime.ParseExact("03.01.2017 00:00:00", "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture )},
            new WorkOrderDto{ Id=1006, Start=DateTime.ParseExact("03.01.2017 00:00:00", "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture ),
                                       Finish=DateTime.ParseExact("03.01.2017 08:00:00", "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture )},
            new WorkOrderDto{ Id=1007, Start=DateTime.ParseExact("03.01.2017 08:00:00", "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture ),
                                       Finish=DateTime.ParseExact("03.01.2017 16:00:00", "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture )},
            new WorkOrderDto{ Id=1008, Start=DateTime.ParseExact("03.01.2017 16:00:00", "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture ),
                                       Finish=DateTime.ParseExact("04.01.2017 00:00:00", "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture )},
            new WorkOrderDto{ Id=1009, Start=DateTime.ParseExact("04.01.2017 00:00:00", "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture ),
                                       Finish=DateTime.ParseExact("04.01.2017 08:00:00", "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture )},
        };

        List<ReasonOfWaitingDto> reasonOfWaitingList = new List<ReasonOfWaitingDto>
        {
            new ReasonOfWaitingDto{ Reason="Mola", Start=DateTime.ParseExact("01.01.2017 10:00:00", "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture ),
                                                   Finish=DateTime.ParseExact("01.01.2017 10:10:00", "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture )},
            new ReasonOfWaitingDto{ Reason="Arıza",Start=DateTime.ParseExact("01.01.2017 10:30:00", "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture ),
                                                   Finish=DateTime.ParseExact("01.01.2017 11:00:00", "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture )},
            new ReasonOfWaitingDto{ Reason="Mola", Start=DateTime.ParseExact("01.01.2017 12:00:00", "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture ),
                                                   Finish=DateTime.ParseExact("01.01.2017 12:30:00", "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture )},
            new ReasonOfWaitingDto{ Reason="Mola", Start=DateTime.ParseExact("01.01.2017 14:00:00", "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture ),
                                                   Finish=DateTime.ParseExact("01.01.2017 14:10:00", "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture )},
            new ReasonOfWaitingDto{ Reason="Setup",Start=DateTime.ParseExact("01.01.2017 15:00:00", "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture ),
                                                   Finish=DateTime.ParseExact("01.01.2017 16:30:00", "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture )},
            new ReasonOfWaitingDto{ Reason="Mola", Start=DateTime.ParseExact("01.01.2017 18:00:00", "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture ),
                                                   Finish=DateTime.ParseExact("01.01.2017 18:10:00", "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture )},
            new ReasonOfWaitingDto{ Reason="Mola", Start=DateTime.ParseExact("01.01.2017 20:00:00", "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture ),
                                                   Finish=DateTime.ParseExact("01.01.2017 20:30:00", "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture )},
            new ReasonOfWaitingDto{ Reason="Mola", Start=DateTime.ParseExact("01.01.2017 22:00:00", "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture ),
                                                   Finish=DateTime.ParseExact("01.01.2017 22:10:00", "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture )},
            new ReasonOfWaitingDto{ Reason="Arge", Start=DateTime.ParseExact("01.01.2017 23:00:00", "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture ),
                                                   Finish=DateTime.ParseExact("02.01.2017 08:30:00", "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture )},
            new ReasonOfWaitingDto{ Reason="Mola", Start=DateTime.ParseExact("02.01.2017 10:00:00", "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture ),
                                                   Finish=DateTime.ParseExact("02.01.2017 10:10:00", "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture )},
            new ReasonOfWaitingDto{ Reason="Mola", Start=DateTime.ParseExact("02.01.2017 12:00:00", "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture ),
                                                   Finish=DateTime.ParseExact("02.01.2017 12:30:00", "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture )},
            new ReasonOfWaitingDto{ Reason="Arıza",Start=DateTime.ParseExact("02.01.2017 13:00:00", "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture ),
                                                   Finish=DateTime.ParseExact("02.01.2017 13:45:00", "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture )},
            new ReasonOfWaitingDto{ Reason="Mola", Start=DateTime.ParseExact("02.01.2017 14:00:00", "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture ),
                                                   Finish=DateTime.ParseExact("02.01.2017 14:10:00", "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture )},
            new ReasonOfWaitingDto{ Reason="Mola", Start=DateTime.ParseExact("02.01.2017 18:00:00", "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture ),
                                                   Finish=DateTime.ParseExact("02.01.2017 18:10:00", "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture )},
            new ReasonOfWaitingDto{ Reason="Arge", Start=DateTime.ParseExact("02.01.2017 20:00:00", "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture ),
                                                   Finish=DateTime.ParseExact("03.01.2017 02:10:00", "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture )},
            new ReasonOfWaitingDto{ Reason="Mola", Start=DateTime.ParseExact("03.01.2017 04:00:00", "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture ),
                                                   Finish=DateTime.ParseExact("03.01.2017 04:30:00", "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture )},
            new ReasonOfWaitingDto{ Reason="Setup",Start=DateTime.ParseExact("03.01.2017 06:00:00", "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture ),
                                                   Finish=DateTime.ParseExact("03.01.2017 09:30:00", "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture )},
            new ReasonOfWaitingDto{ Reason="Mola", Start=DateTime.ParseExact("03.01.2017 10:00:00", "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture ),
                                                   Finish=DateTime.ParseExact("03.01.2017 10:10:00", "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture )},
            new ReasonOfWaitingDto{ Reason="Mola", Start=DateTime.ParseExact("03.01.2017 12:00:00", "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture ),
                                                   Finish=DateTime.ParseExact("03.01.2017 12:30:00", "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture )},
            new ReasonOfWaitingDto{ Reason="Mola", Start=DateTime.ParseExact("03.01.2017 14:00:00", "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture ),
                                                   Finish=DateTime.ParseExact("03.01.2017 14:10:00", "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture )},
            new ReasonOfWaitingDto{ Reason="Arıza",Start=DateTime.ParseExact("03.01.2017 15:00:00", "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture ),
                                                   Finish=DateTime.ParseExact("03.01.2017 18:45:00", "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture )},
            new ReasonOfWaitingDto{ Reason="Mola", Start=DateTime.ParseExact("03.01.2017 20:00:00", "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture ),
                                                   Finish=DateTime.ParseExact("03.01.2017 20:30:00", "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture )},
            new ReasonOfWaitingDto{ Reason="Mola", Start=DateTime.ParseExact("03.01.2017 22:00:00", "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture ),
                                                   Finish=DateTime.ParseExact("03.01.2017 22:10:00", "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture )},
        };

        #endregion Private Fields

        #region Public Methods

        public ReportManager()
        {
        }

        public ResultModel GetAll()
        {
            List<IDictionary<string, object>> dictionaryList = new List<IDictionary<string, object>>();

            var durationList = new List<ReportDto>();

            var columns = new List<string>();
            columns.Add("Id");

            columns.AddRange(reasonOfWaitingList.Select(x => x.Reason).Distinct().OrderBy(o => o).ToList());


            foreach (var isemri in workOrderList)
            {
                foreach (var reason in columns.Where(x => x != "Id").ToList())
                {
                    var duration = reasonOfWaitingList.Where(bekleme => bekleme.Reason == reason && ((bekleme.Start >= isemri.Start && bekleme.Start <= isemri.Finish) ||
                                                                                                     (bekleme.Start < isemri.Start && bekleme.Finish >= isemri.Start) ||
                                                                                                     (bekleme.Finish <= isemri.Finish && bekleme.Finish >= isemri.Start)))
                                      .Sum(s => (s.Finish - s.Start).TotalMinutes - (s.Finish > isemri.Finish ? (s.Finish - isemri.Finish).TotalMinutes : 0)
                                                                                  - (s.Start < isemri.Start ? (isemri.Start - s.Start).TotalMinutes : 0));
                    var reportDto = new ReportDto
                    {
                        OrderId = isemri.Id,
                        Reason = reason,
                        Duration = duration
                    };

                    durationList.Add(reportDto);
                }
            }

            var reasonTotals = new List<TotalResultModel>();

            foreach (var reason in columns.Where(s => s != "Id").ToList())
            {
                reasonTotals.Add(new TotalResultModel
                {
                    Reason = reason,
                    Total = 0
                });
            }

            reasonTotals.Add(new TotalResultModel
            {
                Reason = "Toplam",
                Total = 0
            });

            var idList = durationList.Select(x => x.OrderId).Distinct().ToList();

            foreach (var id in idList)
            {
                dynamic line = new ExpandoObject();
                line.Id = id;

                var dictionary = (IDictionary<string, object>)line;

                double totalDuration = 0;
                foreach (var reason in columns.Where(s => s != "Id").ToList())
                {
                    var duration = durationList.Where(x => x.OrderId == id && x.Reason == reason).FirstOrDefault()?.Duration ?? 0;

                    dictionary.Add(reason, duration);

                    totalDuration += duration;

                    var reasonTotal = reasonTotals.Where(x => x.Reason == reason).FirstOrDefault();
                    reasonTotal.Total += duration;
                }

                dictionary.Add("Toplam", totalDuration);

                var totalOfTotal = reasonTotals.Where(x => x.Reason == "Toplam").FirstOrDefault();
                totalOfTotal.Total += totalDuration;

                dictionaryList.Add(dictionary);
            }

            columns.Add("Toplam");

            var resultModel = new ResultModel
            {
                Durations = dictionaryList,
                Reasons = columns,
                ReasonTotal = reasonTotals
            };

            return resultModel;
        }

        #endregion
    }
}