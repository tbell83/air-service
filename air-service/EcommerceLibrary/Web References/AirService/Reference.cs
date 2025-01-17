﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.18444.
// 
#pragma warning disable 1591

namespace EcommerceLibrary.AirService {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Data;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="AirServiceSoap", Namespace="http://tempuri.org/")]
    public partial class AirService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetAirCarriersOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetFlightsOperationCompleted;
        
        private System.Threading.SendOrPostCallback FindFlightsOperationCompleted;
        
        private System.Threading.SendOrPostCallback ReserveOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetTableOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public AirService() {
            this.Url = global::EcommerceLibrary.Properties.Settings.Default.EcommerceLibrary_AirService_AirService;
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
        public event GetAirCarriersCompletedEventHandler GetAirCarriersCompleted;
        
        /// <remarks/>
        public event GetFlightsCompletedEventHandler GetFlightsCompleted;
        
        /// <remarks/>
        public event FindFlightsCompletedEventHandler FindFlightsCompleted;
        
        /// <remarks/>
        public event ReserveCompletedEventHandler ReserveCompleted;
        
        /// <remarks/>
        public event GetTableCompletedEventHandler GetTableCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetAirCarriers", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet GetAirCarriers(string originCityName, string originState, string destinationCityName, string destinationState) {
            object[] results = this.Invoke("GetAirCarriers", new object[] {
                        originCityName,
                        originState,
                        destinationCityName,
                        destinationState});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void GetAirCarriersAsync(string originCityName, string originState, string destinationCityName, string destinationState) {
            this.GetAirCarriersAsync(originCityName, originState, destinationCityName, destinationState, null);
        }
        
        /// <remarks/>
        public void GetAirCarriersAsync(string originCityName, string originState, string destinationCityName, string destinationState, object userState) {
            if ((this.GetAirCarriersOperationCompleted == null)) {
                this.GetAirCarriersOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetAirCarriersOperationCompleted);
            }
            this.InvokeAsync("GetAirCarriers", new object[] {
                        originCityName,
                        originState,
                        destinationCityName,
                        destinationState}, this.GetAirCarriersOperationCompleted, userState);
        }
        
        private void OnGetAirCarriersOperationCompleted(object arg) {
            if ((this.GetAirCarriersCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetAirCarriersCompleted(this, new GetAirCarriersCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetFlights", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet GetFlights(int carrierID, string departureCity, string departureState, string arrivalCity, string arrivalState) {
            object[] results = this.Invoke("GetFlights", new object[] {
                        carrierID,
                        departureCity,
                        departureState,
                        arrivalCity,
                        arrivalState});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void GetFlightsAsync(int carrierID, string departureCity, string departureState, string arrivalCity, string arrivalState) {
            this.GetFlightsAsync(carrierID, departureCity, departureState, arrivalCity, arrivalState, null);
        }
        
        /// <remarks/>
        public void GetFlightsAsync(int carrierID, string departureCity, string departureState, string arrivalCity, string arrivalState, object userState) {
            if ((this.GetFlightsOperationCompleted == null)) {
                this.GetFlightsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetFlightsOperationCompleted);
            }
            this.InvokeAsync("GetFlights", new object[] {
                        carrierID,
                        departureCity,
                        departureState,
                        arrivalCity,
                        arrivalState}, this.GetFlightsOperationCompleted, userState);
        }
        
        private void OnGetFlightsOperationCompleted(object arg) {
            if ((this.GetFlightsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetFlightsCompleted(this, new GetFlightsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/FindFlights", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet FindFlights(string[] requirements, string originCityName, string originState, string destinationCityName, string destinationState) {
            object[] results = this.Invoke("FindFlights", new object[] {
                        requirements,
                        originCityName,
                        originState,
                        destinationCityName,
                        destinationState});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void FindFlightsAsync(string[] requirements, string originCityName, string originState, string destinationCityName, string destinationState) {
            this.FindFlightsAsync(requirements, originCityName, originState, destinationCityName, destinationState, null);
        }
        
        /// <remarks/>
        public void FindFlightsAsync(string[] requirements, string originCityName, string originState, string destinationCityName, string destinationState, object userState) {
            if ((this.FindFlightsOperationCompleted == null)) {
                this.FindFlightsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnFindFlightsOperationCompleted);
            }
            this.InvokeAsync("FindFlights", new object[] {
                        requirements,
                        originCityName,
                        originState,
                        destinationCityName,
                        destinationState}, this.FindFlightsOperationCompleted, userState);
        }
        
        private void OnFindFlightsOperationCompleted(object arg) {
            if ((this.FindFlightsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.FindFlightsCompleted(this, new FindFlightsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Reserve", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool Reserve(int customerID, int flightID1, string seatType1, string dt1, int flightID2, string seatType2, string dt2) {
            object[] results = this.Invoke("Reserve", new object[] {
                        customerID,
                        flightID1,
                        seatType1,
                        dt1,
                        flightID2,
                        seatType2,
                        dt2});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void ReserveAsync(int customerID, int flightID1, string seatType1, string dt1, int flightID2, string seatType2, string dt2) {
            this.ReserveAsync(customerID, flightID1, seatType1, dt1, flightID2, seatType2, dt2, null);
        }
        
        /// <remarks/>
        public void ReserveAsync(int customerID, int flightID1, string seatType1, string dt1, int flightID2, string seatType2, string dt2, object userState) {
            if ((this.ReserveOperationCompleted == null)) {
                this.ReserveOperationCompleted = new System.Threading.SendOrPostCallback(this.OnReserveOperationCompleted);
            }
            this.InvokeAsync("Reserve", new object[] {
                        customerID,
                        flightID1,
                        seatType1,
                        dt1,
                        flightID2,
                        seatType2,
                        dt2}, this.ReserveOperationCompleted, userState);
        }
        
        private void OnReserveOperationCompleted(object arg) {
            if ((this.ReserveCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ReserveCompleted(this, new ReserveCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetTable", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet GetTable(string tableName) {
            object[] results = this.Invoke("GetTable", new object[] {
                        tableName});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void GetTableAsync(string tableName) {
            this.GetTableAsync(tableName, null);
        }
        
        /// <remarks/>
        public void GetTableAsync(string tableName, object userState) {
            if ((this.GetTableOperationCompleted == null)) {
                this.GetTableOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetTableOperationCompleted);
            }
            this.InvokeAsync("GetTable", new object[] {
                        tableName}, this.GetTableOperationCompleted, userState);
        }
        
        private void OnGetTableOperationCompleted(object arg) {
            if ((this.GetTableCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetTableCompleted(this, new GetTableCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void GetAirCarriersCompletedEventHandler(object sender, GetAirCarriersCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetAirCarriersCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetAirCarriersCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void GetFlightsCompletedEventHandler(object sender, GetFlightsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetFlightsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetFlightsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void FindFlightsCompletedEventHandler(object sender, FindFlightsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class FindFlightsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal FindFlightsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void ReserveCompletedEventHandler(object sender, ReserveCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ReserveCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ReserveCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void GetTableCompletedEventHandler(object sender, GetTableCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetTableCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetTableCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591