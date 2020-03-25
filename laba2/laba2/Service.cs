using System;
using System.Collections.Generic;
using System.Text;

namespace laba2
{
    class Service
    {
        string serviceName;
        string serviceCustomer;
        int serviceCost;
        DateTime data;

        public string ServiceName { get { return serviceName; }}
        public string ServiceCustomer { get { return serviceCustomer; }}
        public int ServiceCost { get { return serviceCost; }}
        public DateTime Data { get { return data; }}

        public Service(string serviceName, string serviceCustomer, int serviceCost, DateTime data)
        {
            this.serviceName = serviceName;
            this.serviceCustomer = serviceCustomer;
            this.serviceCost = serviceCost;
            this.data = data;
        }
    }
}
