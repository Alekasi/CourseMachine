<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="courseMachineUi.Account.emailConfirmation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
  <div class="logRegPage" ng-controller="logRegController">
    <div class="logRegBox">
        <asp:Button CssClass="loginColor buttonLink" runat="server" ID="loginLink" Text="Login" OnClick="loginLink_Click" />
        <asp:Button CssClass="registerColor buttonLink" runat="server" ID="registerLink" Text="Register" OnClick="registerLink_Click" />
    </div>
    <div runat="server" id="errorContainer" class="errorContainer registerColor">
        
    </div>
    <div class="logRegContainer">
      <div class="registerColor">
        <input runat="server" class="inputText" id="registerEmail" type="email" placeholder="email">
        <input runat="server" class="inputText" id="registerPassword" type="password" placeholder="password">
        <input runat="server" class="inputText" id="registerRePassword" type="password" placeholder="Retype password">
        <asp:Button ID="registerButton" runat="server" CssClass="inputButton" Text="Register" OnClick="registerButton_Click" />
      </div>
    </div>
  </div>
</asp:Content>
