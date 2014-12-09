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

namespace test_page.AirService {
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
        
        private System.Threading.SendOrPostCallback getCitiesOperationCompleted;
        
        private System.Threading.SendOrPostCallback getFlightsFromOperationCompleted;
        
        private System.Threading.SendOrPostCallback getFlightsToOperationCompleted;
        
        private System.Threading.SendOrPostCallback ReserveSingleOperationCompleted;
        
        private System.Threading.SendOrPostCallback ReserveOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetTableOperationCompleted;
        
        private System.Threading.SendOrPostCallback CheckAvailableOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public AirService() {
            this.Url = global::test_page.Properties.Settings.Default.test_page_AirService_AirService;
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
        public event getCitiesCompletedEventHandler getCitiesCompleted;
        
        /// <remarks/>
        public event getFlightsFromCompletedEventHandler getFlightsFromCompleted;
        
        /// <remarks/>
        public event getFlightsToCompletedEventHandler getFlightsToCompleted;
        
        /// <remarks/>
        public event ReserveSingleCompletedEventHandler ReserveSingleCompleted;
        
        /// <remarks/>
        public event ReserveCompletedEventHandler ReserveCompleted;
        
        /// <remarks/>
        public event GetTableCompletedEventHandler GetTableCompleted;
        
        /// <remarks/>
        public event CheckAvailableCompletedEventHandler CheckAvailableCompleted;
        
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
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getCities", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet getCities() {
            object[] results = this.Invoke("getCities", new object[0]);
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void getCitiesAsync() {
            this.getCitiesAsync(null);
        }
        
        /// <remarks/>
        public void getCitiesAsync(object userState) {
            if ((this.getCitiesOperationCompleted == null)) {
                this.getCitiesOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetCitiesOperationCompleted);
            }
            this.InvokeAsync("getCities", new object[0], this.getCitiesOperationCompleted, userState);
        }
        
        private void OngetCitiesOperationCompleted(object arg) {
            if ((this.getCitiesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getCitiesCompleted(this, new getCitiesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getFlightsFrom", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet getFlightsFrom(int originAirportID) {
            object[] results = this.Invoke("getFlightsFrom", new object[] {
                        originAirportID});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void getFlightsFromAsync(int originAirportID) {
            this.getFlightsFromAsync(originAirportID, null);
        }
        
        /// <remarks/>
        public void getFlightsFromAsync(int originAirportID, object userState) {
            if ((this.getFlightsFromOperationCompleted == null)) {
                this.getFlightsFromOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetFlightsFromOperationCompleted);
            }
            this.InvokeAsync("getFlightsFrom", new object[] {
                        originAirportID}, this.getFlightsFromOperationCompleted, userState);
        }
        
        private void OngetFlightsFromOperationCompleted(object arg) {
            if ((this.getFlightsFromCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getFlightsFromCompleted(this, new getFlightsFromCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getFlightsTo", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet getFlightsTo(int destinationAirportID) {
            object[] results = this.Invoke("getFlightsTo", new object[] {
                        destinationAirportID});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void getFlightsToAsync(int destinationAirportID) {
            this.getFlightsToAsync(destinationAirportID, null);
        }
        
        /// <remarks/>
        public void getFlightsToAsync(int destinationAirportID, object userState) {
            if ((this.getFlightsToOperationCompleted == null)) {
                this.getFlightsToOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetFlightsToOperationCompleted);
            }
            this.InvokeAsync("getFlightsTo", new object[] {
                        destinationAirportID}, this.getFlightsToOperationCompleted, userState);
        }
        
        private void OngetFlightsToOperationCompleted(object arg) {
            if ((this.getFlightsToCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getFlightsToCompleted(this, new getFlightsToCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ReserveSingle", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool ReserveSingle(int customerID, int flightID, string seatType, string dateTime) {
            object[] results = this.Invoke("ReserveSingle", new object[] {
                        customerID,
                        flightID,
                        seatType,
                        dateTime});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void ReserveSingleAsync(int customerID, int flightID, string seatType, string dateTime) {
            this.ReserveSingleAsync(customerID, flightID, seatType, dateTime, null);
        }
        
        /// <remarks/>
        public void ReserveSingleAsync(int customerID, int flightID, string seatType, string dateTime, object userState) {
            if ((this.ReserveSingleOperationCompleted == null)) {
                this.ReserveSingleOperationCompleted = new System.Threading.SendOrPostCallback(this.OnReserveSingleOperationCompleted);
            }
            this.InvokeAsync("ReserveSingle", new object[] {
                        customerID,
                        flightID,
                        seatType,
                        dateTime}, this.ReserveSingleOperationCompleted, userState);
        }
        
        private void OnReserveSingleOperationCompleted(object arg) {
            if ((this.ReserveSingleCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ReserveSingleCompleted(this, new ReserveSingleCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CheckAvailable", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int CheckAvailable(int flightID, System.DateTime flightDate, string seatClass) {
            object[] results = this.Invoke("CheckAvailable", new object[] {
                        flightID,
                        flightDate,
                        seatClass});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void CheckAvailableAsync(int flightID, System.DateTime flightDate, string seatClass) {
            this.CheckAvailableAsync(flightID, flightDate, seatClass, null);
        }
        
        /// <remarks/>
        public void CheckAvailableAsync(int flightID, System.DateTime flightDate, string seatClass, object userState) {
            if ((this.CheckAvailableOperationCompleted == null)) {
                this.CheckAvailableOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCheckAvailableOperationCompleted);
            }
            this.InvokeAsync("CheckAvailable", new object[] {
                        flightID,
                        flightDate,
                        seatClass}, this.CheckAvailableOperationCompleted, userState);
        }
        
        private void OnCheckAvailableOperationCompleted(object arg) {
            if ((this.CheckAvailableCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CheckAvailableCompleted(this, new CheckAvailableCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    public delegate void getCitiesCompletedEventHandler(object sender, getCitiesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getCitiesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getCitiesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void getFlightsFromCompletedEventHandler(object sender, getFlightsFromCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getFlightsFromCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getFlightsFromCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void getFlightsToCompletedEventHandler(object sender, getFlightsToCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getFlightsToCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getFlightsToCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void ReserveSingleCompletedEventHandler(object sender, ReserveSingleCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ReserveSingleCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ReserveSingleCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void CheckAvailableCompletedEventHandler(object sender, CheckAvailableCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CheckAvailableCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CheckAvailableCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591