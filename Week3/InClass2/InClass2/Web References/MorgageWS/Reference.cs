﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace InClass2.MorgageWS {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="MortgageIndexSoap", Namespace="http://www.webserviceX.NET/")]
    public partial class MortgageIndex : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetCurrentMortgageIndexMonthlyOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetCurrentMortgageIndexByWeeklyOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetMortgageIndexByMonthOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetMortgageIndexByWeekOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public MortgageIndex() {
            this.Url = global::InClass2.Properties.Settings.Default.InClass2_MorgageWS_MortgageIndex;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event GetCurrentMortgageIndexMonthlyCompletedEventHandler GetCurrentMortgageIndexMonthlyCompleted;
        
        /// <remarks/>
        public event GetCurrentMortgageIndexByWeeklyCompletedEventHandler GetCurrentMortgageIndexByWeeklyCompleted;
        
        /// <remarks/>
        public event GetMortgageIndexByMonthCompletedEventHandler GetMortgageIndexByMonthCompleted;
        
        /// <remarks/>
        public event GetMortgageIndexByWeekCompletedEventHandler GetMortgageIndexByWeekCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.webserviceX.NET/GetCurrentMortgageIndexMonthly", RequestNamespace="http://www.webserviceX.NET/", ResponseNamespace="http://www.webserviceX.NET/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public MonthlyIndex GetCurrentMortgageIndexMonthly() {
            object[] results = this.Invoke("GetCurrentMortgageIndexMonthly", new object[0]);
            return ((MonthlyIndex)(results[0]));
        }
        
        /// <remarks/>
        public void GetCurrentMortgageIndexMonthlyAsync() {
            this.GetCurrentMortgageIndexMonthlyAsync(null);
        }
        
        /// <remarks/>
        public void GetCurrentMortgageIndexMonthlyAsync(object userState) {
            if ((this.GetCurrentMortgageIndexMonthlyOperationCompleted == null)) {
                this.GetCurrentMortgageIndexMonthlyOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetCurrentMortgageIndexMonthlyOperationCompleted);
            }
            this.InvokeAsync("GetCurrentMortgageIndexMonthly", new object[0], this.GetCurrentMortgageIndexMonthlyOperationCompleted, userState);
        }
        
        private void OnGetCurrentMortgageIndexMonthlyOperationCompleted(object arg) {
            if ((this.GetCurrentMortgageIndexMonthlyCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetCurrentMortgageIndexMonthlyCompleted(this, new GetCurrentMortgageIndexMonthlyCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.webserviceX.NET/GetCurrentMortgageIndexByWeekly", RequestNamespace="http://www.webserviceX.NET/", ResponseNamespace="http://www.webserviceX.NET/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public WeeklyIndex GetCurrentMortgageIndexByWeekly() {
            object[] results = this.Invoke("GetCurrentMortgageIndexByWeekly", new object[0]);
            return ((WeeklyIndex)(results[0]));
        }
        
        /// <remarks/>
        public void GetCurrentMortgageIndexByWeeklyAsync() {
            this.GetCurrentMortgageIndexByWeeklyAsync(null);
        }
        
        /// <remarks/>
        public void GetCurrentMortgageIndexByWeeklyAsync(object userState) {
            if ((this.GetCurrentMortgageIndexByWeeklyOperationCompleted == null)) {
                this.GetCurrentMortgageIndexByWeeklyOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetCurrentMortgageIndexByWeeklyOperationCompleted);
            }
            this.InvokeAsync("GetCurrentMortgageIndexByWeekly", new object[0], this.GetCurrentMortgageIndexByWeeklyOperationCompleted, userState);
        }
        
        private void OnGetCurrentMortgageIndexByWeeklyOperationCompleted(object arg) {
            if ((this.GetCurrentMortgageIndexByWeeklyCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetCurrentMortgageIndexByWeeklyCompleted(this, new GetCurrentMortgageIndexByWeeklyCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.webserviceX.NET/GetMortgageIndexByMonth", RequestNamespace="http://www.webserviceX.NET/", ResponseNamespace="http://www.webserviceX.NET/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public MonthlyIndex GetMortgageIndexByMonth(int Month, int Year) {
            object[] results = this.Invoke("GetMortgageIndexByMonth", new object[] {
                        Month,
                        Year});
            return ((MonthlyIndex)(results[0]));
        }
        
        /// <remarks/>
        public void GetMortgageIndexByMonthAsync(int Month, int Year) {
            this.GetMortgageIndexByMonthAsync(Month, Year, null);
        }
        
        /// <remarks/>
        public void GetMortgageIndexByMonthAsync(int Month, int Year, object userState) {
            if ((this.GetMortgageIndexByMonthOperationCompleted == null)) {
                this.GetMortgageIndexByMonthOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetMortgageIndexByMonthOperationCompleted);
            }
            this.InvokeAsync("GetMortgageIndexByMonth", new object[] {
                        Month,
                        Year}, this.GetMortgageIndexByMonthOperationCompleted, userState);
        }
        
        private void OnGetMortgageIndexByMonthOperationCompleted(object arg) {
            if ((this.GetMortgageIndexByMonthCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetMortgageIndexByMonthCompleted(this, new GetMortgageIndexByMonthCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.webserviceX.NET/GetMortgageIndexByWeek", RequestNamespace="http://www.webserviceX.NET/", ResponseNamespace="http://www.webserviceX.NET/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public WeeklyIndex GetMortgageIndexByWeek(int Day, int Month, int Year) {
            object[] results = this.Invoke("GetMortgageIndexByWeek", new object[] {
                        Day,
                        Month,
                        Year});
            return ((WeeklyIndex)(results[0]));
        }
        
        /// <remarks/>
        public void GetMortgageIndexByWeekAsync(int Day, int Month, int Year) {
            this.GetMortgageIndexByWeekAsync(Day, Month, Year, null);
        }
        
        /// <remarks/>
        public void GetMortgageIndexByWeekAsync(int Day, int Month, int Year, object userState) {
            if ((this.GetMortgageIndexByWeekOperationCompleted == null)) {
                this.GetMortgageIndexByWeekOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetMortgageIndexByWeekOperationCompleted);
            }
            this.InvokeAsync("GetMortgageIndexByWeek", new object[] {
                        Day,
                        Month,
                        Year}, this.GetMortgageIndexByWeekOperationCompleted, userState);
        }
        
        private void OnGetMortgageIndexByWeekOperationCompleted(object arg) {
            if ((this.GetMortgageIndexByWeekCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetMortgageIndexByWeekCompleted(this, new GetMortgageIndexByWeekCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.webserviceX.NET/")]
    public partial class MonthlyIndex {
        
        private string indexDateField;
        
        private string oneYearConstantMaturityTreasuryField;
        
        private string threeYearConstantMaturityTreasuryField;
        
        private string fiveYearConstantMaturityTreasuryField;
        
        private string threeMonthTreasuryBillField;
        
        private string sixMonthTreasuryBillField;
        
        private string threeMonthSecondaryMarketCDField;
        
        private string sixMonthSecondaryMarketCDField;
        
        private string eleventhDistrictCOFIField;
        
        private string costOfSavingsIndexField;
        
        private string oneMonthLIBORField;
        
        private string threeMonthLIBORField;
        
        private string sixMonthLIBORField;
        
        private string oneYearLIBORField;
        
        private string costOfDepositsIndexField;
        
        private string twelveMonthTreasuryAverageField;
        
        /// <remarks/>
        public string IndexDate {
            get {
                return this.indexDateField;
            }
            set {
                this.indexDateField = value;
            }
        }
        
        /// <remarks/>
        public string OneYearConstantMaturityTreasury {
            get {
                return this.oneYearConstantMaturityTreasuryField;
            }
            set {
                this.oneYearConstantMaturityTreasuryField = value;
            }
        }
        
        /// <remarks/>
        public string ThreeYearConstantMaturityTreasury {
            get {
                return this.threeYearConstantMaturityTreasuryField;
            }
            set {
                this.threeYearConstantMaturityTreasuryField = value;
            }
        }
        
        /// <remarks/>
        public string FiveYearConstantMaturityTreasury {
            get {
                return this.fiveYearConstantMaturityTreasuryField;
            }
            set {
                this.fiveYearConstantMaturityTreasuryField = value;
            }
        }
        
        /// <remarks/>
        public string ThreeMonthTreasuryBill {
            get {
                return this.threeMonthTreasuryBillField;
            }
            set {
                this.threeMonthTreasuryBillField = value;
            }
        }
        
        /// <remarks/>
        public string SixMonthTreasuryBill {
            get {
                return this.sixMonthTreasuryBillField;
            }
            set {
                this.sixMonthTreasuryBillField = value;
            }
        }
        
        /// <remarks/>
        public string ThreeMonthSecondaryMarketCD {
            get {
                return this.threeMonthSecondaryMarketCDField;
            }
            set {
                this.threeMonthSecondaryMarketCDField = value;
            }
        }
        
        /// <remarks/>
        public string SixMonthSecondaryMarketCD {
            get {
                return this.sixMonthSecondaryMarketCDField;
            }
            set {
                this.sixMonthSecondaryMarketCDField = value;
            }
        }
        
        /// <remarks/>
        public string EleventhDistrictCOFI {
            get {
                return this.eleventhDistrictCOFIField;
            }
            set {
                this.eleventhDistrictCOFIField = value;
            }
        }
        
        /// <remarks/>
        public string CostOfSavingsIndex {
            get {
                return this.costOfSavingsIndexField;
            }
            set {
                this.costOfSavingsIndexField = value;
            }
        }
        
        /// <remarks/>
        public string OneMonthLIBOR {
            get {
                return this.oneMonthLIBORField;
            }
            set {
                this.oneMonthLIBORField = value;
            }
        }
        
        /// <remarks/>
        public string ThreeMonthLIBOR {
            get {
                return this.threeMonthLIBORField;
            }
            set {
                this.threeMonthLIBORField = value;
            }
        }
        
        /// <remarks/>
        public string SixMonthLIBOR {
            get {
                return this.sixMonthLIBORField;
            }
            set {
                this.sixMonthLIBORField = value;
            }
        }
        
        /// <remarks/>
        public string OneYearLIBOR {
            get {
                return this.oneYearLIBORField;
            }
            set {
                this.oneYearLIBORField = value;
            }
        }
        
        /// <remarks/>
        public string CostOfDepositsIndex {
            get {
                return this.costOfDepositsIndexField;
            }
            set {
                this.costOfDepositsIndexField = value;
            }
        }
        
        /// <remarks/>
        public string TwelveMonthTreasuryAverage {
            get {
                return this.twelveMonthTreasuryAverageField;
            }
            set {
                this.twelveMonthTreasuryAverageField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.webserviceX.NET/")]
    public partial class WeeklyIndex {
        
        private string indexDateField;
        
        private string oneYearConstantMaturityTreasuryField;
        
        private string threeYearConstantMaturityTreasuryField;
        
        private string fiveYearConstantMaturityTreasuryField;
        
        private string threeMonthTreasuryBillField;
        
        private string sixMonthTreasuryBillField;
        
        private string threeMonthSecondaryMarketCDField;
        
        /// <remarks/>
        public string IndexDate {
            get {
                return this.indexDateField;
            }
            set {
                this.indexDateField = value;
            }
        }
        
        /// <remarks/>
        public string OneYearConstantMaturityTreasury {
            get {
                return this.oneYearConstantMaturityTreasuryField;
            }
            set {
                this.oneYearConstantMaturityTreasuryField = value;
            }
        }
        
        /// <remarks/>
        public string ThreeYearConstantMaturityTreasury {
            get {
                return this.threeYearConstantMaturityTreasuryField;
            }
            set {
                this.threeYearConstantMaturityTreasuryField = value;
            }
        }
        
        /// <remarks/>
        public string FiveYearConstantMaturityTreasury {
            get {
                return this.fiveYearConstantMaturityTreasuryField;
            }
            set {
                this.fiveYearConstantMaturityTreasuryField = value;
            }
        }
        
        /// <remarks/>
        public string ThreeMonthTreasuryBill {
            get {
                return this.threeMonthTreasuryBillField;
            }
            set {
                this.threeMonthTreasuryBillField = value;
            }
        }
        
        /// <remarks/>
        public string SixMonthTreasuryBill {
            get {
                return this.sixMonthTreasuryBillField;
            }
            set {
                this.sixMonthTreasuryBillField = value;
            }
        }
        
        /// <remarks/>
        public string ThreeMonthSecondaryMarketCD {
            get {
                return this.threeMonthSecondaryMarketCDField;
            }
            set {
                this.threeMonthSecondaryMarketCDField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void GetCurrentMortgageIndexMonthlyCompletedEventHandler(object sender, GetCurrentMortgageIndexMonthlyCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetCurrentMortgageIndexMonthlyCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetCurrentMortgageIndexMonthlyCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public MonthlyIndex Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((MonthlyIndex)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void GetCurrentMortgageIndexByWeeklyCompletedEventHandler(object sender, GetCurrentMortgageIndexByWeeklyCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetCurrentMortgageIndexByWeeklyCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetCurrentMortgageIndexByWeeklyCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public WeeklyIndex Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((WeeklyIndex)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void GetMortgageIndexByMonthCompletedEventHandler(object sender, GetMortgageIndexByMonthCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetMortgageIndexByMonthCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetMortgageIndexByMonthCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public MonthlyIndex Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((MonthlyIndex)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void GetMortgageIndexByWeekCompletedEventHandler(object sender, GetMortgageIndexByWeekCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetMortgageIndexByWeekCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetMortgageIndexByWeekCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public WeeklyIndex Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((WeeklyIndex)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591