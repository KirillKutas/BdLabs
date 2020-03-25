using System;
using System.Collections.Generic;
using System.Text;

namespace laba2
{
    class DatBaseLog
    {
        DateTime modifyTime;
        string operation;
        string tableName;

        public DateTime  ModifyTime { get { return modifyTime; } }
        public string Operation { get { return operation; } }
        public string TableName { get { return tableName; } }

        public DatBaseLog(DateTime modifyTime, string operation, string tableName)
        {
            this.modifyTime = modifyTime;
            this.operation = operation;
            this.tableName = tableName;
        }
    }
}
