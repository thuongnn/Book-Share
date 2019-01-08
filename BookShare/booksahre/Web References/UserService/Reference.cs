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

namespace booksahre.UserService {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="UserServiceSoap", Namespace="http://tempuri.org/")]
    public partial class UserService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback checkLoginOperationCompleted;
        
        private System.Threading.SendOrPostCallback registerOperationCompleted;
        
        private System.Threading.SendOrPostCallback getUserByIdOperationCompleted;
        
        private System.Threading.SendOrPostCallback updateAvatarOperationCompleted;
        
        private System.Threading.SendOrPostCallback upadteInformationOperationCompleted;
        
        private System.Threading.SendOrPostCallback changePasswordOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public UserService() {
            this.Url = global::booksahre.Properties.Settings.Default.booksahre_UserService_UserService;
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
        public event checkLoginCompletedEventHandler checkLoginCompleted;
        
        /// <remarks/>
        public event registerCompletedEventHandler registerCompleted;
        
        /// <remarks/>
        public event getUserByIdCompletedEventHandler getUserByIdCompleted;
        
        /// <remarks/>
        public event updateAvatarCompletedEventHandler updateAvatarCompleted;
        
        /// <remarks/>
        public event upadteInformationCompletedEventHandler upadteInformationCompleted;
        
        /// <remarks/>
        public event changePasswordCompletedEventHandler changePasswordCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/checkLogin", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public User checkLogin(string username, string password) {
            object[] results = this.Invoke("checkLogin", new object[] {
                        username,
                        password});
            return ((User)(results[0]));
        }
        
        /// <remarks/>
        public void checkLoginAsync(string username, string password) {
            this.checkLoginAsync(username, password, null);
        }
        
        /// <remarks/>
        public void checkLoginAsync(string username, string password, object userState) {
            if ((this.checkLoginOperationCompleted == null)) {
                this.checkLoginOperationCompleted = new System.Threading.SendOrPostCallback(this.OncheckLoginOperationCompleted);
            }
            this.InvokeAsync("checkLogin", new object[] {
                        username,
                        password}, this.checkLoginOperationCompleted, userState);
        }
        
        private void OncheckLoginOperationCompleted(object arg) {
            if ((this.checkLoginCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.checkLoginCompleted(this, new checkLoginCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/register", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string register(string username, string email, string fullname, string password, System.DateTime date) {
            object[] results = this.Invoke("register", new object[] {
                        username,
                        email,
                        fullname,
                        password,
                        date});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void registerAsync(string username, string email, string fullname, string password, System.DateTime date) {
            this.registerAsync(username, email, fullname, password, date, null);
        }
        
        /// <remarks/>
        public void registerAsync(string username, string email, string fullname, string password, System.DateTime date, object userState) {
            if ((this.registerOperationCompleted == null)) {
                this.registerOperationCompleted = new System.Threading.SendOrPostCallback(this.OnregisterOperationCompleted);
            }
            this.InvokeAsync("register", new object[] {
                        username,
                        email,
                        fullname,
                        password,
                        date}, this.registerOperationCompleted, userState);
        }
        
        private void OnregisterOperationCompleted(object arg) {
            if ((this.registerCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.registerCompleted(this, new registerCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getUserById", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public User getUserById(int id) {
            object[] results = this.Invoke("getUserById", new object[] {
                        id});
            return ((User)(results[0]));
        }
        
        /// <remarks/>
        public void getUserByIdAsync(int id) {
            this.getUserByIdAsync(id, null);
        }
        
        /// <remarks/>
        public void getUserByIdAsync(int id, object userState) {
            if ((this.getUserByIdOperationCompleted == null)) {
                this.getUserByIdOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetUserByIdOperationCompleted);
            }
            this.InvokeAsync("getUserById", new object[] {
                        id}, this.getUserByIdOperationCompleted, userState);
        }
        
        private void OngetUserByIdOperationCompleted(object arg) {
            if ((this.getUserByIdCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getUserByIdCompleted(this, new getUserByIdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/updateAvatar", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string updateAvatar(string rootPath, string filename, int idUser, [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")] byte[] bytes) {
            object[] results = this.Invoke("updateAvatar", new object[] {
                        rootPath,
                        filename,
                        idUser,
                        bytes});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void updateAvatarAsync(string rootPath, string filename, int idUser, byte[] bytes) {
            this.updateAvatarAsync(rootPath, filename, idUser, bytes, null);
        }
        
        /// <remarks/>
        public void updateAvatarAsync(string rootPath, string filename, int idUser, byte[] bytes, object userState) {
            if ((this.updateAvatarOperationCompleted == null)) {
                this.updateAvatarOperationCompleted = new System.Threading.SendOrPostCallback(this.OnupdateAvatarOperationCompleted);
            }
            this.InvokeAsync("updateAvatar", new object[] {
                        rootPath,
                        filename,
                        idUser,
                        bytes}, this.updateAvatarOperationCompleted, userState);
        }
        
        private void OnupdateAvatarOperationCompleted(object arg) {
            if ((this.updateAvatarCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.updateAvatarCompleted(this, new updateAvatarCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/upadteInformation", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool upadteInformation(int idUser, string fullname, string birthday, string email, string address, string phone, string linkFacebook) {
            object[] results = this.Invoke("upadteInformation", new object[] {
                        idUser,
                        fullname,
                        birthday,
                        email,
                        address,
                        phone,
                        linkFacebook});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void upadteInformationAsync(int idUser, string fullname, string birthday, string email, string address, string phone, string linkFacebook) {
            this.upadteInformationAsync(idUser, fullname, birthday, email, address, phone, linkFacebook, null);
        }
        
        /// <remarks/>
        public void upadteInformationAsync(int idUser, string fullname, string birthday, string email, string address, string phone, string linkFacebook, object userState) {
            if ((this.upadteInformationOperationCompleted == null)) {
                this.upadteInformationOperationCompleted = new System.Threading.SendOrPostCallback(this.OnupadteInformationOperationCompleted);
            }
            this.InvokeAsync("upadteInformation", new object[] {
                        idUser,
                        fullname,
                        birthday,
                        email,
                        address,
                        phone,
                        linkFacebook}, this.upadteInformationOperationCompleted, userState);
        }
        
        private void OnupadteInformationOperationCompleted(object arg) {
            if ((this.upadteInformationCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.upadteInformationCompleted(this, new upadteInformationCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/changePassword", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool changePassword(int userId, string oldPass, string newPass) {
            object[] results = this.Invoke("changePassword", new object[] {
                        userId,
                        oldPass,
                        newPass});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void changePasswordAsync(int userId, string oldPass, string newPass) {
            this.changePasswordAsync(userId, oldPass, newPass, null);
        }
        
        /// <remarks/>
        public void changePasswordAsync(int userId, string oldPass, string newPass, object userState) {
            if ((this.changePasswordOperationCompleted == null)) {
                this.changePasswordOperationCompleted = new System.Threading.SendOrPostCallback(this.OnchangePasswordOperationCompleted);
            }
            this.InvokeAsync("changePassword", new object[] {
                        userId,
                        oldPass,
                        newPass}, this.changePasswordOperationCompleted, userState);
        }
        
        private void OnchangePasswordOperationCompleted(object arg) {
            if ((this.changePasswordCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.changePasswordCompleted(this, new changePasswordCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class User {
        
        private int idField;
        
        private string fullNameField;
        
        private System.DateTime birthdayField;
        
        private string avatarField;
        
        private string userNameField;
        
        private string passwordField;
        
        private string emailField;
        
        private string addressField;
        
        private string phoneNumberField;
        
        private string linkFacebookField;
        
        private int userPointField;
        
        private System.DateTime createDateField;
        
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
        public string fullName {
            get {
                return this.fullNameField;
            }
            set {
                this.fullNameField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime birthday {
            get {
                return this.birthdayField;
            }
            set {
                this.birthdayField = value;
            }
        }
        
        /// <remarks/>
        public string avatar {
            get {
                return this.avatarField;
            }
            set {
                this.avatarField = value;
            }
        }
        
        /// <remarks/>
        public string userName {
            get {
                return this.userNameField;
            }
            set {
                this.userNameField = value;
            }
        }
        
        /// <remarks/>
        public string password {
            get {
                return this.passwordField;
            }
            set {
                this.passwordField = value;
            }
        }
        
        /// <remarks/>
        public string email {
            get {
                return this.emailField;
            }
            set {
                this.emailField = value;
            }
        }
        
        /// <remarks/>
        public string address {
            get {
                return this.addressField;
            }
            set {
                this.addressField = value;
            }
        }
        
        /// <remarks/>
        public string phoneNumber {
            get {
                return this.phoneNumberField;
            }
            set {
                this.phoneNumberField = value;
            }
        }
        
        /// <remarks/>
        public string linkFacebook {
            get {
                return this.linkFacebookField;
            }
            set {
                this.linkFacebookField = value;
            }
        }
        
        /// <remarks/>
        public int userPoint {
            get {
                return this.userPointField;
            }
            set {
                this.userPointField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime createDate {
            get {
                return this.createDateField;
            }
            set {
                this.createDateField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void checkLoginCompletedEventHandler(object sender, checkLoginCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class checkLoginCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal checkLoginCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public User Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((User)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void registerCompletedEventHandler(object sender, registerCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class registerCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal registerCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void getUserByIdCompletedEventHandler(object sender, getUserByIdCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getUserByIdCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getUserByIdCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public User Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((User)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void updateAvatarCompletedEventHandler(object sender, updateAvatarCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class updateAvatarCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal updateAvatarCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void upadteInformationCompletedEventHandler(object sender, upadteInformationCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class upadteInformationCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal upadteInformationCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void changePasswordCompletedEventHandler(object sender, changePasswordCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class changePasswordCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal changePasswordCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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