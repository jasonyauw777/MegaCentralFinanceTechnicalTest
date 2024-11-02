namespace MegaCentralFinanceBackend.Requests
{
    public class BPKBFormRequest
    {
        public string AgreementNumber { get; set; }
        public string BranchID { get; set; }
        public string BPKBNo { get; set; }
        public DateTime BPKBIn {  get; set; }
        public DateTime BPKBDate { get; set; }
        public string FakturNo { get; set; }
        public DateTime FakturDate { get; set;}
        public string PoliceNo { get; set; }    
        public string LocationID { get; set; }
    }
}
