﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Bu kod araç tarafından oluşturuldu.
//     Çalışma Zamanı Sürümü:4.0.30319.42000
//
//     Bu dosyada yapılacak değişiklikler yanlış davranışa neden olabilir ve
//     kod yeniden oluşturulursa kaybolur.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Kaynak kodu Microsoft.VSDesigner tarafından otomatik üretilmiş , Sürüm 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace DLL.web_localhost {
    using System.Diagnostics;
    using System;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System.Web.Services;
    using System.Data;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="WebService1Soap", Namespace="http://tempuri.org/")]
    public partial class WebService1 : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback r_MusteriOperationCompleted;
        
        private System.Threading.SendOrPostCallback c_MusteriOperationCompleted;
        
        private System.Threading.SendOrPostCallback u_MusteriOperationCompleted;
        
        private System.Threading.SendOrPostCallback d_MusteriOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public WebService1() {
            this.Url = global::DLL.Properties.Settings.Default.DLL_web_localhost_WebService1;
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
        public event r_MusteriCompletedEventHandler r_MusteriCompleted;
        
        /// <remarks/>
        public event c_MusteriCompletedEventHandler c_MusteriCompleted;
        
        /// <remarks/>
        public event u_MusteriCompletedEventHandler u_MusteriCompleted;
        
        /// <remarks/>
        public event d_MusteriCompletedEventHandler d_MusteriCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/r_Musteri", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataTable r_Musteri(string _sql) {
            object[] results = this.Invoke("r_Musteri", new object[] {
                        _sql});
            return ((System.Data.DataTable)(results[0]));
        }
        
        /// <remarks/>
        public void r_MusteriAsync(string _sql) {
            this.r_MusteriAsync(_sql, null);
        }
        
        /// <remarks/>
        public void r_MusteriAsync(string _sql, object userState) {
            if ((this.r_MusteriOperationCompleted == null)) {
                this.r_MusteriOperationCompleted = new System.Threading.SendOrPostCallback(this.Onr_MusteriOperationCompleted);
            }
            this.InvokeAsync("r_Musteri", new object[] {
                        _sql}, this.r_MusteriOperationCompleted, userState);
        }
        
        private void Onr_MusteriOperationCompleted(object arg) {
            if ((this.r_MusteriCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.r_MusteriCompleted(this, new r_MusteriCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/c_Musteri", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool c_Musteri(string _sql, string adi, string soyadi, int TCNo, System.DateTime dogumTarihi, string profilResimYolu) {
            object[] results = this.Invoke("c_Musteri", new object[] {
                        _sql,
                        adi,
                        soyadi,
                        TCNo,
                        dogumTarihi,
                        profilResimYolu});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void c_MusteriAsync(string _sql, string adi, string soyadi, int TCNo, System.DateTime dogumTarihi, string profilResimYolu) {
            this.c_MusteriAsync(_sql, adi, soyadi, TCNo, dogumTarihi, profilResimYolu, null);
        }
        
        /// <remarks/>
        public void c_MusteriAsync(string _sql, string adi, string soyadi, int TCNo, System.DateTime dogumTarihi, string profilResimYolu, object userState) {
            if ((this.c_MusteriOperationCompleted == null)) {
                this.c_MusteriOperationCompleted = new System.Threading.SendOrPostCallback(this.Onc_MusteriOperationCompleted);
            }
            this.InvokeAsync("c_Musteri", new object[] {
                        _sql,
                        adi,
                        soyadi,
                        TCNo,
                        dogumTarihi,
                        profilResimYolu}, this.c_MusteriOperationCompleted, userState);
        }
        
        private void Onc_MusteriOperationCompleted(object arg) {
            if ((this.c_MusteriCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.c_MusteriCompleted(this, new c_MusteriCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/u_Musteri", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool u_Musteri(string _sql, int id, string adi, string soyadi, int TCNo, System.DateTime dogumTarihi, string profilResimYolu) {
            object[] results = this.Invoke("u_Musteri", new object[] {
                        _sql,
                        id,
                        adi,
                        soyadi,
                        TCNo,
                        dogumTarihi,
                        profilResimYolu});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void u_MusteriAsync(string _sql, int id, string adi, string soyadi, int TCNo, System.DateTime dogumTarihi, string profilResimYolu) {
            this.u_MusteriAsync(_sql, id, adi, soyadi, TCNo, dogumTarihi, profilResimYolu, null);
        }
        
        /// <remarks/>
        public void u_MusteriAsync(string _sql, int id, string adi, string soyadi, int TCNo, System.DateTime dogumTarihi, string profilResimYolu, object userState) {
            if ((this.u_MusteriOperationCompleted == null)) {
                this.u_MusteriOperationCompleted = new System.Threading.SendOrPostCallback(this.Onu_MusteriOperationCompleted);
            }
            this.InvokeAsync("u_Musteri", new object[] {
                        _sql,
                        id,
                        adi,
                        soyadi,
                        TCNo,
                        dogumTarihi,
                        profilResimYolu}, this.u_MusteriOperationCompleted, userState);
        }
        
        private void Onu_MusteriOperationCompleted(object arg) {
            if ((this.u_MusteriCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.u_MusteriCompleted(this, new u_MusteriCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/d_Musteri", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool d_Musteri(string _sql, int id) {
            object[] results = this.Invoke("d_Musteri", new object[] {
                        _sql,
                        id});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void d_MusteriAsync(string _sql, int id) {
            this.d_MusteriAsync(_sql, id, null);
        }
        
        /// <remarks/>
        public void d_MusteriAsync(string _sql, int id, object userState) {
            if ((this.d_MusteriOperationCompleted == null)) {
                this.d_MusteriOperationCompleted = new System.Threading.SendOrPostCallback(this.Ond_MusteriOperationCompleted);
            }
            this.InvokeAsync("d_Musteri", new object[] {
                        _sql,
                        id}, this.d_MusteriOperationCompleted, userState);
        }
        
        private void Ond_MusteriOperationCompleted(object arg) {
            if ((this.d_MusteriCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.d_MusteriCompleted(this, new d_MusteriCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void r_MusteriCompletedEventHandler(object sender, r_MusteriCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class r_MusteriCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal r_MusteriCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataTable Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataTable)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void c_MusteriCompletedEventHandler(object sender, c_MusteriCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class c_MusteriCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal c_MusteriCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void u_MusteriCompletedEventHandler(object sender, u_MusteriCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class u_MusteriCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal u_MusteriCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void d_MusteriCompletedEventHandler(object sender, d_MusteriCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class d_MusteriCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal d_MusteriCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
}

#pragma warning restore 1591