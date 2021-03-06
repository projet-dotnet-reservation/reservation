﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.18449
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Ce code source a été automatiquement généré par Microsoft.VSDesigner, Version 4.0.30319.18449.
// 
#pragma warning disable 1591

namespace RechercheVolsHotels.wsVol {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="ServiceVolSoap", Namespace="http://tempuri.org/")]
    public partial class ServiceVol : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback rechercheVolsOperationCompleted;
        
        private System.Threading.SendOrPostCallback rechercheVolsAvecDateOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public ServiceVol() {
            this.Url = global::RechercheVolsHotels.Properties.Settings.Default.RechercheVolsHotels_wsVol_ServiceVol;
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
        public event rechercheVolsCompletedEventHandler rechercheVolsCompleted;
        
        /// <remarks/>
        public event rechercheVolsAvecDateCompletedEventHandler rechercheVolsAvecDateCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/rechercheVols", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public clsVol[] rechercheVols(string villeDepart, string villeArrivee) {
            object[] results = this.Invoke("rechercheVols", new object[] {
                        villeDepart,
                        villeArrivee});
            return ((clsVol[])(results[0]));
        }
        
        /// <remarks/>
        public void rechercheVolsAsync(string villeDepart, string villeArrivee) {
            this.rechercheVolsAsync(villeDepart, villeArrivee, null);
        }
        
        /// <remarks/>
        public void rechercheVolsAsync(string villeDepart, string villeArrivee, object userState) {
            if ((this.rechercheVolsOperationCompleted == null)) {
                this.rechercheVolsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnrechercheVolsOperationCompleted);
            }
            this.InvokeAsync("rechercheVols", new object[] {
                        villeDepart,
                        villeArrivee}, this.rechercheVolsOperationCompleted, userState);
        }
        
        private void OnrechercheVolsOperationCompleted(object arg) {
            if ((this.rechercheVolsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.rechercheVolsCompleted(this, new rechercheVolsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/rechercheVolsAvecDate", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public clsVol[] rechercheVolsAvecDate(string villeDepart, string villeArrivee, System.DateTime dateDepart) {
            object[] results = this.Invoke("rechercheVolsAvecDate", new object[] {
                        villeDepart,
                        villeArrivee,
                        dateDepart});
            return ((clsVol[])(results[0]));
        }
        
        /// <remarks/>
        public void rechercheVolsAvecDateAsync(string villeDepart, string villeArrivee, System.DateTime dateDepart) {
            this.rechercheVolsAvecDateAsync(villeDepart, villeArrivee, dateDepart, null);
        }
        
        /// <remarks/>
        public void rechercheVolsAvecDateAsync(string villeDepart, string villeArrivee, System.DateTime dateDepart, object userState) {
            if ((this.rechercheVolsAvecDateOperationCompleted == null)) {
                this.rechercheVolsAvecDateOperationCompleted = new System.Threading.SendOrPostCallback(this.OnrechercheVolsAvecDateOperationCompleted);
            }
            this.InvokeAsync("rechercheVolsAvecDate", new object[] {
                        villeDepart,
                        villeArrivee,
                        dateDepart}, this.rechercheVolsAvecDateOperationCompleted, userState);
        }
        
        private void OnrechercheVolsAvecDateOperationCompleted(object arg) {
            if ((this.rechercheVolsAvecDateCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.rechercheVolsAvecDateCompleted(this, new rechercheVolsAvecDateCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class clsVol {
        
        private int idField;
        
        private string villeDepartField;
        
        private string villeArriveeField;
        
        private System.DateTime dateDepartField;
        
        private System.DateTime dateArriveeField;
        
        /// <remarks/>
        public int id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public string villeDepart {
            get {
                return this.villeDepartField;
            }
            set {
                this.villeDepartField = value;
            }
        }
        
        /// <remarks/>
        public string villeArrivee {
            get {
                return this.villeArriveeField;
            }
            set {
                this.villeArriveeField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime dateDepart {
            get {
                return this.dateDepartField;
            }
            set {
                this.dateDepartField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime dateArrivee {
            get {
                return this.dateArriveeField;
            }
            set {
                this.dateArriveeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void rechercheVolsCompletedEventHandler(object sender, rechercheVolsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class rechercheVolsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal rechercheVolsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public clsVol[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((clsVol[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void rechercheVolsAvecDateCompletedEventHandler(object sender, rechercheVolsAvecDateCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class rechercheVolsAvecDateCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal rechercheVolsAvecDateCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public clsVol[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((clsVol[])(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591