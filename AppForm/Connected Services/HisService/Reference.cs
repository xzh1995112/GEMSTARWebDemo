﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppForm.HisService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="HisService.IHisService")]
    public interface IHisService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHisService/HospitalInfo", ReplyAction="http://tempuri.org/IHisService/HospitalInfoResponse")]
        string HospitalInfo(string composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHisService/HospitalInfo", ReplyAction="http://tempuri.org/IHisService/HospitalInfoResponse")]
        System.Threading.Tasks.Task<string> HospitalInfoAsync(string composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHisService/DepartmentsInfo", ReplyAction="http://tempuri.org/IHisService/DepartmentsInfoResponse")]
        string DepartmentsInfo(string msg);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHisService/DepartmentsInfo", ReplyAction="http://tempuri.org/IHisService/DepartmentsInfoResponse")]
        System.Threading.Tasks.Task<string> DepartmentsInfoAsync(string msg);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHisService/DepartmentsParentInfo", ReplyAction="http://tempuri.org/IHisService/DepartmentsParentInfoResponse")]
        string DepartmentsParentInfo(string composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHisService/DepartmentsParentInfo", ReplyAction="http://tempuri.org/IHisService/DepartmentsParentInfoResponse")]
        System.Threading.Tasks.Task<string> DepartmentsParentInfoAsync(string composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHisService/DoctorsInfo", ReplyAction="http://tempuri.org/IHisService/DoctorsInfoResponse")]
        string DoctorsInfo(string msg);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHisService/DoctorsInfo", ReplyAction="http://tempuri.org/IHisService/DoctorsInfoResponse")]
        System.Threading.Tasks.Task<string> DoctorsInfoAsync(string msg);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHisService/SynScheduleInfo", ReplyAction="http://tempuri.org/IHisService/SynScheduleInfoResponse")]
        string SynScheduleInfo(string msg);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHisService/SynScheduleInfo", ReplyAction="http://tempuri.org/IHisService/SynScheduleInfoResponse")]
        System.Threading.Tasks.Task<string> SynScheduleInfoAsync(string msg);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHisService/SynChangeScheduleStatusInfo", ReplyAction="http://tempuri.org/IHisService/SynChangeScheduleStatusInfoResponse")]
        string SynChangeScheduleStatusInfo(string msg);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHisService/SynChangeScheduleStatusInfo", ReplyAction="http://tempuri.org/IHisService/SynChangeScheduleStatusInfoResponse")]
        System.Threading.Tasks.Task<string> SynChangeScheduleStatusInfoAsync(string msg);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHisService/RegisterDocument", ReplyAction="http://tempuri.org/IHisService/RegisterDocumentResponse")]
        string RegisterDocument(string composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHisService/RegisterDocument", ReplyAction="http://tempuri.org/IHisService/RegisterDocumentResponse")]
        System.Threading.Tasks.Task<string> RegisterDocumentAsync(string composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHisService/ReportPrint", ReplyAction="http://tempuri.org/IHisService/ReportPrintResponse")]
        string ReportPrint(string composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHisService/ReportPrint", ReplyAction="http://tempuri.org/IHisService/ReportPrintResponse")]
        System.Threading.Tasks.Task<string> ReportPrintAsync(string composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHisService/CT_County", ReplyAction="http://tempuri.org/IHisService/CT_CountyResponse")]
        string CT_County(string composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHisService/CT_County", ReplyAction="http://tempuri.org/IHisService/CT_CountyResponse")]
        System.Threading.Tasks.Task<string> CT_CountyAsync(string composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHisService/CT_Province", ReplyAction="http://tempuri.org/IHisService/CT_ProvinceResponse")]
        string CT_Province(string composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHisService/CT_Province", ReplyAction="http://tempuri.org/IHisService/CT_ProvinceResponse")]
        System.Threading.Tasks.Task<string> CT_ProvinceAsync(string composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHisService/CT_City", ReplyAction="http://tempuri.org/IHisService/CT_CityResponse")]
        string CT_City(string composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHisService/CT_City", ReplyAction="http://tempuri.org/IHisService/CT_CityResponse")]
        System.Threading.Tasks.Task<string> CT_CityAsync(string composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHisService/CT_DeptCareProv", ReplyAction="http://tempuri.org/IHisService/CT_DeptCareProvResponse")]
        string CT_DeptCareProv(string composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHisService/CT_DeptCareProv", ReplyAction="http://tempuri.org/IHisService/CT_DeptCareProvResponse")]
        System.Threading.Tasks.Task<string> CT_DeptCareProvAsync(string composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHisService/CT_CareProv", ReplyAction="http://tempuri.org/IHisService/CT_CareProvResponse")]
        string CT_CareProv(string composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHisService/CT_CareProv", ReplyAction="http://tempuri.org/IHisService/CT_CareProvResponse")]
        System.Threading.Tasks.Task<string> CT_CareProvAsync(string composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHisService/CT_Dept", ReplyAction="http://tempuri.org/IHisService/CT_DeptResponse")]
        string CT_Dept(string composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHisService/CT_Dept", ReplyAction="http://tempuri.org/IHisService/CT_DeptResponse")]
        System.Threading.Tasks.Task<string> CT_DeptAsync(string composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHisService/CT_Nation", ReplyAction="http://tempuri.org/IHisService/CT_NationResponse")]
        string CT_Nation(string composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHisService/CT_Nation", ReplyAction="http://tempuri.org/IHisService/CT_NationResponse")]
        System.Threading.Tasks.Task<string> CT_NationAsync(string composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHisService/Deleted", ReplyAction="http://tempuri.org/IHisService/DeletedResponse")]
        string Deleted(string composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHisService/Deleted", ReplyAction="http://tempuri.org/IHisService/DeletedResponse")]
        System.Threading.Tasks.Task<string> DeletedAsync(string composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHisService/RegisterCareProvImage", ReplyAction="http://tempuri.org/IHisService/RegisterCareProvImageResponse")]
        string RegisterCareProvImage(string composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHisService/RegisterCareProvImage", ReplyAction="http://tempuri.org/IHisService/RegisterCareProvImageResponse")]
        System.Threading.Tasks.Task<string> RegisterCareProvImageAsync(string composite);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IHisServiceChannel : AppForm.HisService.IHisService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HisServiceClient : System.ServiceModel.ClientBase<AppForm.HisService.IHisService>, AppForm.HisService.IHisService {
        
        public HisServiceClient() {
        }
        
        public HisServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public HisServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HisServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HisServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string HospitalInfo(string composite) {
            return base.Channel.HospitalInfo(composite);
        }
        
        public System.Threading.Tasks.Task<string> HospitalInfoAsync(string composite) {
            return base.Channel.HospitalInfoAsync(composite);
        }
        
        public string DepartmentsInfo(string msg) {
            return base.Channel.DepartmentsInfo(msg);
        }
        
        public System.Threading.Tasks.Task<string> DepartmentsInfoAsync(string msg) {
            return base.Channel.DepartmentsInfoAsync(msg);
        }
        
        public string DepartmentsParentInfo(string composite) {
            return base.Channel.DepartmentsParentInfo(composite);
        }
        
        public System.Threading.Tasks.Task<string> DepartmentsParentInfoAsync(string composite) {
            return base.Channel.DepartmentsParentInfoAsync(composite);
        }
        
        public string DoctorsInfo(string msg) {
            return base.Channel.DoctorsInfo(msg);
        }
        
        public System.Threading.Tasks.Task<string> DoctorsInfoAsync(string msg) {
            return base.Channel.DoctorsInfoAsync(msg);
        }
        
        public string SynScheduleInfo(string msg) {
            return base.Channel.SynScheduleInfo(msg);
        }
        
        public System.Threading.Tasks.Task<string> SynScheduleInfoAsync(string msg) {
            return base.Channel.SynScheduleInfoAsync(msg);
        }
        
        public string SynChangeScheduleStatusInfo(string msg) {
            return base.Channel.SynChangeScheduleStatusInfo(msg);
        }
        
        public System.Threading.Tasks.Task<string> SynChangeScheduleStatusInfoAsync(string msg) {
            return base.Channel.SynChangeScheduleStatusInfoAsync(msg);
        }
        
        public string RegisterDocument(string composite) {
            return base.Channel.RegisterDocument(composite);
        }
        
        public System.Threading.Tasks.Task<string> RegisterDocumentAsync(string composite) {
            return base.Channel.RegisterDocumentAsync(composite);
        }
        
        public string ReportPrint(string composite) {
            return base.Channel.ReportPrint(composite);
        }
        
        public System.Threading.Tasks.Task<string> ReportPrintAsync(string composite) {
            return base.Channel.ReportPrintAsync(composite);
        }
        
        public string CT_County(string composite) {
            return base.Channel.CT_County(composite);
        }
        
        public System.Threading.Tasks.Task<string> CT_CountyAsync(string composite) {
            return base.Channel.CT_CountyAsync(composite);
        }
        
        public string CT_Province(string composite) {
            return base.Channel.CT_Province(composite);
        }
        
        public System.Threading.Tasks.Task<string> CT_ProvinceAsync(string composite) {
            return base.Channel.CT_ProvinceAsync(composite);
        }
        
        public string CT_City(string composite) {
            return base.Channel.CT_City(composite);
        }
        
        public System.Threading.Tasks.Task<string> CT_CityAsync(string composite) {
            return base.Channel.CT_CityAsync(composite);
        }
        
        public string CT_DeptCareProv(string composite) {
            return base.Channel.CT_DeptCareProv(composite);
        }
        
        public System.Threading.Tasks.Task<string> CT_DeptCareProvAsync(string composite) {
            return base.Channel.CT_DeptCareProvAsync(composite);
        }
        
        public string CT_CareProv(string composite) {
            return base.Channel.CT_CareProv(composite);
        }
        
        public System.Threading.Tasks.Task<string> CT_CareProvAsync(string composite) {
            return base.Channel.CT_CareProvAsync(composite);
        }
        
        public string CT_Dept(string composite) {
            return base.Channel.CT_Dept(composite);
        }
        
        public System.Threading.Tasks.Task<string> CT_DeptAsync(string composite) {
            return base.Channel.CT_DeptAsync(composite);
        }
        
        public string CT_Nation(string composite) {
            return base.Channel.CT_Nation(composite);
        }
        
        public System.Threading.Tasks.Task<string> CT_NationAsync(string composite) {
            return base.Channel.CT_NationAsync(composite);
        }
        
        public string Deleted(string composite) {
            return base.Channel.Deleted(composite);
        }
        
        public System.Threading.Tasks.Task<string> DeletedAsync(string composite) {
            return base.Channel.DeletedAsync(composite);
        }
        
        public string RegisterCareProvImage(string composite) {
            return base.Channel.RegisterCareProvImage(composite);
        }
        
        public System.Threading.Tasks.Task<string> RegisterCareProvImageAsync(string composite) {
            return base.Channel.RegisterCareProvImageAsync(composite);
        }
    }
}