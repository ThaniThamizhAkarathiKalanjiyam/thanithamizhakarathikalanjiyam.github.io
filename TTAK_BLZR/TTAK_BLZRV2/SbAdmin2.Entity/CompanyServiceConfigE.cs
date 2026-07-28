namespace TTAK_BLZRV2.Entity
{
    public class CompanyServiceConfigE : JTableE
    {
        public string CompId { get; set; }
        //1Company Name
        public string CompanyName { get; set; }
        //2Web Service Company Name
        public string WebServiceCompanyName { get; set; }
        //3SSL Enabled
        public string IsSSL { get; set; }
        //4Server Address
        public string ServerAddress { get; set; }
        //5Port Number
        public string PortNumber { get; set; }
        //6Instance Name
        public string ObjectName { get; set; }
        //7User Name
        public string UserName { get; set; }
        //8Password
        public string Password { get; set; }
        //9Url
        public string Url { get; set; }
        public string InstanceName { get; set; }

        public string Domain { get; set; }

        public string NavisionVersion { get; set; }

        public string Authorization { get; set; }
        public string tenant_id { get; set; }
        public object client_id { get; set; }
        public object client_secret { get; set; }
        public string WStype { get; set; }
    }
}
