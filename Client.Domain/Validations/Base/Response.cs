using Client.Domain.Validations.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Client.Domain.Validations.Base
{
    public class Response
    {
        public Response()
        {
            Report = new List<ReportErrors>();
        }

        public Response(List<ReportErrors> reports)
        {
            Report = reports ?? new List<ReportErrors>();
        }

        public Response(ReportErrors report) : this(new List<ReportErrors>() { report })
        {

        }

        public List<ReportErrors> Report { get; }


        public static Response<T> OK<T>(T data) => new Response<T>(data);
        public static Response OK() => new Response();
        public static Response Unprocessed(List<ReportErrors> reports) => new Response(reports);
        public static Response Unprocessed(ReportErrors report) => new Response(report);
        public static Response<T> Unprocessed<T>(List<ReportErrors> reports)
        {
            return new Response<T>(reports);
        }
    }

    public class Response<T> : Response
    {
        public Response()
        {

        }
        public Response(List<ReportErrors> reports) : base(reports)
        {
        }
        public Response(T data, List<ReportErrors> reports = null) : base(reports)
        {
            Data = data;
        }

        public T Data { get; set; }
    }
}