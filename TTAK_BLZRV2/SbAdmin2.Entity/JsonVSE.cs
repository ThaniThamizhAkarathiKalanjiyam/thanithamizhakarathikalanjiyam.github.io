
using System;

namespace TTAK_BLZRV2.Entity
{

    public class JsonVSE<RecordsClass> : IStockTakeEntityBase
    {
        public FilterVSE filter = new FilterVSE();
        public PostDataVSE<RecordsClass> postData = new PostDataVSE<RecordsClass>();
        public JtParamsVSE jtParams = new JtParamsVSE();
    }

    public class JsonVSE : IStockTakeEntityBase
    {
        public FilterVSE filter = new FilterVSE();
        public PostDataVSE postData = new PostDataVSE();
        public JtParamsVSE jtParams = new JtParamsVSE();
    }
}
