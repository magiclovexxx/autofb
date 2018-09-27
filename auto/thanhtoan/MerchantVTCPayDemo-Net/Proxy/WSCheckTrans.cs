﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;

// 
// This source code was auto-generated by wsdl, Version=4.0.30319.33440.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.33440")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Web.Services.WebServiceBindingAttribute(Name="WSCheckTransSoap", Namespace="http://tempuri.org/")]
public partial class WSCheckTrans : System.Web.Services.Protocols.SoapHttpClientProtocol {
    
    private System.Threading.SendOrPostCallback CheckPartnerTransationOperationCompleted;
    
    /// <remarks/>
    public WSCheckTrans() {
        this.Url = "https://beta-pay.vtc.vn/cong-thanh-toan/WSCheckTrans.asmx";
    }
    
    /// <remarks/>
    public event CheckPartnerTransationCompletedEventHandler CheckPartnerTransationCompleted;
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CheckPartnerTransation", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public string CheckPartnerTransation(int website_id, string order_code, string receiver_acc, string sign) {
        object[] results = this.Invoke("CheckPartnerTransation", new object[] {
                    website_id,
                    order_code,
                    receiver_acc,
                    sign});
        return ((string)(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginCheckPartnerTransation(int website_id, string order_code, string receiver_acc, string sign, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("CheckPartnerTransation", new object[] {
                    website_id,
                    order_code,
                    receiver_acc,
                    sign}, callback, asyncState);
    }
    
    /// <remarks/>
    public string EndCheckPartnerTransation(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((string)(results[0]));
    }
    
    /// <remarks/>
    public void CheckPartnerTransationAsync(int website_id, string order_code, string receiver_acc, string sign) {
        this.CheckPartnerTransationAsync(website_id, order_code, receiver_acc, sign, null);
    }
    
    /// <remarks/>
    public void CheckPartnerTransationAsync(int website_id, string order_code, string receiver_acc, string sign, object userState) {
        if ((this.CheckPartnerTransationOperationCompleted == null)) {
            this.CheckPartnerTransationOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCheckPartnerTransationOperationCompleted);
        }
        this.InvokeAsync("CheckPartnerTransation", new object[] {
                    website_id,
                    order_code,
                    receiver_acc,
                    sign}, this.CheckPartnerTransationOperationCompleted, userState);
    }
    
    private void OnCheckPartnerTransationOperationCompleted(object arg) {
        if ((this.CheckPartnerTransationCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.CheckPartnerTransationCompleted(this, new CheckPartnerTransationCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    public new void CancelAsync(object userState) {
        base.CancelAsync(userState);
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.33440")]
public delegate void CheckPartnerTransationCompletedEventHandler(object sender, CheckPartnerTransationCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.33440")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class CheckPartnerTransationCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal CheckPartnerTransationCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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