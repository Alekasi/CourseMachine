<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="courseMachineUi.Views.LogReg.logReg" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="logRegPage" ng-controller="logRegController">
    <div class="logRegBox">
        <asp:Button CssClass="loginColor buttonLink" runat="server" ID="loginLink" Text="Login" OnClick="loginLink_Click" />
        <asp:Button CssClass="registerColor buttonLink" runat="server" ID="registerLink" Text="Register" OnClick="registerLink_Click" />
    </div>
    <div runat="server" id="errorContainer" class="errorContainer loginColor">
        
    </div>
    <div class="logRegContainer">
      <div class="loginColor">
        <input runat="server" id="loginEmail" class="inputText" type="email" placeholder="email">
        <input runat="server" id="loginPassword" class="inputText" type="password" placeholder="password">
        <asp:Button ID="loginButton" runat="server" CssClass="inputButton" Text="Login" OnClick="loginButton_Click" />
      </div>
    </div>
  </div>
</asp:Content>